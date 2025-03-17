using EC.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using EC.Order.Application.Features.CQRS.Queries.AddressQueries;
using EC.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using EC.Order.Application.Features.CQRS.Results.AddressResults;
using EC.Order.Application.Features.CQRS.Results.OrderDetailResults;
using EC.Order.Application.Interfaces;
using EC.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery getOrderDetailByIdQuery)
        {
            var values = await _repository.GetByIdAsync(getOrderDetailByIdQuery.Id);
            return new GetOrderDetailByIdQueryResult
            {
                ProductAmount = values.ProductAmount,
                ProductName = values.ProductName,
                ProductId = values.ProductId,
                ProductPrice = values.ProductPrice,
                ProductTotalPrice = values.ProductTotalPrice,
                OrderingId = values.OrderingId,
                OrderDetailId = values.OrderDetailId
            };
        }
    }
}