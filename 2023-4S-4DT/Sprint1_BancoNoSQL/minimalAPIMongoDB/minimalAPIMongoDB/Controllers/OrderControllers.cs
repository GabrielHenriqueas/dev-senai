using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minimalAPIMongoDB.Domains;
using minimalAPIMongoDB.Services;
using minimalAPIMongoDB.ViewModels;
using MongoDB.Driver;

namespace minimalAPIMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class OrderControllers : ControllerBase
    {
        private readonly IMongoCollection<Order> _order;
        private readonly IMongoCollection<Client> _client;
        private readonly IMongoCollection<Product> _product;

        public OrderControllers(MongoDbService mongoDbService)
        {
            _order = mongoDbService.GetDatabase?.GetCollection<Order>("order");
            _client = mongoDbService.GetDatabase?.GetCollection<Client>("client");
            _product = mongoDbService.GetDatabase?.GetCollection<Product>("product");
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(OrderViewModel orderViewModel)
        {
            try
            {
                Order order = new Order();

                order.Id = orderViewModel.Id;
                order.Date = orderViewModel.Date;
                order.Status = orderViewModel.Status;
                order.ProductId = orderViewModel.ProductId;
                order.ClientId = orderViewModel.ClientId;

                var client = await _client.Find(x => x.Id == order.ClientId).FirstOrDefaultAsync();

                if (client == null)
                {
                    return NotFound("Cliente não existe!");
                }

                order.Client = client;

                await _order.InsertOneAsync(order);

                return StatusCode(201, order);
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        //public OrderControllers(MongoDbService mongoDbService)
        //{
        //    _order = mongoDbService.GetDatabase.GetCollection<Order>("order");
        //}

        //[HttpGet]
        //public async Task<ActionResult<List<Order>>> Get()
        //{
        //    try
        //    {
        //        var orders = await _order.Find(FilterDefinition<Order>.Empty).ToListAsync();
        //        return Ok(orders);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}

        //[HttpPost]
        //public async Task<ActionResult> Post(Order order)
        //{
        //    try
        //    {
        //        await _order.InsertOneAsync(order);
        //        return StatusCode(201, order);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Order>> GetById(string id)
        //{
        //    try
        //    {
        //        var order = await _order.Find(x => x.Id == id).FirstOrDefaultAsync();
        //        //return Ok(order);

        //        //Outra forma
        //        //var filter = Builders<Order>.Filter.Eq(x => x.Id, id
        //        //return Ok(filter);

        //        return order is not null ? Ok(order) : NotFound();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}

        //[HttpPut]

        //public async Task<ActionResult> Update(Order o)
        //{
        //    try
        //    {
        //        //buscar por id (filtro)
        //        var filter = Builders<Order>.Filter.Eq(x => x.Id, o.Id);

        //        if (filter != null)
        //        {

        //            //susbistituindo o objeto buscado pelo novo objeto
        //            await _order.ReplaceOneAsync(filter, o);

        //            return Ok();
        //        }

        //        return NotFound();


        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(string id)
        //{
        //    try
        //    {
        //        var filter = Builders<Order>.Filter.Eq(o => o.Id, id);

        //        if (filter != null)
        //        {
        //            await _order.DeleteOneAsync(filter);

        //            return Ok();
        //        }

        //        return NotFound();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}
    }
}
