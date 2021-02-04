using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface ISample : IAbtractObject
    {
        List<ITree> TreeList { get; }


        IGeography CenterLocation { get; }

        ILength SampleRadius { get; }

        int TreeCount();

        IArea BasalArea();

    }
}
