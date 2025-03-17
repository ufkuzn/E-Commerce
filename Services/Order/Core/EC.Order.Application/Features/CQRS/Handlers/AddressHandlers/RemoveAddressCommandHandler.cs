using EC.Order.Application.Features.CQRS.Commands.AddressCommands;
using EC.Order.Application.Interfaces;
using EC.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommand removeAddressCommand)
        {
            var value = await _repository.GetByIdAsync(removeAddressCommand.Id);
            await _repository.DeleteAsync(value);
        }
    }
}