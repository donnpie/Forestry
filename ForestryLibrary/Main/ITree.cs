using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface ITree : IPhysicalObject
    {
        IGenus Genus { get; }

        ISpecies Species { get; }

        
      
    }
}
