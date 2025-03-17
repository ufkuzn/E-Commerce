using EC.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using EC.Order.Application.Interfaces;
using EC.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderDetailCommand createOrderDetailCommand)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                ProductAmount = createOrderDetailCommand.ProductAmount,
                ProductName = createOrderDetailCommand.ProductName,
                ProductId = createOrderDetailCommand.ProductId,
                ProductPrice = createOrderDetailCommand.ProductPrice,
                ProductTotalPrice = createOrderDetailCommand.ProductTotalPrice,
                OrderingId = createOrderDetailCommand.OrderingId
            });
        }
    }
}