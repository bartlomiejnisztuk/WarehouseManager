using System;
using System.Collections.Generic;
using Innergy_Exercise.Business.Models;

namespace Innergy_Exercise.Business.Handlers
{
    public class WarehouseHandler
    {
        private readonly IList<IWarehouseHandler<WarehouseDataProcessingContext>>  _handlers;

        public WarehouseHandler(params IWarehouseHandler<WarehouseDataProcessingContext>[] handlers)
        {
            _handlers = handlers;
        }

        public void Handle(WarehouseDataProcessingContext context)
        {
            try
            {
                foreach (var warehouseHandler in _handlers)
                {
                    warehouseHandler.Handle(context);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
