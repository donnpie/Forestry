using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    public class Woodlot : IWoodlot
    {
        #region Properties
        public IAddress Address => throw new NotImplementedException();

        public List<IStand> StandList { get; private set; }

        public List<ICampaign> CampaignList { get; private set; }

        public IGeography Location => throw new NotImplementedException();

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; private set; }

        public string Comments { get; private set; }

        public int CampaignCount()
        {
            throw new NotImplementedException();
        }

        public int StandCount()
        {
            throw new NotImplementedException();
        }

        public IArea SurfaceArea()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Constructors
        public Woodlot()
        {
            StandList = new List<IStand>(); //Needs to call factory
            CampaignList = new List<ICampaign>(); //Needs to call factory
            Id = 0;
            Name = "";
        }

        public Woodlot(int id, string name)
        {
            StandList = new List<IStand>(); //Needs to call factory
            CampaignList = new List<ICampaign>(); //Needs to call factory
            Id = id;
            Name = name;
        }


        #endregion
    }
}
