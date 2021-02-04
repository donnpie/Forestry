using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    class Inventory : IInventory
    {
        public List<ISample> SampleList { get; private set; }

        public int Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string Comments => throw new NotImplementedException();


        #region Constructors
        public Inventory()
        {
            SampleList = new List<ISample>();
        }
        #endregion
        public IArea BasalArea()
        {
            throw new NotImplementedException();
        }

        public int SampleCount()
        {
            throw new NotImplementedException();
        }
    }
}
