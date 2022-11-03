using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using MyGameLibrary.Models;
using System.Collections.Generic;
using WMPLib;
using System.Media;
using System.Collections;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
	private Player player;

	private Enemy enemyPoisonPacket;
	private Enemy bossKoolaid;
	private Enemy enemyCheeto;
	private Character[] walls;
	private Medkit[] medkits;

  private DateTime timeBegin;
	private TimeSpan span;
  private FrmBattle frmBattle;
  private FrmPause frmPause;

	// PictureBox to handle dead Enemy and player
	private Enemy offScreenEnemy; // whenever an enemy dies, set that enemy to this instance (a hidden pictureBox)
	private Player offScreenPlayer;

	private Medkit offScreenMedkit;
	private int MEDKIT_VALUE;

	//WindowsMediaPlayer backgroundMusic = new WindowsMediaPlayer();
	bool bgPlaying = true;

	public FrmLevel() {
	  InitializeComponent();
		backgroundMusicPlayer.URL = "Run-Amok.wav";
		backgroundMusicPlayer.settings.playCount = 999; // repeat the music when it ends
		backgroundMusicPlayer.Visible = false;
	}

	private void FrmLevel_Load(object sender, EventArgs e) {
	  const int PADDING = 7;
	  const int NUM_WALLS = 13;
	  const int NUM_MEDKITS = 2;
	  MEDKIT_VALUE = 5;

	  player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
	  bossKoolaid = new Enemy("KoolAid", CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
	  SaveModel.KoolAidAlive = true;
	  enemyPoisonPacket = new Enemy("PoisonPacket", CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
	  SaveModel.PoisonPacketAlive = true;
	  enemyCheeto = new Enemy("Cheeto", CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
	  SaveModel.CheetoAlive = true;

		// set the initial moving for enemy
		enemyCheeto.MovingDirection = "left";
		enemyPoisonPacket.MovingDirection = "up";

		// create instance of for dead enemy and player
		offScreenEnemy = new Enemy("", CreatePosition(picOffScreenEnemy), CreateCollider(picOffScreenEnemy, 0));
	  offScreenPlayer = new Player(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0));
		offScreenEnemy.Die();
		offScreenPlayer.Die();


		bossKoolaid.Img = picBossKoolAid.BackgroundImage;

	  offScreenMedkit = new Medkit(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0), 0);

	  bossKoolaid.Img = picBossKoolAid.BackgroundImage;
	  enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
	  enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

	  bossKoolaid.Color = Color.Red;
	  enemyPoisonPacket.Color = Color.Green;
	  enemyCheeto.Color = Color.FromArgb(255, 245, 161);

		bossKoolaid.Type = "boss";
		enemyPoisonPacket.Type = "regular";
		enemyCheeto.Type = "regular";

	  walls = new Character[NUM_WALLS];
	  for (int w = 0; w < NUM_WALLS; w++) {
		PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
		walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
	  }

	  var medkitPositions = new ArrayList();
	  medkits = new Medkit[NUM_MEDKITS];
	  for (int m = 0; m < NUM_MEDKITS; m++) {
		PictureBox pic = Controls.Find("medkit" + m.ToString(), true)[0] as PictureBox;
		medkits[m] = new Medkit(CreatePosition(pic), CreateCollider(pic, PADDING), MEDKIT_VALUE);
		SaveModel.Medkit1Alive = true;
		SaveModel.Medkit2Alive = true;
		Dictionary<string, float> medkitPos = new Dictionary<string, float>();
		medkitPos.Add("x", medkits[m].Position.x);
		medkitPos.Add("y", medkits[m].Position.y);
		medkitPositions.Add(medkitPos);

	  }

	  SaveModel.Medkit1Position = (Dictionary<string, float>)medkitPositions[0];
	  SaveModel.Medkit2Position = (Dictionary<string, float>)medkitPositions[1];


	  Game.player = player;
	  timeBegin = DateTime.Now;

		//backgroundMusic.controls.play();

		// Show player's health bar when the game first loaded
		PlayerHealthBar();
	}

	private Vector2 CreatePosition(PictureBox pic) {
	  return new Vector2(pic.Location.X, pic.Location.Y);
	}

	private Collider CreateCollider(PictureBox pic, int padding) {
	  Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
	  return new Collider(rect);
	}

	// now this function also tells the "moving" character to stop moving
	private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
	  if(player.face_direction == "front")
		picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_front;
	  else
		picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_back;

	  player.move_direction = "still";
	  player.ResetMoveSpeed();
	}

	private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
	  span = DateTime.Now - timeBegin;
	  string time = span.ToString(@"hh\:mm\:ss");
	  SaveModel.InGameTime = time;
	  lblInGameTime.Text = "Time: " + SaveModel.InGameTime.ToString();

	}

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
		// Remove dead player's image
		if (IsDead(player))
		{
			picPlayer.Hide();
			player = offScreenPlayer;
			player.Die();
		} 
		else
		{
			// move player
			player.Move(true);

			Dictionary<string, float> playerPos = new Dictionary<string, float>();
			playerPos.Add("x", player.Position.x);
			playerPos.Add("y", player.Position.y);
            SaveModel.PlayerPosition = playerPos;

                
			// check collision with walls
			if (HitAWall(player))
			{
				player.MoveBack();
			}

			// check collision with enemies
			if (HitAChar(player, enemyPoisonPacket))
			{
				if (enemyPoisonPacket.Health > 0)
          		{
					Fight(enemyPoisonPacket);
				}
			}
			if (HitAChar(player, enemyCheeto))
			{
				if (enemyCheeto.Health > 0)
          		{
					Fight(enemyCheeto);
				} 
			}
			if (HitAChar(player, bossKoolaid))
			{
				if (bossKoolaid.Health > 0)
          		{
					player.MoveBack();
					Fight(bossKoolaid);
				}
			}
			if (HitAMedkit(player)) 
			{ 
				PlayerHealthBar();
			}

			// update player's picture box
			picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            
		}

        //Remove the dead enemies' images
        if (IsDead(enemyPoisonPacket))
        {
          picEnemyPoisonPacket.Hide();
          enemyPoisonPacket = offScreenEnemy;
		  SaveModel.PoisonPacketAlive = false;
        }
        if (IsDead(enemyCheeto))
        {
          picEnemyCheeto.Hide();
          enemyCheeto = offScreenEnemy;
		  SaveModel.CheetoAlive = false;
        }
        if (IsDead(bossKoolaid))
        {
          picBossKoolAid.Hide();
          bossKoolaid = offScreenEnemy;
		  SaveModel.KoolAidAlive = false;
        }

        // Update player's health while he is moving
        PlayerHealthBar();

		// call function for enemies moving infinitely
		if (enemyPoisonPacket.Health > 0 && !HitAChar(player, enemyPoisonPacket))
		{
			MoveInterval(enemyPoisonPacket, picEnemyPoisonPacket, "y", 2);
		}
		if (enemyCheeto.Health > 0 && !HitAChar(player, enemyCheeto))
		{
			MoveInterval(enemyCheeto, picEnemyCheeto, "x", 1);
		}
	}

	public void set_save()
	{
		
		player.Position = new Vector2(SaveModel.PlayerPosition["x"], SaveModel.PlayerPosition["y"]);
		picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
		player.face_direction = SaveModel.PlayerFaceDirection;
		player.move_direction = SaveModel.PlayerMoveDirection;
		player.Health = SaveModel.PlayerHealth;
		player.MaxHealth = SaveModel.PlayerMaxHealth;
		player.strength = SaveModel.Strength;
		player.experience = SaveModel.Experience;
		player.level = SaveModel.Level;

		enemyPoisonPacket.Position = new Vector2(SaveModel.PoisonPacketPosition["x"], SaveModel.PoisonPacketPosition["y"]);
		picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
		enemyPoisonPacket.MovingDirection = SaveModel.PoisonPacketMoveDirection;		
		if (SaveModel.PoisonPacketAlive == false)
		{
			picEnemyPoisonPacket.Hide();
			enemyPoisonPacket = offScreenEnemy;
		}

		enemyCheeto.Position = new Vector2(SaveModel.CheetoPosition["x"], SaveModel.CheetoPosition["y"]);
		picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
		enemyCheeto.MovingDirection = SaveModel.CheetoMoveDirection;
		if (SaveModel.CheetoAlive == false)
		{
			picEnemyCheeto.Hide();
			enemyCheeto = offScreenEnemy;
		}

		// bossKoolaid.Position = new Vector2(SaveModel.KoolAidPosition["x"], SaveModel.KoolAidPosition["y"]);
		// picBossKoolAid.Location = new Point((int)bossKoolaid.Position.x, (int)bossKoolaid.Position.y);
		// bossKoolaid.MovingDirection = SaveModel.KoolAidMoveDirection;
		if (SaveModel.KoolAidAlive == false)
		{
			picBossKoolAid.Hide();
			bossKoolaid = offScreenEnemy;
		}

		// Medkits
		medkits[0].Position = new Vector2(SaveModel.Medkit1Position["x"], SaveModel.Medkit1Position["y"]);
		medkits[1].Position = new Vector2(SaveModel.Medkit2Position["x"], SaveModel.Medkit2Position["y"]);

		if (SaveModel.Medkit1Alive == false)
		{
			PictureBox ppp = Controls.Find("medkit0", true)[0] as PictureBox;
			ppp.Hide();
			medkits[0].health_value = 0;
			medkits[0] = offScreenMedkit;
		}
		if (SaveModel.Medkit2Alive == false)
		{
			PictureBox ppp = Controls.Find("medkit1", true)[0] as PictureBox;
			ppp.Hide();
			medkits[1].health_value = 0;
			medkits[1] = offScreenMedkit;
		}

		// Update in game timer
	}
			




  private bool HitAWall(Character c) {
	  bool hitAWall = false;
	  for (int w = 0; w < walls.Length; w++) {
		if (c.Collider.Intersects(walls[w].Collider)) {
		  hitAWall = true;
		  break;
		}
	  }
	  return hitAWall;
	}

	private bool HitAMedkit(Character c) {
	  bool hitAWall = false;
	  for (int m = 0; m < medkits.Length; m++) {
		if (c.Collider.Intersects(medkits[m].Collider)) {
		  if (((player.Health + medkits[m].health_value) <= player.MaxHealth) && (player.Health < player.MaxHealth)) {
			  Console.WriteLine("player is being healed");
			  player.Health += medkits[m].health_value;
			  SaveModel.PlayerHealth = player.Health;
			  PictureBox ppp = Controls.Find("medkit" + m.ToString(), true)[0] as PictureBox;
			  ppp.Hide();
			  if(m == 0) {
				SaveModel.Medkit1Alive = false;
			  } else if (m == 1) {
				SaveModel.Medkit2Alive = false;
			  }
			  medkits[m].health_value = 0;
			  medkits[m] = offScreenMedkit;

              hitAWall = true;
		  }
		  else { 
			  Console.WriteLine("You are already at full health!");
		  }
		  break;
		  
		}
	  }
	  
	  return hitAWall;
	}

	private bool HitAChar(Character you, Character other) {
	  return you.Collider.Intersects(other.Collider);
	}

	private void Fight(Enemy enemy) {
	  player.ResetMoveSpeed();
	  //player.MoveBack();
		frmBattle = FrmBattle.GetInstance(enemy);
	  frmBattle.Show();
		Console.WriteLine(enemy);

    if (enemy == bossKoolaid) {
			frmBattle.SetupForBossBattle();
	  }
	}

	// now this function also controls what is shown in the player picturebox (animation)
	private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
	  switch (e.KeyCode) {
		case Keys.Left:
		  if (player.move_direction != "left" ){
			player.move_direction = "left";
			if (player.face_direction == "front")
				picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_front;
			else
				picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_back;
		  }
		  player.GoLeft();
		  break;

		case Keys.Right:
		  if (player.move_direction != "right" ){
			player.move_direction = "right";
			if (player.face_direction == "front")
				picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_front;
			else
				picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_back;
		  }
		  player.GoRight();
		  break;

		case Keys.Up:
		  if (player.move_direction != "backward" ){
			player.move_direction = "backward";
			player.face_direction = "back";
			picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.walk_back;
		  }
		  player.GoUp();
		  break;

		case Keys.Down:
		  if (player.move_direction != "forward" ){
			player.move_direction = "forward";
			player.face_direction = "front";
			picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.walk_front;
		  }
		  player.GoDown();
		  break;

		case Keys.Escape:
			DatabaseHandler.insert_statistics();
			ShowPauseMenu();
      		break;

		default:
			player.ResetMoveSpeed();
			break;
	  }

	  SaveModel.PlayerFaceDirection = player.face_direction;
	  SaveModel.PlayerMoveDirection = player.move_direction;

    }

  private void ShowPauseMenu()
  {
    frmPause = new FrmPause();
    tmrUpdateInGameTime.Enabled = false;    // stop updating game clock
    frmPause.ShowDialog();                  // ShowDialog() disables game window
    timeBegin = DateTime.Now - span;        // account for time elapsed during pause
    tmrUpdateInGameTime.Enabled = true;
  }

	//=======================================================================================
	// Function for update the player's health bar on the main map
	public void PlayerHealthBar()
	{
		float playerHealthPer = player.Health / (float)player.MaxHealth;

		const int MAX_HEALTHBAR_WIDTH = 226;
		lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

		lblPlayerHealthFull.Text = player.Health.ToString();
	}

	// Function to check if enemy is dead
	public bool IsDead(BattleCharacter character)
	{
		bool isDead = false;
		if (character.Health <= 0)
		{
			isDead = true;
		}
		return isDead;
	}

	//=======================================================================================
	// Function to move enemy infinitely 
	public void MoveInterval(Enemy enemy, PictureBox pic, string moveCoordinate, int speed)
	{
		if (moveCoordinate == "x")
      	{
			if (enemy.MovingDirection == "left")
			{
				enemy.Moving("left", speed);
				enemy.Move(false);
				pic.Location = new Point((int)enemy.Position.x, (int)enemy.Position.y);

				if (HitAWall(enemy))
				{
					enemy.MovingDirection = "right";
					enemy.MoveBack();
				}
			}
			else
			{
				enemy.Moving("right", speed);
				enemy.Move(false);
				pic.Location = new Point((int)enemy.Position.x, (int)enemy.Position.y);

				if (HitAWall(enemy))
				{
					enemy.MovingDirection = "left";
					enemy.MoveBack();
				}
			}
			
			if (enemy.Name.Equals("KoolAid"))
			{
				Dictionary<string, float> enemyPos = new Dictionary<string, float>();
				enemyPos.Add("x", enemy.Position.x);
				enemyPos.Add("y", enemy.Position.y);
				SaveModel.KoolAidPosition = enemyPos;
				SaveModel.KoolAidMoveDirection = enemy.MovingDirection;

			} else if (enemy.Name.Equals("Cheeto"))
			{
				Dictionary<string, float> enemyPos = new Dictionary<string, float>();
				enemyPos.Add("x", enemy.Position.x);
				enemyPos.Add("y", enemy.Position.y);
				SaveModel.CheetoPosition = enemyPos;
				SaveModel.CheetoMoveDirection = enemy.MovingDirection;

			} else if(enemy.Name.Equals("PoisonPacket"))
			{
				Dictionary<string, float> enemyPos = new Dictionary<string, float>();
				enemyPos.Add("x", enemy.Position.x);
				enemyPos.Add("y", enemy.Position.y);
				SaveModel.PoisonPacketPosition = enemyPos;
				SaveModel.PoisonPacketMoveDirection = enemy.MovingDirection;
			}

		} 
			
		else if (moveCoordinate == "y")
      	{
			if (enemy.MovingDirection == "up")
			{
				enemy.Moving("up", speed);
				enemy.Move(false);
				pic.Location = new Point((int)enemy.Position.x, (int)enemy.Position.y);

				if (HitAWall(enemy))
				{
					enemy.MovingDirection = "down";
					enemy.MoveBack();
				}
			}
			else
			{
				enemy.Moving("down", speed);
				enemy.Move(false);
				pic.Location = new Point((int)enemy.Position.x, (int)enemy.Position.y);

				if (HitAWall(enemy))
				{
					enemy.MovingDirection = "up";
					enemy.MoveBack();
				}
			}

			if (enemy.Name.Equals("KoolAid"))
			{
				Dictionary<string, float> enemyPos = new Dictionary<string, float>();
				enemyPos.Add("x", enemy.Position.x);
				enemyPos.Add("y", enemy.Position.y);
				SaveModel.KoolAidPosition = enemyPos;
				SaveModel.KoolAidMoveDirection = enemy.MovingDirection;

			} else if (enemy.Name.Equals("Cheeto"))
			{
				Dictionary<string, float> enemyPos = new Dictionary<string, float>();
				enemyPos.Add("x", enemy.Position.x);
				enemyPos.Add("y", enemy.Position.y);
				SaveModel.CheetoPosition = enemyPos;
				SaveModel.CheetoMoveDirection = enemy.MovingDirection;

			} else if(enemy.Name.Equals("PoisonPacket"))
			{
				Dictionary<string, float> enemyPos = new Dictionary<string, float>();
				enemyPos.Add("x", enemy.Position.x);
				enemyPos.Add("y", enemy.Position.y);
				SaveModel.PoisonPacketPosition = enemyPos;
				SaveModel.PoisonPacketMoveDirection = enemy.MovingDirection;
			}

		}
	}

    private void MuteBtn_Click(object sender, EventArgs e)
    {
			if (bgPlaying == false)
      {
				backgroundMusicPlayer.Ctlcontrols.play();
				backgroundMusicPlayer.settings.playCount = 999;
				bgPlaying = true;
				MuteBtn.BackgroundImage = Resources.mute;
			} 
			else
      {
				backgroundMusicPlayer.Ctlcontrols.stop();
				bgPlaying = false;
				MuteBtn.BackgroundImage = Resources.volume;
			}
    }
  }

}

