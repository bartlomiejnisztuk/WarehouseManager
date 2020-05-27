using System.Linq;
using System.Text;
using Innergy_Exercise.Business.Models;

namespace Innergy_Exercise.Business.Processors
{
    public class OutputGenerationProcessor
    {
        public void Run(WarehouseDataProcessingContext context)
        {
            var result = new StringBuilder();

            context.WarehousesMaterialAvailability.ForEach(x =>
            {
                result.AppendLine($"{x.WarehouseName} (total {x.TotalMaterials}) ");
                x.Materials.ToList().ForEach(material =>
                {
                    result.AppendLine($"{material.MaterialId}: {material.MaterialQuantity}");
                });
                result.AppendLine();
            });

            context.OutputData = result.ToString();
        }
    }
}
