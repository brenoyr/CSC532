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
  public partial class FrmWelcome : Form
  {
    private FrmLevel frmLevel;
    public FrmWelcome()
    {
      InitializeComponent();
      welcomeLable.Parent = gifPeanut;
    }

    private void startGameBtn_Click(object sender, EventArgs e)
    {
      frmLevel = new FrmLevel();
      frmLevel.Show();
      this.Close();
    }
  }
}
