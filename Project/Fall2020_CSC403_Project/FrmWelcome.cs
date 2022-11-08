﻿using System;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System.Windows.Forms;
using System.Media;

namespace Fall2020_CSC403_Project
{
  public partial class FrmWelcome : Form
  {
    private FrmLevel frmLevel;
    public FrmWelcome()
    {
      InitializeComponent();
      welcomeLable.Parent = gifPeanut;

      SoundPlayer welcomeSound = new SoundPlayer(Resources.welcome_stranger);
      welcomeSound.Play();
    }

    private void startGameBtn_Click(object sender, EventArgs e)
    {
      frmLevel = new FrmLevel();
      frmLevel.Show();
      this.Hide();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
