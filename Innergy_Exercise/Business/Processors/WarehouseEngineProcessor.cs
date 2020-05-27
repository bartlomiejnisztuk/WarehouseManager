using System.Collections.Generic;
using System.Linq;
using Innergy_Exercise.Business.Models;

namespace Innergy_Exercise.Business.Processors
{
    public class WarehouseEngineProcessor
    {
        public void Run(WarehouseDataProcessingContext context)
        {

            var result = context
                .WarehouseData
                .Materials
                .Select(x => x.WarehouseInformation
                    .Select(warehouse => (warehouse.WarehouseName, x.MaterialId, Quantity: warehouse.MaterialQuantity)))
                .SelectMany(x => x)
                .GroupBy(x => x.WarehouseName, (warehouseName, materials) => new
                {
                    Key = warehouseName,
                    Material = materials,
                })
                .Select(r => new WarehouseMaterialAvailability()
                {
                    WarehouseName = r.Key, Materials = r.Material
                        .Select(m => new MaterialAvailability
                        {
                            MaterialId = m.MaterialId,
                            MaterialQuantity = m.Quantity
                        }).ToList()
                }).ToList();

            context.WarehousesMaterialAvailability = result;
        }
    }
}
