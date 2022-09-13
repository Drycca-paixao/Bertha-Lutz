using AutoMapper;
using BerthaStore.Application.Models.UpdateProduct;
using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.Application.UseCases
{
    public class UpdateProductUseCase : IUseCaseAsync<UpdateProductRequest, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(UpdateProductRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var product = _mapper.Map<Product>(request);

            await _repository.Add(product);

            return new OkResult();
        }
    }
}
