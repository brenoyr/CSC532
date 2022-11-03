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
        public static DateTime SaveDate { get; set; }
        public static Dictionary<string, float> PlayerPosition { get; set; }
        public static Dictionary<string, float> PoisonPacketPosition { get; set; }
        public static bool PoisonPacketAlive { get; set; }
        public static Dictionary<string, float> CheetoPosition { get; set; }
        public static bool CheetoAlive { get; set; }
        public static Dictionary<string, float> KoolAidPosition { get; set; }
        public static bool KoolAidAlive { get; set; }
        public static string InGameTime { get; set; }
        public static string PlayerFaceDirection { get; set; }
        public static string PlayerMoveDirection { get; set; }
        public static string PoisonPacketMoveDirection { get; set; }
        public static string CheetoMoveDirection { get; set; }
        public static string KoolAidMoveDirection { get; set; }
        public static Dictionary<string, float> Medkit1Position { get; set; }
        public static bool Medkit1Alive { get; set; }
        public static Dictionary<string, float> Medkit2Position { get; set; }
        public static bool Medkit2Alive { get; set; }
        public static int PlayerHealth { get; set; }
        public static int PlayerMaxHealth { get; set; }
        public static int Strength { get; set; }
        public static int Experience { get; set; }
        public static int Level { get; set; }

    }

    public class SaveDatabaseModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string SaveName { get; set; }
        public DateTime SaveDate { get; set; }
        public Dictionary<string, float> PlayerPosition { get; set; }
        public Dictionary<string, float> PoisonPacketPosition { get; set; }
        public bool PoisonPacketAlive { get; set; }
        public Dictionary<string, float> CheetoPosition { get; set; }
        public bool CheetoAlive { get; set; }
        public Dictionary<string, float> KoolAidPosition { get; set; }
        public bool KoolAidAlive { get; set; }
        public Dictionary<string, float> Medkit1Position { get; set; }
        public bool Medkit1Alive { get; set; }
        public Dictionary<string, float> Medkit2Position { get; set; }
        public bool Medkit2Alive { get; set; }
        public uint TotalLevelsGained { get; set; }
        public uint TotalHealthGained { get; set; }
        public uint TotalExperienceGained { get; set; }
        public uint TotalStrengthGained { get; set; }
        public string InGameTime { get; set; }
        public string PlayerFaceDirection { get; set; }
        public string PlayerMoveDirection { get; set; }
        public string PoisonPacketMoveDirection { get; set; }
        public string CheetoMoveDirection { get; set; }
        public string KoolAidMoveDirection { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerMaxHealth { get; set; }
        public int Strength { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        


    }


}
