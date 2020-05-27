using System;
using System.IO;
using Innergy_Exercise.Business.Handlers;
using Innergy_Exercise.Business.Models;
using Innergy_Exercise.Properties;

namespace Innergy_Exercise
{
    public class Program
    {
        private static WarehouseDataProcessingContext _context;
        private static WarehouseHandler _warehouseHandler;

        static void Main(string[] args)
        {
            //testability, //
            //todo test different scenarios, write some unit tests - case for each processor
            SetupWarehouseChainOfResponsibilities();

            _warehouseHandler.Handle(_context);

            Console.WriteLine(_context.OutputData);

            Console.ReadKey();
        }

        private static void SetupWarehouseChainOfResponsibilities()
        {
            var input = Resources.Data;

            _context = new WarehouseDataProcessingContext(new StringReader(input));
            _warehouseHandler = new WarehouseHandler(
                new InputReaderHandler(),
                new WarehouseEngineHandler(),
                new OutputGenerationHandler());

        }
    }
}
