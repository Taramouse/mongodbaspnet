using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDB.AspNet.Models
{
    public class Employee
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public ObjectId Name { get; set; }
        [BsonElement("email")]
        public ObjectId Email { get; set; }
        [BsonElement("level")]
        public ObjectId Level { get; set; }
        [BsonElement("createddate")]
        public ObjectId CreateDate { get; set; }

        public override string ToString()
        {
            string str = string.Format("Id: {0}\r\nName: {1}\r\nEmail: {2}\r\nLevel: {3}\r\nCreatedDate: {4}\r\n\r\n",
                Id, Name, Email, Level, CreateDate);
            return str;
        }
    }
}