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
        public string _id { get; set; }
        public DateTime fecha { get; set; }
        public bool leido { get; set; }
        public int prioridad { get; set; }
        public ObjectId from { get; set; }
        public ObjectId to { get; set; }
        public string mensaje { get; set; }
        public ObjectId serviceID { get; set; }
        public string tipoServicio { get; set; }
        public int toType { get; set; } //0 sera un contacto (mensaje para un contacto) 1 es para un trabajador.

    }
}
