using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    class Campaign : ICampaign
    {
        #region Properties
        public List<IInventory> InventoryList { get; private set; }

        public int Id { get;  set; }

        public string Name { get; set; }

        public string Description => throw new NotImplementedException();

        public string Comments => throw new NotImplementedException();
        #endregion

        #region Constructors
        public Campaign()
        {
            InventoryList = new List<IInventory>();
        }
        #endregion


        #region Methods
        public IArea BasalArea()
        {
            throw new NotImplementedException();
        }

        public int InventoryCount()
        {
            throw new NotImplementedException();
        }

        public void RelativeAbundance()
        {
            throw new NotImplementedException();
        }

        public IVolume TimberVolume()
        {
            throw new NotImplementedException();
        }

        public IWeight TimberWeight()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
