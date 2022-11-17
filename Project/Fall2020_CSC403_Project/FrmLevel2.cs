using Fall2020_CSC403_Project.code;
using MyGameLibrary.Models;
using MyGameLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Fall2020_CSC403_Project.Properties;
using System.Media;
using Vector2 = Fall2020_CSC403_Project.code.Vector2;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player;
        private Player player2;
        private Enemy enemyBullet;
        private Enemy bossSolomon;
        private Character[] walls;
        private Medkit[] medkits;
        private Spikes[] spikes;

        private DateTime timeBegin;
        private TimeSpan span;
        private FrmBattle frmBattle;
        private FrmPause frmPause;
        private FrmDeath frmDeath;

        // PictureBox to handle dead Enemy and player
        private Enemy offScreenEnemy; // whenever an enemy dies, set that enemy to this instance (a hidden pictureBox)
        private Player offScreenPlayer;

        private Medkit offScreenMedkit;
        private int MEDKIT_VALUE;
        private int SPIKES_DAMAGE;

        WindowsMediaPlayer backgroundMusic = new WindowsMediaPlayer();
        bool bgPlaying = true;

        public FrmLevel2()
        {
            InitializeComponent();
            backgroundMusic.URL = "Run-Amok.wav";
            backgroundMusic.settings.playCount = 999; // repeat the music when it ends
        }
        
        private void FrmLevel2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 10;
            const int NUM_MEDKITS = 2;
            const int NUM_SPIKES = 3;
            MEDKIT_VALUE = 5;
            SPIKES_DAMAGE = 2;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

            player2 = new Player(CreatePosition(picEnemyBullet), CreateCollider(picEnemyBullet, PADDING));
            bossSolomon = new Enemy("KoolAid", CreatePosition(picBossSolomon), CreateCollider(picBossSolomon, PADDING));
            SaveModel.KoolAidAlive = true;
            enemyBullet = new Enemy("Cheeto", CreatePosition(picEnemyBullet), CreateCollider(picEnemyBullet, PADDING));
            SaveModel.CheetoAlive = true;

            // set the initial moving for enemy
            enemyBullet.MovingDirection = "right";

            // create instance of for dead enemy and player
            offScreenEnemy = new Enemy("", CreatePosition(picOffScreenEnemy), CreateCollider(picOffScreenEnemy, 0));
            offScreenPlayer = new Player(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0));
            offScreenEnemy.Die();
            offScreenPlayer.Die();
            


            bossSolomon.Img = picBossSolomon.BackgroundImage;

            //offScreenMedkit = new Medkit(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0), 0);

            bossSolomon.Img = picBossSolomon.BackgroundImage;
            enemyBullet.Img = picEnemyBullet.BackgroundImage;

            bossSolomon.Color = Color.Red;
            enemyBullet.Color = Color.FromArgb(255, 245, 161);

            bossSolomon.Type = "boss";
            enemyBullet.Type = "regular";


            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            var medkitPositions = new ArrayList();
            medkits = new Medkit[NUM_MEDKITS];
            for (int m = 0; m < NUM_MEDKITS; m++)
            {
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

            spikes = new Spikes[NUM_SPIKES];
            for (int s = 0; s < NUM_SPIKES; s++)
            {
                PictureBox pic = Controls.Find("spikes" + s.ToString(), true)[0] as PictureBox;
                spikes[s] = new Spikes(CreatePosition(pic), CreateCollider(pic, PADDING), SPIKES_DAMAGE);

            }

            

            Game.player = player;
            Game.player2 = player2;
            timeBegin = DateTime.Now;

            backgroundMusic.controls.play();

            // Show player's health & experience bars when the game first loaded
            PlayerHealthBar();
            PlayerExperienceBar();

        }
        
        

        private void FrmLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (player.move_direction != "left")
                    {
                        player.move_direction = "left";
                        if (player.face_direction == "front")
                            picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_front;
                        else
                            picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_back;
                    }
                    player.GoLeft();
                    break;

                case Keys.Right:
                    if (player.move_direction != "right")
                    {
                        player.move_direction = "right";
                        if (player.face_direction == "front")
                            picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_front;
                        else
                            picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.side_back;
                    }
                    player.GoRight();
                    break;

                case Keys.Up:
                    if (player.move_direction != "backward")
                    {
                        player.move_direction = "backward";
                        player.face_direction = "back";
                        picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.walk_back;
                    }
                    player.GoUp();
                    break;

                case Keys.Down:
                    if (player.move_direction != "forward")
                    {
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

                case Keys.Space:
                    if (bgPlaying == false)
                    {
                        backgroundMusic.controls.play();
                        backgroundMusic.settings.playCount = 999;
                        bgPlaying = true;
                        picBgMusic.BackgroundImage = Resources.mute;
                        break;
                    }
                    else
                    {
                        backgroundMusic.controls.pause();
                        bgPlaying = false;
                        picBgMusic.BackgroundImage = Resources.volume;
                        break;
                    }

                default:
                    player.ResetMoveSpeed();
                    break;
            }

            SaveModel.PlayerFaceDirection = player.face_direction;
            SaveModel.PlayerMoveDirection = player.move_direction;

        }

        private void FrmLevel2_KeyUp(object sender, KeyEventArgs e)
        {
            if (player.face_direction == "front")
                picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_front;
            else
                picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_back;

            player.move_direction = "still";
            player.ResetMoveSpeed();
        }
        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            SaveModel.InGameTime = time;
            lblInGameTime.Text = "Time: " + SaveModel.InGameTime.ToString();

        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
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
                if (HitAChar(player, enemyBullet))
                {
                    if (enemyBullet.Health > 0)
                    {
                        Fight(enemyBullet);
                    }
                }
                if (HitAChar(player, bossSolomon))
                {
                    if (bossSolomon.Health > 0)
                    {
                        player.MoveBack();
                        Fight(bossSolomon);
                    }
                }
                if (HitAMedkit(player))
                {
                    SoundPlayer collectSound = new SoundPlayer(Resources.collect_sound);
                    collectSound.Play();
                    PlayerHealthBar();
                }
                if (HitASpike(player))
                {
                    /*Vector2 tmpLastPos = new Vector2(player.Position.x, player.Position.y - 20);
                    player.LastPosition = tmpLastPos;
                    player.MoveBack();
                    */
                    
                    SoundPlayer collectSound = new SoundPlayer(Resources.collect_sound);
                    collectSound.Play();
                    PlayerHealthBar();
                }

                // update player's picture box
                picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            }

            //Remove the dead enemies' images
            if (IsDead(enemyBullet))
            {
                picEnemyBullet.Hide();
                enemyBullet = offScreenEnemy;
                SaveModel.CheetoAlive = false;
            }
            if (IsDead(bossSolomon))
            {
                picBossSolomon.Hide();
                bossSolomon = offScreenEnemy;
                SaveModel.KoolAidAlive = false;
            }
            

            // Update player's health & experience bar while he is moving
            PlayerHealthBar();
            PlayerExperienceBar();

            // call function for enemies moving infinitely
            if (enemyBullet.Health > 0 && !HitAChar(player, enemyBullet))
            {
                MoveInterval(enemyBullet, picEnemyBullet, "x", 1);
            }
            

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

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
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

        public void PlayerExperienceBar()
        {
            float playerExperiencePer = player.experience / (float)player.MaxExperience;

            const int MAX_EXPBAR_WIDTH = 226;
            lblPlayerExperience.Width = (int)(MAX_EXPBAR_WIDTH * playerExperiencePer);

            lblPlayerExperience.Text = player.experience.ToString();
        }


        private bool HitAMedkit(Character c)
        {
            bool hitAWall = false;
            for (int m = 0; m < medkits.Length; m++)
            {
                if (c.Collider.Intersects(medkits[m].Collider))
                {
                    if (player.Health < player.MaxHealth)
                    {
                        Console.WriteLine("player is being healed");
                        player.Health += medkits[m].health_value;
                        SaveModel.PlayerHealth = player.Health;
                        PictureBox ppp = Controls.Find("medkit" + m.ToString(), true)[0] as PictureBox;
                        ppp.Hide();
                        if (m == 0)
                        {
                            SaveModel.Medkit1Alive = false;
                        }
                        else if (m == 1)
                        {
                            SaveModel.Medkit2Alive = false;
                        }
                        medkits[m].health_value = 0;
                        //Console.WriteLine("max heatlth(0) = " + player.MaxHealth);
                        //medkits[m] = offScreenMedkit;

                        hitAWall = true;

                        if (player.Health > player.MaxHealth)
                        {
                            player.Health = player.MaxHealth;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are already at full health!");
                    }
                    break;

                }
            }

            return hitAWall;
        }

        private bool HitASpike(Character c)
        {
            bool hitASpike = false;
            for (int s = 0; s < spikes.Length; s++)
            {
                if (c.Collider.Intersects(spikes[s].Collider))
                {
                    Console.WriteLine("player is being hurt");
                    player.Health -= spikes[s].damage_value;
                    //SaveModel.PlayerHealth = player.Health;

                    hitASpike = true;

                    if (player.Health <= 0)
                    {
                        picPlayer.Hide();
                        player = offScreenPlayer;
                        player.Die();
                        ShowDeathMenu();
                    }
                    player.GoUp();

                    Vector2 pos = new Vector2(player.Position.x, 605);
                    player.Position = pos;


                }
            }

            return hitASpike;
        }

        private void ShowDeathMenu()
        {
            frmDeath = new FrmDeath();
            // removes the options to minimize/resize/close the window so the user has to make a choice
            frmDeath.ControlBox = false;
            frmDeath.ShowDialog(); // ShowDialog() disables game window
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            //player.MoveBack();
            if (enemy == enemyBullet)
            {
                enemy.Img = global::Fall2020_CSC403_Project.Properties.Resources.bullet_left;
            }
            if (enemy == bossSolomon)
            {
                enemy.Img = picBossSolomon.Image;
            }
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();
            Console.WriteLine(enemy);

            if (enemy == bossSolomon)
            {
                frmBattle.SetupForBossBattle(2);
            }
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
                        picEnemyBullet.Image = global::Fall2020_CSC403_Project.Properties.Resources.bullet_right;
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
                        picEnemyBullet.Image = global::Fall2020_CSC403_Project.Properties.Resources.bullet_left;
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

                }
                else if (enemy.Name.Equals("Bullet"))
                {
                    Dictionary<string, float> enemyPos = new Dictionary<string, float>();
                    enemyPos.Add("x", enemy.Position.x);
                    enemyPos.Add("y", enemy.Position.y);
                    SaveModel.CheetoPosition = enemyPos;
                    SaveModel.CheetoMoveDirection = enemy.MovingDirection;

                }
                else if (enemy.Name.Equals("PoisonPacket"))
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

                }
                else if (enemy.Name.Equals("Cheeto"))
                {
                    Dictionary<string, float> enemyPos = new Dictionary<string, float>();
                    enemyPos.Add("x", enemy.Position.x);
                    enemyPos.Add("y", enemy.Position.y);
                    SaveModel.CheetoPosition = enemyPos;
                    SaveModel.CheetoMoveDirection = enemy.MovingDirection;

                }
                else if (enemy.Name.Equals("PoisonPacket"))
                {
                    Dictionary<string, float> enemyPos = new Dictionary<string, float>();
                    enemyPos.Add("x", enemy.Position.x);
                    enemyPos.Add("y", enemy.Position.y);
                    SaveModel.PoisonPacketPosition = enemyPos;
                    SaveModel.PoisonPacketMoveDirection = enemy.MovingDirection;
                }

            }
        }
    }
}
