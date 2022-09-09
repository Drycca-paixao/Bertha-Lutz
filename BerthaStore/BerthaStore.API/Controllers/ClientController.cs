using BerthaStore.Application.Models.NewClient;
using BerthaStore.Application.Models.SearchClient;
using BerthaStore.Application.Models.UpdateClient;
using BerthaStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BerthaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUseCaseAsync<NewClientRequest, NewClientResponse> _newClientCaseAsync;
        private readonly IUseCaseAsync<UpdateClientRequest, UpdateClientResponse> _updateClientCaseAsync;
        private readonly IUseCaseAsync<SearchClientRequest, SearchClientResponse> _searchClientCaseAsync;

        public ClientController(IUseCaseAsync<NewClientRequest, NewClientResponse> newClientCaseAsync,
        IUseCaseAsync<UpdateClientRequest, UpdateClientResponse> updateClientCaseAsync,
        IUseCaseAsync<SearchClientRequest, SearchClientResponse> searchClientCaseAsync)
        {
            _newClientCaseAsync = newClientCaseAsync;
            _updateClientCaseAsync = updateClientCaseAsync;
            _searchClientCaseAsync = searchClientCaseAsync;
        }

        //Inserir()
        [HttpPost]
        public async Task<ActionResult<NewClientResponse>> Post([FromBody] NewClientRequest request)
        {
            return await _newClientCaseAsync.ExecuteAsync(request);
        }

        //Atualizar()
        [HttpPut]
        public async Task<ActionResult<UpdateClientResponse>> Put([FromBody] UpdateClientRequest request)
        {
            return await _updateClientCaseAsync.ExecuteAsync(request);
        }

        //Buscar()
        [HttpGet]
        public async Task<ActionResult<SearchClientResponse>> Get([FromQuery] int id)
        {
            return await _searchClientCaseAsync.ExecuteAsync(new SearchClientRequest() {IdClient = id});
        }
    }
}
