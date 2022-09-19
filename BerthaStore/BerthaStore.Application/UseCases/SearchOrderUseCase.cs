using AutoMapper;
using BerthaStore.Application.Models.SearchOrder;
using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.Application.UseCases
{
    public class SearchOrderUseCase : IUseCaseAsync<SearchOrderRequest, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public SearchOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(SearchOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var order = _mapper.Map<Order>(request);

            await _repository.New(order);

            return new OkResult();
        }
    }
}
