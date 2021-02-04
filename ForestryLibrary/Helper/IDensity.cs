using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public enum DensityUnit
    {
        Null,
        KilogramPerCubicMeter,
        TonsPerCubicMeter,
        PoundsPerCubicInch,
        PoundsPerCubicFoot
    }

    public enum DensityType
    {
        Null,
        GreenWood,
        DryWood
    }
    public interface IDensity
    {
        /// <summary>
        /// Density in kg per cubic meters
        /// </summary>
        float VolumeKgPerM3 { get; } //set should be private and can be set when object is initialised

        /// <summary>
        /// Density in the currently selected units. Default is kg per cubic meters
        /// </summary>
        float DensityInSelectedUnit { get; set; }

        /// <summary>
        /// Gives the unit corresponding to DensityInSelectedUnit
        /// </summary>
        DensityUnit Unit { get; set; }

        /// <summary>
        /// Densities should not be added up
        /// </summary>
        DensityType Type { get; } //No setter needed - set on construction

        /// <summary>
        /// Changes the density to correspond to the given weight and volume
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="volume"></param>
        void SetDensity(IWeight weight, IVolume volume);

        /// <summary>
        /// Returns the volume given the weight
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        IVolume ToVolume(IWeight weight);

        /// <summary>
        /// Returns the weight given the volume
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        IWeight ToWeight(IVolume volume);
    }
}
