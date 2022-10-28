using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary.Models
{
    public class StatisticsModel
    {
        public static uint TotalLevelsGained { get; set; }
        public static uint TotalHealthGained { get; set; }
        
        public static uint TotalExperienceGained { get; set; }
        public static uint TotalStrengthGained { get; set; }
        public static uint DamageDone { get; set; }
        public static uint DamageTaken { get; set; }
        public static float DistanceTraveled { get; set; }

    }

    public class StatisticsDatabaseModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public uint TotalLevelsGained { get; set; }
        public uint TotalHealthGained { get; set; }
        
        public uint TotalExperienceGained { get; set; }
        public uint TotalStrengthGained { get; set; }

        public uint DamageDone { get; set; }
        public uint DamageTaken { get; set; }
        public float DistanceTraveled { get; set; }
    }
}
