using System.Threading.Tasks;
using AutoMapper;
using BerthaStore.Application.Models.NewOrder;
using BerthaStore.Core.Interfaces;
using BerthaStore.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BerthaStore.Application.UseCases
{
    public class NewOrderUseCase : IUseCaseAsync<NewOrderRequest, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public NewOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(NewOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var order = _mapper.Map<Order>(request);

            await _repository.Add(order);

            return new OkResult();
        }
    }
}
