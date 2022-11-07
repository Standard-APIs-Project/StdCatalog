//using Application.Items.Commands.CreateNewItemCommand.Factory;
using Microsoft.AspNetCore.Mvc;
using StdCatalog.Application;
using StdCatalog.Application.Items.Commands.CreateNewItemCommand;
using StdCatalog.Persistence.Repositories;
using StdCatalog.Domain.Entities;
using Application.Items.Queries.GetItemQuery;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StdCatalog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ICreateNewItemCommand _createNewItemCommand;
        private readonly IGetItemQuery _getItemQuery;
        
        public ItemController(ICreateNewItemCommand createNewItemCommand, IGetItemQuery getItemQuery)
        {
            
            _createNewItemCommand = createNewItemCommand;
            _getItemQuery = getItemQuery;
        }

        // GET: api/<Item>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Item>/5
        [HttpGet("{id}")]
        public Item Get(Guid id)
        {
            return _getItemQuery.Execute(id);
        }

        // POST api/<Item>
        [HttpPost]
        public void Post([FromBody] CreateNewItemModel itemModel)
        {

            _createNewItemCommand.Execute(itemModel);

        }

        // PUT api/<Item>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Item>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
