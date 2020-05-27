using System;
using System.Collections.Generic;
using System.Text;

namespace Innergy_Exercise.Business.Models
{
    public class WarehouseData
    {
        public IList<MaterialInfo> Materials { get; }
        public WarehouseData()
        {
            Materials = new List<MaterialInfo>();
        }
    }

    public class MaterialInfo
    {

        public MaterialInfo()
        {
            WarehouseInformation = new List<Warehouse>();
        }

        public string MaterialName { get; set; }
        public string MaterialId { get; set; }
        public IEnumerable<Warehouse> WarehouseInformation { get; set; }
    }

    public class Warehouse
    {
        public string WarehouseName { get; set; }
        public int MaterialQuantity { get; set; }
    }
}
