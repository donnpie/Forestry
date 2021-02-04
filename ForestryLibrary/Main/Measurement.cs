using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    class Measurement : IMeasurement
    {
        public ILength Dbh => throw new NotImplementedException();

        public ILength Rbh => throw new NotImplementedException();

        public IArea BasalArea => throw new NotImplementedException();

        public IVolume TreeVolume => throw new NotImplementedException();

        public int Age => throw new NotImplementedException();

        public ILength Height => throw new NotImplementedException();

        public ITreeCondition TreeCondition => throw new NotImplementedException();

        public DateTime MeasurementDate => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string Comments => throw new NotImplementedException();
    }
}
