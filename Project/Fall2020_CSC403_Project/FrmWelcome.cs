using System;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System.Windows.Forms;
using System.Media;


namespace Fall2020_CSC403_Project
{
  public partial class FrmWelcome : Form
  {
    private FrmLevel frmLevel;
    SoundPlayer welcomeSound = new SoundPlayer(Resources.Fluffing_a_Duck);
    public FrmWelcome()
    {
      InitializeComponent();
      welcomeLable.Parent = gifPeanut;

      
      welcomeSound.Play();
    }

    private void startGameBtn_Click(object sender, EventArgs e)
    {
      frmLevel = new FrmLevel();
      frmLevel.Show();
      welcomeSound.Stop();
      this.Hide();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

        private void PvPInit_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            connect.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
