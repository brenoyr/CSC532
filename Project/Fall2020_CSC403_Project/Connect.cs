using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel();
            frmLevel.FrmLevel_Load(sender, e);
            frmLevel.tmrPlayerMove.Enabled = false;
            frmLevel.tmrUpdateInGameTime.Enabled = false;
            frmLevel.Hide();

            FrmBattlePvP frmBattlePvP = new FrmBattlePvP(false, textBox1.Text);
            frmBattlePvP.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel();
            frmLevel.FrmLevel_Load(sender, e);
            
            frmLevel.tmrPlayerMove.Enabled = false;
            frmLevel.tmrUpdateInGameTime.Enabled = false;
            frmLevel.Hide();

            FrmBattlePvP frmBattlePvP = new FrmBattlePvP(true, "");
            frmBattlePvP.Show();

        }
    }
}
