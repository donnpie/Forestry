using ForestryLibrary.Helper;
using ForestryLibrary.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ForestryLibrary.DbHandler
{
    
    class WoodlotObjectDbHandler : IObjectDbHandler
    {
        
        public IForestObject ForestObject { get; set; }

        public SqlConnection Connection { get; private set; }

        public SqlCommand Command { get; private set; }

        public SqlDataReader Reader { get; private set; }

        //public WoodlotQueryType QueryType { get; set; } //Need to find a way to make this a generic type
        public ObjectQueryType QType { get; set; }
        

        #region Constructors
        public WoodlotObjectDbHandler()
        {
            Connection = new SqlConnection(Constant.ForestConnectionString);
            Command = Connection.CreateCommand();
            //IDbHandler.QueryType = WoodlotQueryType.Null; //How do I get this to work?
            QType = ObjectQueryType.Null;
        }

        #endregion

        public void BuildQuery()
        {
            switch (QType)
            {
                case (ObjectQueryType.WoodlotBasicDataForSingle):
                    Command.CommandText = "SELECT * FROM Woodlot";
                    break;
                default:
                    throw new InvalidOperationException();
            }
            
        }

        public void BuildQuery(int searchKey)
        {
            switch (QType)
            {
                case (ObjectQueryType.WoodlotBasicDataForSingle):
                    //Return basic woodlot info from the woodlot table
                    Command.CommandText = "DECLARE @WoodlotID INT; " +
                        "SELECT * FROM Woodlot WHERE WoodlotID = @WoodlotID";
                    Command.CommandType = System.Data.CommandType.Text;
                    Command.Parameters.AddWithValue("@Woodlot", searchKey); 
                    break;
                case (ObjectQueryType.WoodlotStandsForSingle):
                    //Return stand info from the Stand table for the given woodlot
                    Command.CommandText = "spStandsFromStandTable";
                    Command.Parameters.AddWithValue("@WoodlotID", searchKey); //This param is defined in the SP. See Sql Server
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    break;
                case (ObjectQueryType.WoodlotCampaignsForSingle):
                    //Return campaign info from the Campaigns table for the given woodlot
                    Command.CommandText = "spCampaignsFromCampaignTable";
                    Command.Parameters.Clear();
                    Command.Parameters.AddWithValue("@WoodlotID", searchKey); //This param is defined in the SP. See Sql Server
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }
        public void Open()
        {
            Connection.Open();
        }

      
        public void SqlGetReader()
        {
            this.Open();
            Reader = Command.ExecuteReader();
            UpdateForestObject();
            this.Close(); //Connection has to remain open until reader has finished reading
        }

        public void UpdateForestObject()
        {
            //Select correct case and loop through the reader
            switch (QType)
            {
                case ObjectQueryType.Null:
                    throw new NotImplementedException();
                    break;
                case ObjectQueryType.WoodlotBasicDataForSingle:
                    while (Reader.Read())
                    {
                        throw new NotImplementedException();
                    }
                    break;
                
                case ObjectQueryType.WoodlotStandsForSingle:
                    while (Reader.Read())
                    {
                        //Preconditions:
                        //ForestObject has been set to a Woodlot object
                        //Query has been correctly executed and contains a list of stands associated with the Woodlot
                        //QType has been set to ObjectQueryType.WoodlotStandsForSingle
                        //Process the list of stands - Note that Woodlot already has initialised list of StandObjects
                        if (ForestObject is Woodlot)
                        {
                            var stand = (Stand)ForestObjectFactory.NewForestObject("Stand");
                            stand.Id = Reader.GetInt32(0);
                            stand.Name = Reader.GetString(2);
                            ((Woodlot)ForestObject).StandList.Add(stand);
                        }
                        else
                        {
                            throw new TypeLoadException("Type of ForestObject must be Woodlot");
                        }
                    }
                    break;
                case ObjectQueryType.WoodlotCampaignsForSingle:
                    while (Reader.Read())
                    {
                        //Preconditions:
                        //ForestObject has been set to a Woodlot object
                        //Query has been correctly executed and contains a list of campaigns associated with the Woodlot
                        //QType has been set to ObjectQueryType.WoodlotCampaignsForSingle
                        //Process the list of campaigns - Note that Woodlot already has initialised list of Campaign objects
                        if (ForestObject is Woodlot)
                        {
                            var campaign = (Campaign)ForestObjectFactory.NewForestObject("Campaign");
                            campaign.Id = Reader.GetInt32(0);
                            campaign.Name = Reader.GetString(2);
                            ((Woodlot)ForestObject).CampaignList.Add(campaign);
                        }
                        else
                        {
                            throw new TypeLoadException("Type of ForestObject must be Woodlot");
                        }
                    }
                    break;
                default:
                    throw new InvalidOperationException();
                    break;

            }

        }

        public void Close()
        {
            Connection.Close();  //Connection has to remain open until reader has finished reading
        }


    }
}
