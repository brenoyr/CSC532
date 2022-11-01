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
                PlayerPosition = SaveModel.PlayerPosition
            });

            insert_statistics();
        }

        public static SaveDatabaseModel get_latest_game_save()
        {

            // Get the latest game save model from the database
            SaveDatabaseModel save = get_game_save_collection().Find(_ => true).SortByDescending(x => x.Id).Limit(1).FirstOrDefault();
            SaveModel.SaveName = save.SaveName;
            SaveModel.PlayerPosition = save.PlayerPosition;

            return save;
        }
    }


    
}
