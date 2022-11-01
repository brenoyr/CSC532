using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;
using MyGameLibrary.Models;

namespace Fall2020_CSC403_Project
{
    public partial class StatsWindow : Form
    {
        private Button btn;
        public StatsWindow()
        {
            
            InitializeComponent();
            update_data(false);
        }

        private void update_data(bool save_just_loaded)
        {

            var data = DatabaseHandler.get_latest_statistics();
            

            this.DamageDoneData.Text = data.DamageDone.ToString();
            this.DamageTakenData.Text = data.DamageTaken.ToString();
            this.ExperienceGainedData.Text = data.TotalExperienceGained.ToString();
            this.StrengthGainedData.Text = data.TotalStrengthGained.ToString();
            this.HealthGainedData.Text = data.TotalHealthGained.ToString();
            this.LevelsGainedData.Text = data.TotalLevelsGained.ToString();
            

            // Format distance traveled as ###,###
            var distance = data.DistanceTraveled / 100;
            this.DistanceTraveledData.Text = distance.ToString("N0") + " m";
        }
        
        private void StatsWindow_Load(object sender, EventArgs e)
        {

        }

        public void setBtn(Button btn)
        {
            this.btn = btn;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.btn.Enabled = true;
            // Dispose of the form
            Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
