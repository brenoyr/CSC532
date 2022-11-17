using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using MyGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmMaze : Form
    {
        private Player player;
        private Character[] walls;
        Character finishBoxChar;
        public FrmMaze()
        {
            InitializeComponent();
        }

        private void FrmMaze_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 46;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("pictureBox" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Label lbl = Controls.Find("finishBox", true)[0] as Label;
            finishBoxChar = new Character(CreatePositionLbl(lbl), CreateColliderLbl(lbl, PADDING));
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

        private Vector2 CreatePositionLbl(Label pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateColliderLbl(Label pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
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
            
            if (HitFinishBox(player, finishBoxChar))
            {
                this.Close();
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
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

        private bool HitFinishBox(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void FrmMaze_KeyDown(object sender, KeyEventArgs e)
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

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void FrmMaze_KeyUp(object sender, KeyEventArgs e)
        {
            if (player.face_direction == "front")
                picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_front;
            else
                picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_back;

            player.move_direction = "still";
            player.ResetMoveSpeed();
        }
    }
}
