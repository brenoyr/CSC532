﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary.Models;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Net.Sockets;
using System.ComponentModel;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattlePvP : Form {
    public FrmBattlePvP instance = null;
    private Player player2;
    private Player player;
    private FrmDeath frmDeath;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener listener;
        private TcpClient client;
        private bool isHost;
        private string ip;


        public FrmBattlePvP(bool isHost, string ip)
        {
            this.isHost = isHost;
            this.ip = ip;

            InitializeComponent();
            
            MessageReceiver.DoWork += MessageReceiver_DoWork;

            CheckForIllegalCrossThreadCalls = false;
            if(isHost)
            {
                this.player = Game.player;
                this.player2 = Game.player2;
                listener = new TcpListener(System.Net.IPAddress.Any, 5732);
                listener.Start();
                Console.WriteLine("Host");
                
                sock = listener.AcceptSocket();

            }
            else
            {
                this.player = Game.player2;
                this.player2 = Game.player;
                client = new TcpClient(ip, 5732);
                sock = client.Client;
                MessageReceiver.RunWorkerAsync();

            }
            this.Setup();
        }

    private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
    {
            freeze_screen();
            ReceiveAttack();
            unfreeze_screen();
            
        }

    public void Setup() {
      // update for this enemy

      // Observer pattern
      player2.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = player2.Health / (float)player2.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = player2.Health.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
            // player.OnAttack(-4);
            // if (player2.Health > 0) {
            //   player2.OnAttack(-2); //-2
            // }
            sock.Send(System.Text.Encoding.ASCII.GetBytes("attack"));

      // UpdateHealthBars();
      // if (player.Health <= 0) {
      //   ShowDeathMenu(); // show game over screen
      //   instance = null;
      //   Close();
      //   SoundPlayer playerDieSound = new SoundPlayer(Resources.player_die);
      //   playerDieSound.PlaySync();
      // }
      // else if (player2.Health <= 0) {
      //   // player.AlterExperience(player2.Type);
      //   instance = null;
      //   Close();
      //   SoundPlayer dieSound = new SoundPlayer(Resources.enemy_die);
      //   dieSound.PlaySync();
      // }
    }

    private void ShowDeathMenu()
    {
        frmDeath = new FrmDeath();
        // removes the options to minimize/resize/close the window so the user has to make a choice
        frmDeath.ControlBox = false;
        frmDeath.ShowDialog(); // ShowDialog() disables game window
    }

    private void EnemyDamage(int amount) {

            player2.AlterHealth(amount);
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
        
        private void freeze_screen()
        {
            
                btnAttack.Enabled = false;
                btnAttack.Visible = false;
                btnAttack.Text = "Waiting for other player...";
                btnAttack.Refresh();
            
        }
        private void unfreeze_screen()
        {
            

                btnAttack.Enabled = true;
                btnAttack.Visible = true;
                btnAttack.Text = "Attack";
                btnAttack.Refresh();

            
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }


        private void ReceiveAttack()
        {
            byte[] buffer = new byte[6];
            sock.Receive(buffer);
            // Get rid of extra chars in buffer
            
            string message = System.Text.Encoding.ASCII.GetString(buffer);
            
            Console.WriteLine(message)
                ;
            Random rand = new Random();
            if (message == "attack")
            {
                Console.WriteLine("Hereab");
                int damage = rand.Next(1, 6);
                player2.OnAttack(-damage);
                UpdateHealthBars();
                if (player2.Health <= 0)
                {
                    instance = null;
                    Close();
                    SoundPlayer dieSound = new SoundPlayer(Resources.enemy_die);
                    dieSound.PlaySync();
                }
            }

        }

    }
    
    
}
