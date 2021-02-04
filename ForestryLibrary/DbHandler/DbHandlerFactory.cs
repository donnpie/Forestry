using ForestryLibrary.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.DbHandler
{

    public static class DbHandlerFactory
    {
        public static IObjectDbHandler NewObjectDbHandler(string forestObject)
        {
            return forestObject switch
            {
                ("Woodlot") => new WoodlotObjectDbHandler(),
                _ => throw new NotImplementedException()
            };
        }
        public static IObjectDbHandler NewDbHandler(IForestObject forestObject)
        {
            //TODO
            throw new NotImplementedException();
        }

        public static IObjectDbHandler NewDbHandler(Type type)
        {
            //TODO
            throw new NotImplementedException();
        }

        public static IListDbHandler NewListDbHandler(string forestObject)
        {
            return forestObject switch
            {
                ("Woodlot") => new WoodlotListDbHandler(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
