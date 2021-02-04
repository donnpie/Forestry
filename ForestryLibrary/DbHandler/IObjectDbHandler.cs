using ForestryLibrary.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ForestryLibrary.DbHandler
{
    public enum ObjectQueryType
    {
        Null,
        WoodlotBasicDataForSingle,
        WoodlotStandsForSingle,
        WoodlotCampaignsForSingle,
    }

    /// <summary>
    /// DbHandler for a single object in the db
    /// </summary>
    public interface IObjectDbHandler : IDbHandler
    {
        
        IForestObject ForestObject { get; set; }

        ObjectQueryType QType { get; set; }
        //How do I implement a generic type for the QueryType???
        //GenericDbHandlerQueryType<T> QueryType { get; }
        //void SetQueryType(System.Enum queryType);

    }
}
