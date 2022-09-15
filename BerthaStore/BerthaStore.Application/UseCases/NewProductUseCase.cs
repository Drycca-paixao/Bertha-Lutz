using System.Threading.Tasks;
using AutoMapper;
using BerthaStore.Application.Models.NewProduct;
using BerthaStore.Core.Interfaces;
using BerthaStore.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

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
            var validator = new NewProductRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage + " | ";

                throw new Exception(validatorErrors);
            }

            if (request == null)
                return new BadRequestResult();

            var product = _mapper.Map<Product>(request);

            await _repository.New(product);

            return new OkResult();
        }
    }
}
