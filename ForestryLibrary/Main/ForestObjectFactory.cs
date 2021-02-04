using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public static class ForestObjectFactory
    {
        public static IForestObject NewForestObject(string forestObjectType)
        {
            return forestObjectType switch
            {
                ("Woodlot") => new Woodlot(),
                ("Stand") => new Stand(),
                ("Tree") => new Tree(),
                ("Campaign") => new Campaign(),
                ("Inventory") => new Inventory(),
                ("Sample") => new Sample(),
                ("Measurement") => new Measurement(),
                _ => throw new NotImplementedException(),
            };
        }

        /*
        /// <summary>
        /// Returns a new list of forest objects of the specified type
        /// </summary>
        /// <param name="forestObjectType"></param>
        /// <returns></returns>
        /// 
        */
        //public static List<IForestObject> NewForestObjectList(string forestObjectType)
        //{
        //    //Can't get this working. Workaround is to create public static List<Woodlot> NewWoodlotList()
        //    //Will debug later. This article may help:
        //    //https://stackoverflow.com/questions/12324020/cannot-implicitly-convert-derived-type-to-its-base-generic-type
        //    return forestObjectType switch
        //    {
        //        ("Woodlot") => new List<Woodlot>(),
        //        _ => throw new NotImplementedException(),
        //    };
        //}

        public static List<IForestObject> NewForestObjectList()
        {
            return new List<IForestObject>();
        }


        /// <summary>
        /// Returns a new list of Woodlot objects
        /// </summary>
        /// <returns></returns>
        public static List<Woodlot> NewWoodlotList()
        {

            return new List<Woodlot>();
        }
    }
}
