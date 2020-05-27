using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Innergy_Exercise.Business.Models
{
    public class WarehouseDataProcessingContext
    {
        private List<WarehouseMaterialAvailability> _warehousesMaterialAvailability;

        public WarehouseDataProcessingContext(TextReader inputData)
        {
            InputData = inputData;
            _warehousesMaterialAvailability = new List<WarehouseMaterialAvailability>();
            WarehouseData = new WarehouseData();
        }

        public TextReader InputData { get; }
        public WarehouseData WarehouseData { get; set; }

        public List<WarehouseMaterialAvailability> WarehousesMaterialAvailability
        {
            get
            {
                return _warehousesMaterialAvailability
                    .OrderByDescending(x => x.TotalMaterials)
                    .ThenByDescending(x => x.WarehouseName)
                    .ToList();
            }
            set => _warehousesMaterialAvailability = value;
        }

        public string OutputData { get; set; }
    }
}
