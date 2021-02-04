using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public interface IWoodlot : IPhysicalObject
    {
        /// <summary>
        /// The address of the overall property, not of a particular stand
        /// </summary>
        public IAddress Address { get; }

        /// <summary>
        /// Contains a list of the stands in a woodlot
        /// </summary>
        public List<IStand> StandList { get; }

        /// <summary>
        /// Contains a list of the campaigns in a woodlot
        /// </summary>
        public List<ICampaign> CampaignList { get; }

        /// <summary>
        /// Counts the number of stands in the woodlot
        /// </summary>
        /// <returns></returns>
        int StandCount();

        /// <summary>
        /// Counts the number of campaings of the woodlot
        /// </summary>
        /// <returns></returns>
        int CampaignCount();

        /// <summary>
        /// The total surface area of all the stands in the woodlot
        /// </summary>
        /// <returns></returns>
        IArea SurfaceArea();

    }
}
