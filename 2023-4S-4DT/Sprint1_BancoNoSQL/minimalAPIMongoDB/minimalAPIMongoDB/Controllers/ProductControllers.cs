using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minimalAPIMongoDB.Domains;
using minimalAPIMongoDB.Services;
using MongoDB.Driver;

namespace minimalAPIMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductControllers : ControllerBase
    {
        private readonly IMongoCollection<Product> _product;

        public ProductControllers(MongoDbService mongoDbService)
        {
            _product = mongoDbService.GetDatabase.GetCollection<Product>("product");
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _product.Find(FilterDefinition<Product>.Empty).ToListAsync();
                return Ok(products);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(Product product)
        {
            try
            {
                await _product.InsertOneAsync(product);
                return StatusCode(201, product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById (string id)
        {
            try
            {
                var product = await _product.Find(x => x.Id == id).FirstOrDefaultAsync();
                //return Ok(product);

                //Outra forma
                //var filter = Builders<Product>.Filter.Eq(x => x.Id, id
                //return Ok(filter);

                return product is not null ? Ok(product) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]

        public async Task<ActionResult>Update(Product p)
        {
            try
            {
                //buscar por id (filtro)
                var filter = Builders<Product>.Filter.Eq(x => x.Id, p.Id);

                if (filter != null)
                {

                    //susbistituindo o objeto buscado pelo novo objeto
                    await _product.ReplaceOneAsync(filter, p);

                    return Ok();
                }

                return NotFound();


            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var filter = Builders<Product>.Filter.Eq(p => p.Id, id);

                if (filter != null)
                {
                    await _product.DeleteOneAsync(filter);

                    return Ok();
                }

                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

//Criar a classe User na pasta Domains
//Id, name, email, password e atributos adicionais

//Criar a classe Client na pasta Domains
//Id, UserId, Cpf, Phone, Address, atributos adicionais

//Criar a classe Order na pasta Domains
//Id, Date, Status
//referência aos produtos do pedido
//referência ao cliente que fez o pedido

//Criar os controllers 

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using minimalAPIMongoDB.Domains;
//using minimalAPIMongoDB.Services;
//using MongoDB.Driver;

//namespace minimalAPIMongoDB.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [Produces("application/json")]
//    public class ProductControllers : ControllerBase
//    {
//        private readonly IMongoCollection<Product> _product;

//        public ProductControllers(MongoDbService mongoDbService)
//        {
//            _product = mongoDbService.GetDatabase.GetCollection<Product>("product");
//        }

//        [HttpGet]
//        public async Task<ActionResult<List<Product>>> Get()
//        {
//            try
//            {
//                var products = await _product.Find(FilterDefinition<Product>.Empty).ToListAsync();
//                return Ok(products);
//            }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);
//            }
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<Product>> GetById(string id)
//        {
//            try
//            {
//                var filter = Builders<Product>.Filter.Eq(p => p.Id, id);
//                var product = await _product.Find(filter).FirstOrDefaultAsync();

//                if (product == null)
//                {
//                    return NotFound();
//                }

//                return Ok(product);
//            }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);
//            }
//        }

//        [HttpPost]
//        public async Task<ActionResult<Product>> Post([FromBody] Product newProduct)
//        {
//            try
//            {
//                await _product.InsertOneAsync(newProduct);
//                return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
//            }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);
//            }
//        }

//        [HttpPut("{id}")]
//        public async Task<ActionResult> Update(string id, [FromBody] Product updatedProduct)
//        {
//            try
//            {
//                var filter = Builders<Product>.Filter.Eq(p => p.Id, id);
//                var result = await _product.ReplaceOneAsync(filter, updatedProduct);

//                if (result.ModifiedCount == 0)
//                {
//                    return NotFound();
//                }

//                return NoContent();
//            }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);
//            }
//        }

//        [HttpDelete("{id}")]
//        public async Task<ActionResult> Delete(string id)
//        {
//            try
//            {
//                var filter = Builders<Product>.Filter.Eq(p => p.Id, id);
//                var result = await _product.DeleteOneAsync(filter);

//                if (result.DeletedCount == 0)
//                {
//                    return NotFound();
//                }

//                return NoContent();
//            }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);
//            }
//        }
//    }
//}