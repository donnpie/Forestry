using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    class Sample : ISample
    {
        public List<ITree> TreeList { get; private set; }

        public IGeography CenterLocation => throw new NotImplementedException();

        public ILength SampleRadius => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string Comments => throw new NotImplementedException();
        #region Constructors
        public Sample()
        {
            TreeList = new List<ITree>();
        }



        #endregion
        public IArea BasalArea()
        {
            throw new NotImplementedException();
        }

        public int TreeCount()
        {
            throw new NotImplementedException();
        }
    }
}
