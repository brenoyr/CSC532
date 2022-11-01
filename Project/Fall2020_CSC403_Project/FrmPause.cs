using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using MyGameLibrary.Models;

namespace Fall2020_CSC403_Project
{
  public partial class FrmPause : Form
  {
        public FrmPause()
        {
          InitializeComponent();
        }

        private void FrmPause_Load(object sender, EventArgs e)
        {
      
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
          Application.Restart();  // exit and start new instance
          Environment.Exit(0);    // terminates without event handlers intervening
        }

        private void btnShow_Statistics(object sender, EventArgs e)
        {
            // Disable button
            this.btnStats.Enabled = false;
            // TODO show stats window
            StatsWindow stats = new StatsWindow();
            stats.setBtn(this.btnStats);
            stats.Show();

        }
        

        private void btnQuit_Click(object sender, EventArgs e)
    {
      Application.Exit();   // exit application
      Environment.Exit(0);  // terminates without event handlers intervening
    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Form for save name
            // Get current date and time and use it as the save name
            string saveName = DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");
            SaveModel.SaveName = saveName;


            DatabaseHandler.insert_game_save();

            Console.WriteLine("Game saved as " + saveName);

        }

        private void btnLoadSave_Click(object sender, EventArgs e)
        {

            StatisticsDatabaseModel stats = DatabaseHandler.get_statistics_by_id(DatabaseHandler.get_latest_game_save().Id);

            StatisticsModel.TotalLevelsGained = stats.TotalLevelsGained;
            StatisticsModel.TotalHealthGained = stats.TotalHealthGained;
            StatisticsModel.TotalExperienceGained = stats.TotalExperienceGained;
            StatisticsModel.TotalStrengthGained = stats.TotalStrengthGained;
            StatisticsModel.DamageDone = stats.DamageDone;
            StatisticsModel.DamageTaken = stats.DamageTaken;
            StatisticsModel.DistanceTraveled = stats.DistanceTraveled;

            // Insert

            FrmLevel mainForm = Application.OpenForms.OfType<FrmLevel>().FirstOrDefault();
            this.Close();
            mainForm.set_save();
            DatabaseHandler.insert_statistics();

        }
    }
}
