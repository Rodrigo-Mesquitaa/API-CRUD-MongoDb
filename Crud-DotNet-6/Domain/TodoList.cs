using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Crud_DotNet_6.Domain
{
    public class TodoList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
    }
}
