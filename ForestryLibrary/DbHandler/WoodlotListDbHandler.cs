using ForestryLibrary.Helper;
using ForestryLibrary.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ForestryLibrary.DbHandler
{
    class WoodlotListDbHandler : IListDbHandler
    {
        public List<IForestObject> ForestObjects { get; set; }

        public SqlConnection Connection { get; private set; }

        public SqlCommand Command { get; private set; }

        public SqlDataReader Reader { get; private set; }

        //public WoodlotQueryType QueryType { get; set; } //Need to find a way to make this a generic type
        
        public ListQueryType QType { get; set; }


        #region Constructors
        public WoodlotListDbHandler()
        {
            Connection = new SqlConnection(Constant.ForestConnectionString);
            Command = Connection.CreateCommand();
            //IDbHandler.QueryType = WoodlotQueryType.Null; //How do I get this to work?
            QType = ListQueryType.Null;
        }



        #endregion

        public void BuildQuery()
        {
            switch (QType)
            {
                case (ListQueryType.WoodlotsBasicDataForAll):
                    Command.CommandText = "SELECT * FROM Woodlot"; //Need to update this
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
            //Loop through the reader
            while (Reader.Read())
            {
                if (QType == ListQueryType.WoodlotsBasicDataForAll)
                {
                    var woodlot = (Woodlot)ForestObjectFactory.NewForestObject("Woodlot");           
                    woodlot.Id = Reader.GetInt32(0);
                    woodlot.Name = Reader.GetString(1);
                    ForestObjects.Add(woodlot);
                    
                }

            }
        }

        public void Close()
        {
            Connection.Close();  //Connection has to remain open until reader has finished reading
        }

        public void BuildQuery(int searchKey)
        {
            throw new NotImplementedException();
        }
    }
}
