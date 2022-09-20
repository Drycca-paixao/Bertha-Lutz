using AutoMapper;
using BerthaStore.Application.Models.SearchOrder;
using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaLutzStore.Application.Models.UpdateOrder
{
<<<<<<< HEAD:BerthaLutzStore/BerthaLutzStore.Application/Models/UpdateOrder/UpdateOrderResponse.cs
    public class UpdateOrderResponse
=======
    public class SearchOrderUseCase : IUseCaseAsync<SearchOrderRequest, IActionResult>
>>>>>>> 357bb46f12a5065ba623c2b9694101ae9c875903:BerthaStore/BerthaStore.Application/UseCases/SearchOrderUseCase.cs
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
