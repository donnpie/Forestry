using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public interface IAddress
    {
        public int UnitNumber { get; set; }


        public string UnitName { get; set; }


        public int StreetNumber { get; set; }


        public string StreetName { get; set; }

        public string SuburbName { get; set; }

        public IProvince Province { get; set; }

    }
}
