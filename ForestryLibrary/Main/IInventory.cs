using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface IInventory : IAbtractObject
    {
        List<ISample> SampleList { get; }

        int SampleCount();

        IArea BasalArea();

        //StockingRate StockingRate(); TODO: define enum for StockingRate
    }
}
