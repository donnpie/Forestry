using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public enum VolumeUnit
    {
        Null,
        CubicMillimeters,
        CubicCentimeters,
        CubicMeters,
        CubicInches,
        CubicFeet,
        CubicYards,
        BoardFeet,
        Cords
    }

    public enum VolumeType
    {
        Null,
        GreenWood,
        DryWood
    }
    public interface IVolume
    {
        /// <summary>
        /// Volume in cubic meters
        /// </summary>
        float VolumeM3 { get; } //set should be private and can be set when object is initialised

        /// <summary>
        /// Volume in the currently selected units. Default is cubic meters
        /// </summary>
        float VolumeInSelectedUnit { get; set; }

        /// <summary>
        /// Gives the unit corresponding to VolumeInSelectedUnit
        /// </summary>
        VolumeUnit Unit { get; set; }

        /// <summary>
        /// Type is used to ensure we don't inadvertently add up different types of volumes
        /// </summary>
        VolumeType Type { get; } //No setter needed - set on construction

        /// <summary>
        /// Returns a new object with value converted to a radius
        /// Assumes the volume is cylindrical
        /// <parameter>Height as Length</parameter>
        /// </summary>
        ILength ToRadius(ILength height);

        /// <summary>
        /// Returns a new object with value converted to a diameter
        /// Assumes the volume is cylindrical
        /// <parameter>Height as Length</parameter>
        /// </summary>
        ILength ToDiameter(ILength height);

        /// <summary>
        /// Returns a new object with value converted to a circumference
        /// Assumes the volume is cylindrical
        /// <parameter>Height as Length</parameter>
        /// </summary>
        ILength ToCircumference(ILength height);

        /// <summary>
        /// Returns a new object with value converted to an area
        /// Assumes the volume is cylindrical
        /// </summary>
        /// <param name="height"></param>
        IArea ToArea(ILength height);

        /// <summary>
        /// Returns the density, given the weight
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        IDensity ToDensity(IWeight weight);

        /// <summary>
        /// Returns a double that represents the volume in the current units
        /// </summary>
        double ToDouble();

    }
}
