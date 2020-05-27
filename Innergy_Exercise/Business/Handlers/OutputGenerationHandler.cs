using Innergy_Exercise.Business.Models;
using Innergy_Exercise.Business.Processors;

namespace Innergy_Exercise.Business.Handlers
{
    public class OutputGenerationHandler : IWarehouseHandler<WarehouseDataProcessingContext>
    {
        private OutputGenerationProcessor OutputGenerationProcessor { get; } = new OutputGenerationProcessor();

        public void Handle(WarehouseDataProcessingContext context)
        {
            OutputGenerationProcessor.Run(context);
        }
    }
}
