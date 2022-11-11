
namespace Fall2020_CSC403_Project
{
  partial class FrmWelcome
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
      this.welcomeLable = new System.Windows.Forms.Label();
      this.startGameBtn = new System.Windows.Forms.Button();
      this.quitBtn = new System.Windows.Forms.Button();
      this.gifPeanut = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.gifPeanut)).BeginInit();
      this.SuspendLayout();
      // 
      // welcomeLable
      // 
      this.welcomeLable.BackColor = System.Drawing.Color.Transparent;
      this.welcomeLable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.welcomeLable.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomeLable.Location = new System.Drawing.Point(0, 0);
      this.welcomeLable.Name = "welcomeLable";
      this.welcomeLable.Padding = new System.Windows.Forms.Padding(1000, 100, 100, 100);
      this.welcomeLable.Size = new System.Drawing.Size(2468, 1112);
      this.welcomeLable.TabIndex = 1;
      this.welcomeLable.Text = "Welcome!";
      this.welcomeLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // startGameBtn
      // 
      this.startGameBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.startGameBtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startGameBtn.Location = new System.Drawing.Point(1671, 425);
      this.startGameBtn.Margin = new System.Windows.Forms.Padding(200, 3, 300, 600);
      this.startGameBtn.Name = "startGameBtn";
      this.startGameBtn.Size = new System.Drawing.Size(473, 138);
      this.startGameBtn.TabIndex = 2;
      this.startGameBtn.Text = "Start Game";
      this.startGameBtn.UseVisualStyleBackColor = false;
      this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
      // 
      // quitBtn
      // 
      this.quitBtn.AutoSize = true;
      this.quitBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.quitBtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.quitBtn.Location = new System.Drawing.Point(1671, 622);
      this.quitBtn.Name = "quitBtn";
      this.quitBtn.Size = new System.Drawing.Size(473, 133);
      this.quitBtn.TabIndex = 3;
      this.quitBtn.Text = "Quit";
      this.quitBtn.UseVisualStyleBackColor = false;
      this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
      // 
      // gifPeanut
      // 
      this.gifPeanut.BackColor = System.Drawing.SystemColors.Control;
      this.gifPeanut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gifPeanut.Image = ((System.Drawing.Image)(resources.GetObject("gifPeanut.Image")));
      this.gifPeanut.Location = new System.Drawing.Point(0, 0);
      this.gifPeanut.Name = "gifPeanut";
      this.gifPeanut.Size = new System.Drawing.Size(2468, 1112);
      this.gifPeanut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.gifPeanut.TabIndex = 0;
      this.gifPeanut.TabStop = false;
      // 
      // FrmWelcome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(2468, 1112);
      this.Controls.Add(this.quitBtn);
      this.Controls.Add(this.startGameBtn);
      this.Controls.Add(this.welcomeLable);
      this.Controls.Add(this.gifPeanut);
      this.Name = "FrmWelcome";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RUN";
      ((System.ComponentModel.ISupportInitialize)(this.gifPeanut)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox gifPeanut;
    private System.Windows.Forms.Label welcomeLable;
    private System.Windows.Forms.Button startGameBtn;
    private System.Windows.Forms.Button quitBtn;
  }
}