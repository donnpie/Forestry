using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    class Tree : ITree
    {
        public IGenus Genus => throw new NotImplementedException();

        public ISpecies Species => throw new NotImplementedException();

        public IGeography Location => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string Comments => throw new NotImplementedException();
    }
}
