using BerthaStore.Application.Models.NewOrder;
using BerthaStore.Application.Models.SearchOrder;
using BerthaStore.Application.Models.UpdateOrder;
using BerthaStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IUseCaseAsync<NewOrderRequest, IActionResult> _newOrderCaseAsync;
        private readonly IUseCaseAsync<UpdateOrderRequest, IActionResult> _updateOrderCaseAsync;
        private readonly IUseCaseAsync<SearchOrderRequest, IActionResult> _searchOrderCaseAsync;

        public OrderController(IUseCaseAsync<NewOrderRequest, IActionResult> newOrderCaseAsync,
        IUseCaseAsync<UpdateOrderRequest, IActionResult> updateOrderCaseAsync,
        IUseCaseAsync<SearchOrderRequest, IActionResult> searchOrderCaseAsync)
        {
            _newOrderCaseAsync = newOrderCaseAsync;
            _updateOrderCaseAsync = updateOrderCaseAsync;
            _searchOrderCaseAsync = searchOrderCaseAsync;
        }

        //Inserir()
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewOrderRequest request)
        {
            return await _newOrderCaseAsync.ExecuteAsync(request);
        }

        //Atualizar()
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateOrderRequest request)
        {
            return await _updateOrderCaseAsync.ExecuteAsync(request);
        }

        //Buscar()
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return await _searchOrderCaseAsync.ExecuteAsync(new SearchOrderRequest() { IdOrder = id });
        }
    }
}



