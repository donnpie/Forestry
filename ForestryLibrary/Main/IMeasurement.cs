using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface IMeasurement : IAbtractObject
    {
        /// <summary>
        /// Diameter at breast height
        /// </summary>
        ILength Dbh { get; }

        ILength Rbh { get; } //Is this prperty really necesary? Dbh has a method to convert from diameter to radius

        IArea BasalArea { get; } //Again, this can be obtained from Dbh

        IVolume TreeVolume { get; }

        int Age { get; }

        ILength Height { get; }

        ITreeCondition TreeCondition { get; }

        DateTime MeasurementDate { get; }
    }
}
