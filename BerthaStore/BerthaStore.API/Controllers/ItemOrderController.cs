using BerthaStore.Application.Models.AddItemOrder;
using BerthaStore.Application.Models.RemoveItemOrder;
using BerthaStore.Application.Models.UpdateItemOrder;
using BerthaStore.Application.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class ItemOrderController : ControllerBase
   {
            private readonly IUseCaseAsync<AddItemOrderRequest, AddItemOrderResponse> _addItemOrderCaseAsync;
            private readonly IUseCaseAsync<UpdateItemOrderRequest, UpdateItemOrderResponse> _updateItemOrderCaseAsync;
            private readonly IUseCaseAsync<RemoveItemOrderRequest, RemoveItemOrderResponse> _deleteItemOrderCaseAsync;
        

        public ItemOrderController(IUseCaseAsync<AddItemOrderRequest, AddItemOrderResponse> addItemOrderCaseAsync,
            IUseCaseAsync<UpdateItemOrderRequest, UpdateItemOrderResponse> updateItemOrderCaseAsync,
            IUseCaseAsync<RemoveItemOrderRequest, RemoveItemOrderResponse> deleteItemOrderCaseAsync)
        {
            _addItemOrderCaseAsync = addItemOrderCaseAsync;
            _updateItemOrderCaseAsync = updateItemOrderCaseAsync;
            _deleteItemOrderCaseAsync = deleteItemOrderCaseAsync;
        }

        //Adicionar()
        [HttpPost]
        public async Task<ActionResult<AddItemOrderResponse>> Post([FromBody] AddItemOrderRequest request)
        {
            return await _addItemOrderCaseAsync.ExecuteAsync(request);
        }

        //Atualizar()
        [HttpPut]
        public async Task<ActionResult<UpdateItemOrderResponse>> Put([FromBody] UpdateItemOrderRequest request)
        {
            return await _updateItemOrderCaseAsync.ExecuteAsync(request);
        }

        //Deletar()
        [HttpDelete]
        public async Task<ActionResult<RemoveItemOrderResponse>> Delete([FromRoute] int id)
        {
            return await _deleteItemOrderCaseAsync.ExecuteAsync(new RemoveItemOrderRequest() { Id = id });
        }

    }
}

