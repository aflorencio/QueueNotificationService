using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNotificationService
{
    [BsonIgnoreExtraElements]
    class MQueueNotification
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public DateTime fecha { get; set; }
        [BsonIgnoreIfNull]
        public bool leido { get; set; }
        [BsonIgnoreIfNull]
        public int prioridad { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId from { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId to { get; set; }
        [BsonIgnoreIfNull]
        public string mensaje { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId serviceID { get; set; }
        [BsonIgnoreIfNull]
        public string tipoServicio { get; set; }
        [BsonIgnoreIfNull]
        public int toType { get; set; } //0 sera un contacto (mensaje para un contacto) 1 es para un trabajador.

    }
}
