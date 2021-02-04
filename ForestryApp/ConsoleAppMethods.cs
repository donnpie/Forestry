using System;
using System.Collections.Generic;
using System.Text;
using ForestryLibrary.Main;
using ForestryLibrary.DbHandler;
using System.Data.SqlClient;
using System.Linq;

namespace ForestryApp
{
    /// <summary>
    /// This class contains objects and methods that are used to run the console app
    /// </summary>
    class ConsoleAppMethods
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the forestry inventory management app!");          
        }

        #region Menus
        public void ShowMainMenu()
        {
            Console.WriteLine("To view existing woodlots, enter 'view-woodlots'");
            Console.WriteLine("To create new forest objects, enter 'new'");
            Console.WriteLine("To see the main menue, enter 'menu'");
            Console.WriteLine("To exit the app, enter 'exit'");
        }

        public void ShowWoodlotListMenu()
        {
            Console.WriteLine("To view a specific woodlot, enter 'woodlot'");
            Console.WriteLine("To add a new woodlot to the list, enter 'new'");
            Console.WriteLine("To see the woodlot list menu again, enter 'menu'");
            Console.WriteLine("To go back, enter 'back'");
        }

        public void ShowStandAndCampaignMenu()
        {
            Console.WriteLine("To view a specific stand, enter 'stand'");
            Console.WriteLine("To view a specific campaign, enter 'campaign'");
            Console.WriteLine("To add a new stand to the list of stands, enter 'new-stand'");
            Console.WriteLine("To add a new campaign to the list of campaigns, enter 'new-campaign'");
            Console.WriteLine("To see the stand and campaign menu again, enter 'menu'");
            Console.WriteLine("To go back, enter 'back'");
        }




        #endregion

        #region Loops
        public void MainLoop()
        {
            string command;
            var woodlotList = ForestObjectFactory.NewForestObjectList(); //returns List<IForestObject>
            do
            {
                command = Console.ReadLine();
                switch (command.Trim().ToLower())
                {
                    case "view-woodlots":
                        ViewWoodlots(woodlotList);
                        ShowWoodlotListMenu();
                        WoodlotLoop(woodlotList);
                        ShowMainMenu();
                        break;
                    case "new":
                        Console.WriteLine($"the command is {command} and the length is {command.Length}");
                        //show list of new items that can be created
                        ShowMainMenu();
                        break;
                    case "menu":
                        ShowMainMenu();
                        break;
                    case "exit":
                        //Console.WriteLine($"the command is {command} and the length is {command.Length}");
                        //Exit the app
                        break;
                    default:
                        ShowMainMenu();
                        break;
                }
            } while (command.ToLower() != "exit");
        }

        public void WoodlotLoop(List<IForestObject> woodlotList)
        {
            string command;
            do
            {
                command = Console.ReadLine();

                switch (command.Trim().ToLower())
                {
                    case "woodlot":
                        ShowDetailsForWoodlot(woodlotList);
                        ShowStandAndCampaignMenu();
                        StandAndCampaignLoop();
                        ShowWoodlotListMenu();
                        break;
                    case "new":
                        Console.WriteLine($"Simulating adding a new woodlot to the woodlot list");
                        break;
                    case "menu":
                        ShowWoodlotListMenu();
                        break;
                    case "back":
                        Console.WriteLine($"Going back...");
                        break;
                    default:
                        ShowWoodlotListMenu();
                        break;
                }

            } while (command.ToLower() != "back");
        }

        public void StandAndCampaignLoop()
        {
            string command;
            do
            {
                command = Console.ReadLine();
                switch (command.Trim().ToLower())
                {
                    case "stand":
                        //ShowDetailsForWoodlot();
                        throw new NotImplementedException();
                        break;
                    case "campaign":
                        throw new NotImplementedException();
                        break;
                    case "new-stand":
                        //ShowDetailsForWoodlot();
                        throw new NotImplementedException();
                        break;
                    case "new-campaign":
                        throw new NotImplementedException();
                        break;
                    case "menu":
                        ShowStandAndCampaignMenu();
                        break;
                    case "back":
                        Console.WriteLine($"Going back...");
                        break;
                    default:
                        ShowStandAndCampaignMenu();
                        break;
                }

            } while (command.ToLower() != "back");
        }

        #endregion

        /// <summary>
        /// Queries the db and builds a list of woodlots
        /// </summary>
        /// <param name="woodlotList"></param>
        public void ViewWoodlots(List<IForestObject> woodlotList)
        {
            Console.WriteLine($"Fetching the list of woodlots...");

            //create the DbHandler object and pass the woodlot list to the dbhandler
            var woodlotListDbHandler = DbHandlerFactory.NewListDbHandler("Woodlot"); //returns WoodlotListDbHandler
            woodlotListDbHandler.ForestObjects = woodlotList; //The type of ForestObjects is List<IForestObject>

            //Define the type of query, build the query string, execute the query, get reader, update forest object
            woodlotListDbHandler.QType = ListQueryType.WoodlotsBasicDataForAll;
            woodlotListDbHandler.BuildQuery();
            woodlotListDbHandler.SqlGetReader();

            //Print list of woodlots list of woodlots (using while loop)
            foreach (var fo in woodlotList)
            {
                Woodlot wl = (Woodlot)fo;
                Console.WriteLine($"ID: {wl.Id}, name: {wl.Name}");
            }
        }

        /// <summary>
        /// Queries the db and builds a lists of stands and campaigns for a given woodlot
        /// </summary>
        /// <param name="woodlotList"></param>
        public void ShowDetailsForWoodlot(List<IForestObject> woodlotList)
        {
            //User enters Woodlot ID number. Check that given ID is valid
            string command;
            int id;
            bool isSuccessful = false;
            do
            {
                Console.WriteLine($"Enter the ID for the woodlot: ");
                command = Console.ReadLine();
                
                int.TryParse(command.Trim().ToLower(), out id); //try to convert the string to an int
                if (id > 0) //conversion successful
                {
                    //This is a bit hacky, but it works
                    var woodlots = (from woodlot in woodlotList where woodlot.Id == id select woodlot);
                        if (woodlots.Count()==1)
                        {
                            Console.WriteLine($"Conversion was successful. ID is: {woodlots.First().Id}");
                            isSuccessful = true;
                        }
                        else
                        {
                            Console.WriteLine("Conversion was not successful. Try again");
                            isSuccessful = false;
                        }                             
                }
     
            } while (isSuccessful != true);
            
            //Create woodlot db handler, assign to correct woodlot in list
            var selectedWoodlot = (from woodlot in woodlotList where woodlot.Id == id select woodlot).First(); //Get the woodlot again
            var woodlotDbHandler = DbHandlerFactory.NewObjectDbHandler("Woodlot");
            woodlotDbHandler.ForestObject = selectedWoodlot;

            //Set the QueryType for stands query
            woodlotDbHandler.QType = ObjectQueryType.WoodlotStandsForSingle;

            //Build stands query, get reader and update woodlot object
            woodlotDbHandler.BuildQuery(woodlotDbHandler.ForestObject.Id);
            woodlotDbHandler.SqlGetReader();

            //Set the QueryType for campaigns query
            woodlotDbHandler.QType = ObjectQueryType.WoodlotCampaignsForSingle;

            //Build stands query, get reader and update woodlot object
            woodlotDbHandler.BuildQuery(woodlotDbHandler.ForestObject.Id);
            woodlotDbHandler.SqlGetReader();

            //Print results to screen (details for the given woodlot, incl list of stands & campaigns)          
            Console.WriteLine($"Stand list for woolot (Woodlot ID: {selectedWoodlot.Id}, Woodlot name: {selectedWoodlot.Name}");
            foreach (var fo in ((Woodlot)selectedWoodlot).StandList)
            {
                Console.WriteLine($"    Stand ID: {fo.Id}, Stand name: {fo.Name}");
            }
            Console.WriteLine($"Campaign list for woolot (Woodlot ID: {selectedWoodlot.Id}, Woodlot name: {selectedWoodlot.Name}");
            foreach (var fo in ((Woodlot)selectedWoodlot).CampaignList)
            {
                Console.WriteLine($"    Campaign ID: {fo.Id}, Campaign name: {fo.Name}");
            }
        }



        
    }
}
