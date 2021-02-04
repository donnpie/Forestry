using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public enum LengthUnit
    {
        Null,
        Millimeters,
        Centimeters,
        Meters,
        Kilometers,
        Inches,
        Feet,
        Yards
    }

    public enum LengthType
    {
        Null,
        Land,
        TreeHight,
        TreeRadius,
        TreeDiameter
    }

    //Accessibility for interfaces are internal by default, but accessibility for interface members are public by default
    public interface ILength
    {
        /// <summary>
        /// Length in meters
        /// </summary>
        float LengthM { get; } //set should be private and can be set when object is initialised
        
        /// <summary>
        /// Length in the currently selected units. Default is meters
        /// </summary>
        float LengthInSelectedUnit { get; set; }

        /// <summary>
        /// Gives the unit corresponding to LengthInSelectedUnit
        /// </summary>
        LengthUnit Unit { get; set; }

        /// <summary>
        /// Type is used to ensure we don't inadvertently add up different types of lenghts
        /// </summary>
        LengthType Type { get; } //No setter needed - set on construction

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
        /// Returns a new object with value converted to an area
        /// </summary>
        IArea ToArea();

        /// <summary>
        /// Returns a double that represents the length in the current units
        /// </summary>
        double ToDouble();

    }
}
