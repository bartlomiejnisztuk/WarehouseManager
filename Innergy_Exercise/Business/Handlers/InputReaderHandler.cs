using Innergy_Exercise.Business.Models;
using Innergy_Exercise.Business.Processors;

namespace Innergy_Exercise.Business.Handlers
{
    public class InputReaderHandler : IWarehouseHandler<WarehouseDataProcessingContext>
    {
        private InputReaderProcessor InputReaderProcessor { get; } = new InputReaderProcessor();

        public void Handle(WarehouseDataProcessingContext context)
        {
            InputReaderProcessor.Run(context);
        }
    }
}
