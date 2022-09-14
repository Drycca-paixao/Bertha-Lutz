using AutoMapper;
using BerthaStore.Application.Models.SearchProduct;
using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.Application.UseCases
{
    public class SearchProductUseCase : IUseCaseAsync<SearchProductRequest, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public SearchProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(SearchProductRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var product = _mapper.Map<Product>(request);

            await _repository.New(product);

            return new OkResult();
        }
    }
}
