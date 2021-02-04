using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    class Stand : IStand
    {
        #region Properties
        public IArea SurfaceArea => throw new NotImplementedException();

        public List<IInventory> InventoryList => throw new NotImplementedException();

        public List<ITree> TreeList => throw new NotImplementedException();

        public ISoilQuality SoilQuality => throw new NotImplementedException();

        public ISoilType SoilType => throw new NotImplementedException();

        public ITerrainSlope TerrainSlope => throw new NotImplementedException();

        public ITerrainType TerrainType => throw new NotImplementedException();

        public IGeography Location => throw new NotImplementedException();

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description => throw new NotImplementedException();

        public string Comments => throw new NotImplementedException();

        #endregion

        #region Constructors





        #endregion
    }
}
