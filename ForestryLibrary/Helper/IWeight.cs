using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public enum WeightUnit
    {
        Null,
        Kilogram,
        Tons,
        Pounds
    }

    public enum WeightType
    {
        Null,
        GreenWood,
        DryWood
    }
    public interface IWeight
    {
        /// <summary>
        /// Weight in kg
        /// </summary>
        float WeightKg { get; } //set should be private and can be set when object is initialised

        /// <summary>
        /// Weight in the currently selected units. Default is kg
        /// </summary>
        float WeightInSelectedUnit { get; set; }

        /// <summary>
        /// Gives the unit corresponding to WeightInSelectedUnit
        /// </summary>
        WeightUnit Unit { get; set; }

        /// <summary>
        /// Type is used to ensure we don't inadvertently add up different types of weights
        /// </summary>
        WeightType Type { get; } //No setter needed - set on construction
        /// <summary>
        /// Returns the density, given the volume
        /// </summary>
        /// <returns></returns>
        IDensity ToDensity(IVolume volume);

        /// <summary>
        /// Returns a double that represents the weight in the current units
        /// </summary>
        double ToDouble();

    }
}
