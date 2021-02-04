using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public interface IGeography
    {
        //TODO: Add validation to concrete class ensure only valid coordinates are possible
        //see https://docs.microsoft.com/en-us/sql/relational-databases/spatial/point?view=sql-server-ver15

        /// <summary>
        /// Latitude (vertical or y-coordinate) part of a coordinate set
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// Longitude (horizontal or x-coordinate) part of a coordinate set
        /// </summary>
        public double Long { get; set; }

        /// <summary>
        /// Spatial Reference Identifer
        /// </summary>
        public int Srid { get; set; }


    }
}
