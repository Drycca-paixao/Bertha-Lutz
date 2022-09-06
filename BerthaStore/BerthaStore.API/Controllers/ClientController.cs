using BerthaStore.Application.Models.AddClient;
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
        private readonly IUseCaseAsync<AddClientRequest, AddClientResponse> _addClientCaseAsync;
        private readonly IUseCaseAsync<UpdateClientRequest, UpdateClientResponse> _updateClientCaseAsync;
        private readonly IUseCaseAsync<SearchClientRequest, SearchClientResponse> _searchClientCaseAsync;

        public ClientController(IUseCaseAsync<AddClientRequest, AddClientResponse> addClientCaseAsync,
        IUseCaseAsync<UpdateClientRequest, UpdateClientResponse> updateClientCaseAsync,
        IUseCaseAsync<SearchClientRequest, SearchClientResponse> searchClientCaseAsync)
        {
            _addClientCaseAsync = addClientCaseAsync;
            _updateClientCaseAsync = updateClientCaseAsync;
            _searchClientCaseAsync = searchClientCaseAsync;
        }

        //Inserir()
        [HttpPost]
        public async Task<ActionResult<AddClientResponse>> Post([FromBody] AddClientRequest request)
        {
            return await _addClientCaseAsync.ExecuteAsync(request);
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
            return await _searchClientCaseAsync.ExecuteAsync(new SearchClientRequest() {Id = id});
        }
    }
}
