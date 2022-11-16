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
            StatsWindow stats = new StatsWindow();
            stats.setBtn(this.btnStats);
            stats.Show();

        }
        

        private void btnQuit_Click(object sender, EventArgs e)
    {
      Application.Exit();   // exit application
      // line below currently crashes game as of 11/15/22
      // Environment.Exit(0);  // terminates without event handlers intervening
    }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // if there is no current save, create a new one
            
            if (SaveModel.SaveName == null)
            {
                MessageBox.Show("No save currently loaded. Please load a save or create a new one");
                this.btnNewSave_Click(sender, e);
            }
            DatabaseHandler.update_game_save();
            DatabaseHandler.insert_statistics();
            MessageBox.Show("Game saved successfully");


        }

        private void btnLoadSave_Click(object sender, EventArgs e)
        {

            // Display all saves in database
            List<String> saves = DatabaseHandler.get_all_saves();
            if (saves.Count == 0)
            {
                MessageBox.Show("No saves found");
                return;
            }
            // Display save names in a form
            FrmSaves frmSaves = new FrmSaves(saves);
            frmSaves.Show();
            // Make frmSaves show up on top of this form
            frmSaves.TopMost = false;

            this.Close();




        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {

            InputBoxValidation validation = delegate (string val) {
                if (val == null || val == "")
                {
                    return "Please enter a name for your save";
                }
                if (DatabaseHandler.save_exists(val))
                {
                    return "A save with that name already exists";
                }
                return "";
            };

            string SaveName = "";
            if (InputBox.Show("Save Name", "Enter a name for your save:", ref SaveName, validation) == DialogResult.OK)
            {
                // Save game
                SaveModel.SaveName = SaveName;
                SaveModel.SaveDate = DateTime.Now;
                DatabaseHandler.insert_game_save();
                MessageBox.Show("Game saved successfully!");
            }

        }
    }
}
