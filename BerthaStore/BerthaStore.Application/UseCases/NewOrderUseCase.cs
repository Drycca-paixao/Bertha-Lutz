using System;
using System.Threading.Tasks;
using AutoMapper;
using BerthaStore.Application.Models.NewOrder;
using BerthaStore.Core.Interfaces;
using BerthaStore.Core.Entities;

namespace BerthaStore.Application.UseCases
{
    public class NewOrderUseCase : IUseCaseAsync<NewOrderRequest, NewOrderResponse>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public NewOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<NewOrderResponse> ExecuteAsync(NewOrderRequest request)
        {
            if (request == null)
                throw new Exception("NewOrderRequest está nulo.");

            var order = _mapper.Map<Order>(request);

            await _repository.Inserir(order);

            return new NewOrderResponse() { };
        }
    }
}
