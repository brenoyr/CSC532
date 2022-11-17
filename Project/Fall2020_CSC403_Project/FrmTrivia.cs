using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections;
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
    public partial class FrmTrivia : Form
    {
        Label ans1;
        Label ans2;
        Label ans3;
        Label ans4;
        Label realAns;
        Label nextBtnRef;
        TextBox question;
        PictureBox pic;
        int questionIndex = 0;

        Dictionary<string, string> question1;
        Dictionary<string, string> question2;
        Dictionary<string, string> question3;
        Dictionary<string, string> question4;
        Dictionary<string, string> question5;

        Dictionary<string, string>[] questionArr;

        public FrmTrivia()
        {
            InitializeComponent();
        }

        private void FrmTrivia_Load(object sender, EventArgs e)
        {
            ans1 = Controls.Find("ansBox1", true)[0] as Label;
            ans2 = Controls.Find("ansBox2", true)[0] as Label;
            ans3 = Controls.Find("ansBox3", true)[0] as Label;
            ans4 = Controls.Find("ansBox4", true)[0] as Label;
            realAns = Controls.Find("realAnsBox", true)[0] as Label;
            nextBtnRef = Controls.Find("nextBtn", true)[0] as Label;
            question = Controls.Find("questionBox", true)[0] as TextBox;
            pic = Controls.Find("pictureBox1", true)[0] as PictureBox;

            question1 = new Dictionary<string, string>(){
                {"question", "What year was Mr.Peanut born?"},
                {"a1", "1916"},
                {"a2", "1889"},
                {"a3", "1934"},
                {"a4", "2000"},
                {"realAns", "1916"},
                {"pic", "mrPeanut"}
            };

            question2 = new Dictionary<string, string>(){
                {"question", "What year was the Kool-Aid Man created?"},
                {"a1", "1946"},
                {"a2", "1924"},
                {"a3", "1954"},
                {"a4", "1990"},
                {"realAns", "1954"},
                {"pic", "koolAid"}
            };

            question3 = new Dictionary<string, string>(){
                {"question", "What is the name of this character?"},
                {"a1", "Black Dart"},
                {"a2", "Bullet Bill"},
                {"a3", "Rocket Man"},
                {"a4", "Dave"},
                {"realAns", "Bullet Bill"},
                {"pic", "bulletBill"}
            };

            question4 = new Dictionary<string, string>(){
                {"question", "What is the name of this developer?"},
                {"a1", "Sebastian"},
                {"a2", "Sheldon"},
                {"a3", "Simon"},
                {"a4", "Solomon"},
                {"realAns", "Solomon"},
                {"pic", "solomon"}
            };

            question5 = new Dictionary<string, string>(){
                {"question", "What year did Mr.Peanut die?"},
                {"a1", "2020"},
                {"a2", "2000"},
                {"a3", "1999"},
                {"a4", "2012"},
                {"realAns", "2020"},
                {"pic", "mrPeanutDead"}
            };

            questionArr = new Dictionary<string, string>[5];
            questionArr[0] = question1;
            questionArr[1] = question2;
            questionArr[2] = question3;
            questionArr[3] = question4;
            questionArr[4] = question5;


            nextBtnRef.Hide();
            nextBtnRef.Enabled = false;
            realAns.Hide();

            setQuestion(question1);
        }

        public void setQuestion(Dictionary<string, string> currQ)
        {
            question.Text = currQ["question"];
            ans1.Text = currQ["a1"];
            ans2.Text = currQ["a2"];
            ans3.Text = currQ["a3"];
            ans4.Text = currQ["a4"];

            if (currQ["pic"] == "mrPeanut")
            {
                pic.Image = Resources.player;
            }
            else if (currQ["pic"] == "koolAid")
            {
                pic.Image = Resources.enemy_koolaid;
            }
            else if (currQ["pic"] == "bulletBill")
            {
                pic.Image = Resources.bullet_left;
            }
            else if (currQ["pic"] == "solomon")
            {
                pic.Image = Resources.enemy_solomon;
            }
            else if (currQ["pic"] == "mrPeanutDead")
            {
                pic.Image = Resources.dead;
            }

        }

        private void ansBox1_Click(object sender, EventArgs e)
        {
            ans1.Enabled = false;
            ans2.Enabled = false;
            ans3.Enabled = false;
            ans4.Enabled = false;

            if (ans1.Text == questionArr[questionIndex]["realAns"])
            {
                realAns.Text = "Correct";
            }
            else
            {
                realAns.Text = "Incorrect, the correct answer is " + questionArr[questionIndex]["realAns"];
            }

            realAns.Show();
            if (questionIndex < questionArr.Length - 1)
            {
                nextBtnRef.Show();
                nextBtnRef.Enabled = true;
            }
        }

        private void ansBox2_Click(object sender, EventArgs e)
        {
            ans1.Enabled = false;
            ans2.Enabled = false;
            ans3.Enabled = false;
            ans4.Enabled = false;

            if (ans2.Text == questionArr[questionIndex]["realAns"])
            {
                realAns.Text = "Correct";
            }
            else
            {
                realAns.Text = "Incorrect, the correct answer is " + questionArr[questionIndex]["realAns"];
            }

            realAns.Show();
            if (questionIndex < questionArr.Length - 1)
            {
                nextBtnRef.Show();
                nextBtnRef.Enabled = true;
            }
        }

        private void ansBox3_Click(object sender, EventArgs e)
        {
            ans1.Enabled = false;
            ans2.Enabled = false;
            ans3.Enabled = false;
            ans4.Enabled = false;

            if (ans3.Text == questionArr[questionIndex]["realAns"])
            {
                realAns.Text = "Correct";
            }
            else
            {
                realAns.Text = "Incorrect, the correct answer is " + questionArr[questionIndex]["realAns"];
            }

            realAns.Show();
            if (questionIndex < questionArr.Length - 1)
            {
                nextBtnRef.Show();
                nextBtnRef.Enabled = true;
            }
        }

        private void ansBox4_Click(object sender, EventArgs e)
        {
            ans1.Enabled = false;
            ans2.Enabled = false;
            ans3.Enabled = false;
            ans4.Enabled = false;

            if (ans4.Text == questionArr[questionIndex]["realAns"])
            {
                realAns.Text = "Correct";
            }
            else
            {
                realAns.Text = "Incorrect, the correct answer is " + questionArr[questionIndex]["realAns"];
            }

            realAns.Show();
            if (questionIndex < questionArr.Length - 1)
            {
                nextBtnRef.Show();
                nextBtnRef.Enabled = true;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ans1.Enabled = true;
            ans2.Enabled = true;
            ans3.Enabled = true;
            ans4.Enabled = true;

            nextBtnRef.Hide();
            nextBtnRef.Enabled = false;
            realAns.Hide();

            questionIndex++;
            setQuestion(questionArr[questionIndex]);
        }
    }
}
