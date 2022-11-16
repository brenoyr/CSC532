using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary.Models;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private FrmDeath frmDeath;
    private bool isCollapsed = true;
    private Random rnd = new Random();

		private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle(int bossLevel) {

        if (bossLevel == 1)
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        if (bossLevel == 2)
        {
            picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen_solomon;
                picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle_2);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void CheckForPlayerOrEnemyDeath()
    {
			if (player.Health <= 0)
			{
				ShowDeathMenu(); // show game over screen
				instance = null;
				Close();
				SoundPlayer playerDieSound = new SoundPlayer(Resources.player_die);
				playerDieSound.PlaySync();
			}
			else if (enemy.Health <= 0)
			{
				player.AlterExperience(enemy.Type);
				instance = null;
				Close();
				SoundPlayer dieSound = new SoundPlayer(Resources.enemy_die);
				dieSound.PlaySync();
			}
		}

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2); //-2
      }

      UpdateHealthBars();
      CheckForPlayerOrEnemyDeath();
    }

		private void btnSkills_Click(object sender, EventArgs e)
		{
			if (isCollapsed)
			{
				panelSkills.Size = panelSkills.MaximumSize;
				isCollapsed = false;
			}
			else
			{
				panelSkills.Size = panelSkills.MinimumSize;
				isCollapsed = true;
			}
		}

		private void btnSkill1_MouseHover(object sender, EventArgs e)
		{
      txtDescription.Visible = true;
      // "\n" doesn't work in TextBox tool
      txtDescription.Text = "Chance of critical hit." + Environment.NewLine + Environment.NewLine + "Low accuracy (33%)";
		}

		private void btnSkill1_MouseLeave(object sender, EventArgs e)
		{
			txtDescription.Visible = false;
		}

		private void btnSkill1_Click(object sender, EventArgs e)
		{
      if (rnd.Next(1, 3) == 2)  // pseudo-random 33% chance of success
      {
        player.OnAttack(-8); // critical hit
			}
			if (enemy.Health > 0)
			{
				enemy.OnAttack(-2);
		  }
			UpdateHealthBars();
			CheckForPlayerOrEnemyDeath();
		}

		private void btnSkill2_MouseHover(object sender, EventArgs e)
		{
			txtDescription.Visible = true;
			txtDescription.Text = "Powered-up attack." + Environment.NewLine + Environment.NewLine + "Recoil damage";
		}

		private void btnSkill2_MouseLeave(object sender, EventArgs e)
		{
			txtDescription.Visible = false;
		}
		private void btnSkill2_Click(object sender, EventArgs e)
    {
      player.OnAttack(-6);  // heavy hit
      enemy.OnAttack(-1);   // recoil damage
      if (enemy.Health > 0)
      {
        enemy.OnAttack(-2);
      }
			UpdateHealthBars();
			CheckForPlayerOrEnemyDeath();
		}

		private void ShowDeathMenu()
    {
        frmDeath = new FrmDeath();
        // removes the options to minimize/resize/close the window so the user has to make a choice
        frmDeath.ControlBox = false;
        frmDeath.ShowDialog(); // ShowDialog() disables game window
    }

    private void EnemyDamage(int amount) {

            enemy.AlterHealth(amount);
            amount = amount * -1;
            StatisticsModel.DamageDone += (uint)amount;
        }

    private void PlayerDamage(int amount) {
            

            player.AlterHealth(amount);
            amount = amount * -1;

            StatisticsModel.DamageTaken += (uint)amount;
        }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }
  }
}
