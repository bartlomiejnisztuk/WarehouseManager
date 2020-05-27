using System;
using System.Collections.Generic;
using Innergy_Exercise.Business.Models;
using Innergy_Exercise.Properties;

namespace Innergy_Exercise.Business.Processors
{
    public class InputReaderProcessor
    {
        public void Run(WarehouseDataProcessingContext context)
        {
            var line = string.Empty;
            
            while (line != null)
            {
                try
                {
                    line = context.InputData.ReadLine();
                    if (string.IsNullOrEmpty(line) || line.StartsWith("#"))
                    {
                        continue;
                    }

                    var parts = line.Split(';');
                    var materialName = parts[0].Trim();
                    var materialId = parts[1].Trim();
                    var storageInformation = parts[2].Trim().Split('|');


                    var warehouses = new List<Warehouse>();

                    foreach (var warehouseInfo in storageInformation)
                    {
                        var singleWarehouse = warehouseInfo.Split(',');
                        var warehouseName = singleWarehouse[0].Trim();
                        var quantity = int.Parse(singleWarehouse[1].Trim());

                        warehouses.Add(new Warehouse
                        {
                            WarehouseName = warehouseName,
                            MaterialQuantity = quantity
                        });
                    }

                    context.WarehouseData.Materials.Add(new MaterialInfo
                    {
                        MaterialId = materialId,
                        MaterialName = materialName,
                        WarehouseInformation = warehouses
                    });
                }
                catch(Exception e)
                {
                    Console.WriteLine(Resources.InputReaderProcessor_Run_Invalid_line_detected_);
                    continue;
                }
            }
        }
    }
}
