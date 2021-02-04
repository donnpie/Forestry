using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface ISpecies : IAbtractObject
    {
        String CommonName { get; }
    }
}
