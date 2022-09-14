using System.Threading.Tasks;
using AutoMapper;
using BerthaStore.Core.Interfaces;
using BerthaStore.Core.Entities;
using BerthaStore.Application.Models.NewOrder;
using Microsoft.AspNetCore.Mvc;

namespace BerthaStore.Application.UseCases
{
    public class AddItemOrderUseCase : IUseCaseAsync<AddItemOrderRequest, IActionResult>
    {
        private readonly IItemOrderRepository _repository;
        private readonly IMapper _mapper;

        public AddItemOrderUseCase(IItemOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(AddItemOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var itemOrder = _mapper.Map<ItemOrder>(request);

            await _repository.New(itemOrder);

            return new OkResult();
        }
    }
}
