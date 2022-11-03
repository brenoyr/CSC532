using MyGameLibrary.Models;
using MyGameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmSaves : Form
    {
        public FrmSaves(List<string> saves)
        {
            InitializeComponent();
            // Make window full screen
            this.WindowState = FormWindowState.Maximized;
            var x_position = 0;
            var y_position = 0;
            foreach (string save in saves)
            {
                // Create a button for each save
                Button btn = new Button();
                btn.Text = save;
                btn.Click += new EventHandler(btn_Click);
                this.Controls.Add(btn);

                // Size
                btn.Size = new Size(250, 100);

                // Make sure the buttons dont overlap
                btn.Location = new Point(x_position, y_position);
                y_position += 100;
                // If the button is too far down, move it to the next column
                if (y_position > this.Height)
                {
                    y_position = 0;
                    x_position += 250;
                }

                // Set color of text to white
                btn.ForeColor = Color.White;
                
                


            }

        }

        private void btn_Click(object sender, EventArgs e)
        {


            // Get text of button clicked
            Button btn = (Button)sender;
            string save = btn.Text;

            SaveDatabaseModel save_db = DatabaseHandler.get_save_by_name(save);
            StatisticsModel.GameSaveId = save_db.Id;
            
            StatisticsDatabaseModel stats = DatabaseHandler.get_statistics_by_id(save_db.Id);


            StatisticsModel.TotalLevelsGained = stats.TotalLevelsGained;
            StatisticsModel.TotalHealthGained = stats.TotalHealthGained;
            StatisticsModel.TotalExperienceGained = stats.TotalExperienceGained;
            StatisticsModel.TotalStrengthGained = stats.TotalStrengthGained;
            StatisticsModel.DamageDone = stats.DamageDone;
            StatisticsModel.DamageTaken = stats.DamageTaken;
            StatisticsModel.DistanceTraveled = stats.DistanceTraveled;

            // Insert

            FrmLevel mainForm = Application.OpenForms.OfType<FrmLevel>().FirstOrDefault();
            mainForm.set_save();
            DatabaseHandler.insert_statistics();

            MessageBox.Show("Game loaded succesfully");
            this.Close();
        }
    }
}

   