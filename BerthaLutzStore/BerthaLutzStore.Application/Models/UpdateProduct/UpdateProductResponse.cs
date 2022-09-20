using AutoMapper;
using BerthaStore.Application.Models.UpdateOrder;
using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaLutzStore.Application.Models.UpdateProduct
{
<<<<<<< HEAD:BerthaLutzStore/BerthaLutzStore.Application/Models/UpdateProduct/UpdateProductResponse.cs
    public class UpdateProductResponse
=======
    public class UpdateOrderUseCase : IUseCaseAsync<UpdateOrderRequest, IActionResult>
>>>>>>> 357bb46f12a5065ba623c2b9694101ae9c875903:BerthaStore/BerthaStore.Application/UseCases/UpdateOrderUseCase.cs
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public UpdateOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(UpdateOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var order = _mapper.Map<Order>(request);

            await _repository.New(order);

            return new OkResult();
        }
    }
}
