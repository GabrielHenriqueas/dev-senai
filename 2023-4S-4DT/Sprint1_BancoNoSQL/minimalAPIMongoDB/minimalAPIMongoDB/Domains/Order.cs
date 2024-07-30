using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minimalAPIMongoDB.Domains
{
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        //referência aos produtos do pedido
        [BsonElement("productId")]
        public List<string>? ProductId { get; set; }
        public List<Product>? Products { get; set; }

        //referência ao clienteque está fazendo o pedido
        [BsonElement("clientId")]
        public string? ClientId { get; set; }
        public Client? Client { get; set; }


        public Dictionary<string, string> AdditionalAttributes { get; set; }

        public Order() 
        {
            AdditionalAttributes = new Dictionary<string, string>();
        }
    }
}
