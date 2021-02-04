using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public enum AreaUnit
    {
        Null,
        SquareMillimeters,
        SquareCentimeters,
        SquareMeters,
        Hectares,
        SquareKilometers,
        SquareInches,
        SquareFeet,
        SquareYards,
        Acres
    }

    public enum AreaType
    {
        Null,
        BasalArea,
        Land,
        General
    }
    public interface IArea
    {
        /// <summary>
        /// Area in square meters
        /// </summary>
        float AreaM2 { get; }

        /// <summary>
        /// Area in the currently selected units. Default is square meters
        /// </summary>
        float AreaInSelectedUnit { get; set; }

        /// <summary>
        /// Gives the unit corresponding to AreaInSelectedUnit
        /// </summary>
        AreaUnit Unit { get; set; }

        /// <summary>
        /// Type is used to ensure we don't inadvertently add up different types of areas
        /// </summary>
        AreaType Type { get; } //No setter needed - set on construction

        /// <summary>
        /// Returns a new object with value converted to a radius
        /// Only has effect for Type Diameter and Circumference
        /// </summary>
        ILength ToRadius();

        /// <summary>
        /// Returns a new object with value converted to a diameter
        /// </summary>
        ILength ToDiameter();

        /// <summary>
        /// Returns a new object with value converted to a circumference
        /// </summary>
        ILength ToCircumference();

        /// <summary>
        /// Returns a double that represents the area in the current units
        /// </summary>
        double ToDouble();

    }
}
