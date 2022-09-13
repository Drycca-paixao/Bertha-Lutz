using System;
using System.Threading.Tasks;
using AutoMapper;
using BerthaStore.Application.Models.NewProduct;
using BerthaStore.Core.Interfaces;
using BerthaStore.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BerthaStore.Application.UseCases
{
    public class NewProductUseCase : IUseCaseAsync<NewProductRequest, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public NewProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(NewProductRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var product = _mapper.Map<Product>(request);

            await _repository.Inserir(product);

            return new OkResult();
        }
    }
}
