using BerthaStore.Application.Models.NewProduct;
using BerthaStore.Application.Models.SearchProduct;
using BerthaStore.Application.Models.UpdateProduct;
using BerthaStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUseCaseAsync<NewProductRequest, NewProductResponse> _newProductCaseAsync;
        private readonly IUseCaseAsync<UpdateProductRequest, UpdateProductResponse> _updateProductCaseAsync;
        private readonly IUseCaseAsync<SearchProductRequest, SearchProductResponse> _searchProductCaseAsync;

        public ProductController(
        IUseCaseAsync<NewProductRequest, NewProductResponse> newProductCaseAsync,
        IUseCaseAsync<UpdateProductRequest, UpdateProductResponse> updateProductCaseAsync,
        IUseCaseAsync<SearchProductRequest, SearchProductResponse> searchProductCaseAsync)
        {
            _newProductCaseAsync = newProductCaseAsync;
            _updateProductCaseAsync = updateProductCaseAsync;
            _searchProductCaseAsync = searchProductCaseAsync;
        }

        //Inserir()
        [HttpPost]
        public async Task<ActionResult<NewProductResponse>> Post([FromBody] NewProductRequest request)
        {
            return await _newProductCaseAsync.ExecuteAsync(request);
        }

        //Atualizar()
        [HttpPut]
        public async Task<ActionResult<UpdateProductResponse>> Put([FromBody] UpdateProductRequest request)
        {
            return await _updateProductCaseAsync.ExecuteAsync(request);
        }

        //Buscar()
        [HttpGet]
        public async Task<ActionResult<SearchProductResponse>> Get([FromQuery] int id)
        {
            return await _searchProductCaseAsync.ExecuteAsync(new SearchProductRequest() {IdProduct = id});
        }
    }
}
