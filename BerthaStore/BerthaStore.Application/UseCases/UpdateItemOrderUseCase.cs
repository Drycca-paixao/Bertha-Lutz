using System.Threading.Tasks;
using AutoMapper;
using BerthaStore.Core.Interfaces;
using BerthaStore.Core.Entities;
using BerthaStore.Application.Models.UpdateOrder;
using Microsoft.AspNetCore.Mvc;

namespace BerthaStore.Application.UseCases
{
    public class UpdateItemOrderUseCase : IUseCaseAsync<UpdateItemOrderRequest, IActionResult>
    {
        private readonly IItemOrderRepository _repository;
        private readonly IMapper _mapper;

        public UpdateItemOrderUseCase(IItemOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(UpdateItemOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var itemOrder = _mapper.Map<ItemOrder>(request);

            await _repository.New(itemOrder);

            return new OkResult();
        }
    }
}
