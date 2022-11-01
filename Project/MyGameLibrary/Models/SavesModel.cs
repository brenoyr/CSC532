using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;
using MongoDB.Bson.Serialization;

namespace MyGameLibrary.Models
{
    public class SaveModel
    {
        public static string SaveName { get; set; }
        public static Dictionary<string, float> PlayerPosition { get; set; }

    }

    public class SaveDatabaseModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string SaveName { get; set; }
        public Dictionary<string, float> PlayerPosition { get; set; }

    }


}
