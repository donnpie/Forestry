using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Helper
{
    public interface IProvince
    {
        public int ProvinceID { get; set; }

        public int CountryID { get; set; }

        public string ProvinceName { get; set; }

    }
}
