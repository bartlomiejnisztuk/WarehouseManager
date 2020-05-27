using Innergy_Exercise.Business.Models;
using Innergy_Exercise.Business.Processors;

namespace Innergy_Exercise.Business.Handlers
{
    public class WarehouseEngineHandler : IWarehouseHandler<WarehouseDataProcessingContext>
    {
        public WarehouseEngineProcessor WarehouseEngineProcessor { get; } = new WarehouseEngineProcessor();

        public void Handle(WarehouseDataProcessingContext context)
        {
            WarehouseEngineProcessor.Run(context);
        }
    }
}
