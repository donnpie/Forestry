using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    /// <summary>
    /// Repressents a stand in a woodlot.
    /// A stand is a section of land where the properties of the trees and land are roughly homogenous
    /// /// </summary>
    public interface IStand : IPhysicalObject
    {
        /// <summary>
        /// The surface area of the stand
        /// </summary>
        IArea SurfaceArea { get; }

        /// <summary>
        /// A list of inventories for the site, irrespective of which campaign they belong to
        /// </summary>
        List<IInventory> InventoryList { get; }

        /// <summary>
        /// A list of trees for the site
        /// </summary>
        List<ITree> TreeList { get; }

        ISoilQuality SoilQuality { get; }

        ISoilType SoilType { get; }

        ITerrainSlope TerrainSlope { get; }

        ITerrainType TerrainType { get; }
    }
}
