using MongoDB.Driver;
using MyGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;
using MongoDB.Bson;

namespace MyGameLibrary
{
    public class DatabaseHandler
    {
        private static MongoClient instance = null;
        
        private static MongoClient get_connection_instance()
        {
            
                if (instance == null)
                {
                    instance = new MongoClient("mongodb://localhost:27017");
                }
                return instance;
        }
        
        private static IMongoDatabase get_database(string database_name)
        {

            return DatabaseHandler.get_connection_instance().GetDatabase(database_name);
            
        }

        public static IMongoCollection<StatisticsDatabaseModel> get_statistics_collection()
        {

            return DatabaseHandler.get_database("CSC532").GetCollection<StatisticsDatabaseModel>("Statistics");
            
        } 

        public static IMongoCollection<SaveDatabaseModel> get_game_save_collection()
        {

            return DatabaseHandler.get_database("CSC532").GetCollection<SaveDatabaseModel>("Saves");

        }

        public async static void insert_statistics()
        {

            // Insert statistics model with values it is currently holding 
            await DatabaseHandler.get_statistics_collection().InsertOneAsync(new StatisticsDatabaseModel
            {
                GameSaveId = StatisticsModel.GameSaveId,
                TotalLevelsGained = StatisticsModel.TotalLevelsGained,
                TotalHealthGained = StatisticsModel.TotalHealthGained,
                TotalExperienceGained = StatisticsModel.TotalExperienceGained,
                TotalStrengthGained = StatisticsModel.TotalStrengthGained,
                DamageDone = StatisticsModel.DamageDone,
                DamageTaken = StatisticsModel.DamageTaken,
                DistanceTraveled = StatisticsModel.DistanceTraveled
            });

        }

        public static StatisticsDatabaseModel get_latest_statistics()
        {

            // Get the latest statistics model from the database
            return DatabaseHandler.get_statistics_collection().Find(_ => true).SortByDescending(x => x.Id).Limit(1).FirstOrDefault();

        }

        public static StatisticsDatabaseModel get_statistics_by_id(string id)
        {

            // Get the statistics model from the database by id
            return DatabaseHandler.get_statistics_collection().Find(x => x.GameSaveId == id).FirstOrDefault();

        }

        public async static void insert_game_save()
        {

            // Bson id
            ObjectId id = ObjectId.GenerateNewId();
            StatisticsModel.GameSaveId = id.ToString();

            // Insert game save model with values it is currently holding 
            await DatabaseHandler.get_game_save_collection().InsertOneAsync(new SaveDatabaseModel
            {
                Id = id.ToString(),
                SaveName = SaveModel.SaveName,
                SaveDate = DateTime.Now,
                PlayerPosition = SaveModel.PlayerPosition,
                PoisonPacketPosition = SaveModel.PoisonPacketPosition,
                PoisonPacketAlive = SaveModel.PoisonPacketAlive,
                CheetoPosition = SaveModel.CheetoPosition,
                CheetoAlive = SaveModel.CheetoAlive,
                KoolAidPosition = SaveModel.KoolAidPosition,
                KoolAidAlive = SaveModel.KoolAidAlive,
                InGameTime = SaveModel.InGameTime,
                PlayerFaceDirection = SaveModel.PlayerFaceDirection,
                PlayerMoveDirection = SaveModel.PlayerMoveDirection,
                PoisonPacketMoveDirection = SaveModel.PoisonPacketMoveDirection,
                CheetoMoveDirection = SaveModel.CheetoMoveDirection,
                KoolAidMoveDirection = SaveModel.KoolAidMoveDirection,
                Medkit1Position = SaveModel.Medkit1Position,
                Medkit1Alive = SaveModel.Medkit1Alive,
                Medkit2Position = SaveModel.Medkit2Position,
                Medkit2Alive = SaveModel.Medkit2Alive,
                PlayerHealth = SaveModel.PlayerHealth,
                PlayerMaxHealth = SaveModel.PlayerMaxHealth,
                Strength = SaveModel.Strength,
                Experience = SaveModel.Experience,
                Level = SaveModel.Level,
            });

            insert_statistics();
        }

        public async static void update_game_save()
        {

            // Update game save model with values it is currently holding 
            await DatabaseHandler.get_game_save_collection().ReplaceOneAsync(x => x.SaveName == SaveModel.SaveName, new SaveDatabaseModel
            {
                Id = StatisticsModel.GameSaveId,
                SaveName = SaveModel.SaveName,
                SaveDate = DateTime.Now,
                PlayerPosition = SaveModel.PlayerPosition,
                PoisonPacketPosition = SaveModel.PoisonPacketPosition,
                PoisonPacketAlive = SaveModel.PoisonPacketAlive,
                CheetoPosition = SaveModel.CheetoPosition,
                CheetoAlive = SaveModel.CheetoAlive,
                KoolAidPosition = SaveModel.KoolAidPosition,
                KoolAidAlive = SaveModel.KoolAidAlive,
                InGameTime = SaveModel.InGameTime,
                PlayerFaceDirection = SaveModel.PlayerFaceDirection,
                PlayerMoveDirection = SaveModel.PlayerMoveDirection,
                PoisonPacketMoveDirection = SaveModel.PoisonPacketMoveDirection,
                CheetoMoveDirection = SaveModel.CheetoMoveDirection,
                KoolAidMoveDirection = SaveModel.KoolAidMoveDirection,
                Medkit1Position = SaveModel.Medkit1Position,
                Medkit1Alive = SaveModel.Medkit1Alive,
                Medkit2Position = SaveModel.Medkit2Position,
                Medkit2Alive = SaveModel.Medkit2Alive,
                PlayerHealth = SaveModel.PlayerHealth,
                PlayerMaxHealth = SaveModel.PlayerMaxHealth,
                Strength = SaveModel.Strength,
                Experience = SaveModel.Experience,
                Level = SaveModel.Level,
            });

            insert_statistics();
        }

