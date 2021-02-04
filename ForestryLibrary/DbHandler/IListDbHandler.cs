using ForestryLibrary.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.DbHandler
{
    public enum ListQueryType
    {
        Null,
        WoodlotsBasicDataForAll,
        WoodlotsStandsForForAll,
        WoodlotsCampaignsForForAll
    }
    /// <summary>
    /// DbHandler for a list of db objects
    /// </summary>
    public interface IListDbHandler : IDbHandler
    {
        List<IForestObject> ForestObjects { get; set; }

        ListQueryType QType { get; set; }
    }
}
