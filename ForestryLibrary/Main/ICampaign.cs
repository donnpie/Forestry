using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface ICampaign : IAbtractObject
    {
        //A list of all the inventories belonging to this campaign
        List<IInventory> InventoryList { get; }

        /// <summary>
        /// Counts the number of inventories in the campaign
        /// </summary>
        /// <returns></returns>
        int InventoryCount();


        void RelativeAbundance();


        IArea BasalArea();


        IVolume TimberVolume();

        IWeight TimberWeight();


    }
}