        public static SaveDatabaseModel get_latest_game_save()
        {

            // Get the latest game save model from the database based on save date
            var save =  DatabaseHandler.get_game_save_collection().Find(_ => true).SortByDescending(x => x.SaveDate).Limit(1).FirstOrDefault();

            SaveModel.SaveName = save.SaveName;
            SaveModel.PlayerPosition = save.PlayerPosition;
            SaveModel.SaveDate = save.SaveDate;
            SaveModel.PlayerPosition = save.PlayerPosition;
            SaveModel.PoisonPacketPosition = save.PoisonPacketPosition;
            SaveModel.PoisonPacketAlive = save.PoisonPacketAlive;
            SaveModel.CheetoPosition = save.CheetoPosition;
            SaveModel.CheetoAlive = save.CheetoAlive;
            SaveModel.KoolAidPosition = save.KoolAidPosition;
            SaveModel.KoolAidAlive = save.KoolAidAlive;
            SaveModel.InGameTime = save.InGameTime;
            SaveModel.PlayerFaceDirection = save.PlayerFaceDirection;
            SaveModel.PlayerMoveDirection = save.PlayerMoveDirection;
            SaveModel.PoisonPacketMoveDirection = save.PoisonPacketMoveDirection;
            SaveModel.CheetoMoveDirection = save.CheetoMoveDirection;
            SaveModel.KoolAidMoveDirection = save.KoolAidMoveDirection;
            SaveModel.Medkit1Position = save.Medkit1Position;
            SaveModel.Medkit1Alive = save.Medkit1Alive;
            SaveModel.Medkit2Position = save.Medkit2Position;
            SaveModel.Medkit2Alive = save.Medkit2Alive;
            SaveModel.PlayerHealth = save.PlayerHealth;
            SaveModel.PlayerMaxHealth = save.PlayerMaxHealth;
            SaveModel.Strength = save.Strength;
            SaveModel.Experience = save.Experience;
            SaveModel.Level = save.Level;

            return save;
        }

        public static SaveDatabaseModel get_save_by_name(string name)
        {

            // Get the game save model from the database by name
            SaveDatabaseModel save = get_game_save_collection().Find(x => x.SaveName == name).FirstOrDefault();
            SaveModel.SaveName = save.SaveName;
            SaveModel.PlayerPosition = save.PlayerPosition;
            SaveModel.SaveDate = save.SaveDate;
            SaveModel.PlayerPosition = save.PlayerPosition;
            SaveModel.PoisonPacketPosition = save.PoisonPacketPosition;
            SaveModel.PoisonPacketAlive = save.PoisonPacketAlive;
            SaveModel.CheetoPosition = save.CheetoPosition;
            SaveModel.CheetoAlive = save.CheetoAlive;
            SaveModel.KoolAidPosition = save.KoolAidPosition;
            SaveModel.KoolAidAlive = save.KoolAidAlive;
            SaveModel.InGameTime = save.InGameTime;
            SaveModel.PlayerFaceDirection = save.PlayerFaceDirection;
            SaveModel.PlayerMoveDirection = save.PlayerMoveDirection;
            SaveModel.PoisonPacketMoveDirection = save.PoisonPacketMoveDirection;
            SaveModel.CheetoMoveDirection = save.CheetoMoveDirection;
            SaveModel.KoolAidMoveDirection = save.KoolAidMoveDirection;
            SaveModel.Medkit1Position = save.Medkit1Position;
            SaveModel.Medkit1Alive = save.Medkit1Alive;
            SaveModel.Medkit2Position = save.Medkit2Position;
            SaveModel.Medkit2Alive = save.Medkit2Alive;
            SaveModel.PlayerHealth = save.PlayerHealth;
            SaveModel.PlayerMaxHealth = save.PlayerMaxHealth;
            SaveModel.Strength = save.Strength;
            SaveModel.Experience = save.Experience;
            SaveModel.Level = save.Level;

            return save;
        }

        public static bool save_exists(string save_name)
        {

            // Check if a save with the given name exists
            return get_game_save_collection().Find(x => x.SaveName == save_name).FirstOrDefault() != null;

        }

        public static List<string> get_all_saves()
        {

            // Get all unique save names and sort by latest first based on SaveDate
            List<string> saves = get_game_save_collection().Find(_ => true).SortByDescending(x => x.SaveDate).Project(x => x.SaveName).ToList();

            // Limit list size to 30
            if (saves.Count > 30)
            {
                saves.RemoveRange(30, saves.Count - 30);
            }

            return saves;

        }

        public static void cleanup()
        {

            List<string> saves = get_all_saves();
            Random random = new Random();
            // foreach (string save in saves)
            // {
            //     // Add random DateTime to all
            //     get_game_save_collection().UpdateMany(x => x.SaveName == save, Builders<SaveDatabaseModel>.Update.Set("SaveDate", DateTime.Now.AddDays(random.Next(-30, -1))));
                
            // }
            // Delete everything from game save collection
            get_game_save_collection().DeleteMany(_ => true);

            
        }
    }


    
}
