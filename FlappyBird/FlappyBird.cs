using System;
using System.Media;
using System.Windows.Forms;
namespace FlappyBird
{
    public partial class FlappyBird : Form
    {
        int UpTime = 0, Score = 0, Offset = 0, Count = 0;
        bool Dead = false;
        public FlappyBird()
        {
            InitializeComponent();
            Offset = new Random(Guid.NewGuid().GetHashCode()).Next(5, 135);
            PillarBox1.Top = -190 + Offset;
            PillarBox2.Top = 190 + Offset;
        }
        private void FlappyBird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Dead)
            {
                if (e.KeyChar == 13)
                {
                    Application.Restart();
                }
            }
            else
            {
                if (e.KeyChar == 32)
                {
                    if (!Clock.Enabled)
                    {
                        Clock.Enabled = true;
                        Moving.Enabled = true;
                    }
                    else
                    {
                        UpTime = 12;
                        if (Count == 0)
                        {
                            new SoundPlayer(Properties.Resources.Wing).Play();
                        }
                    }
                }
            }
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            Text = "FlappyBird   【当前游戏正在运行】   分数：" + Score.ToString();
            if (UpTime == 0)
            {
                if (BirdBox.Top < 364)
                {
                    BirdBox.Top += 3;
                }
            }
            else
            {
                if (BirdBox.Top - UpTime < 3)
                {
                    UpTime = 0;
                    BirdBox.Top = 3;
                }
                else
                {
                    UpTime--;
                    BirdBox.Top -= UpTime;
                }
            }
        }
        private void Moving_Tick(object sender, EventArgs e)
        {
            if (Count != 0)
            {
                Count--;
            }
            if (PillarBox1.Left < -80)
            {
                Score++;
                Count = 25;
                new SoundPlayer(Properties.Resources.Point).Play();
                Offset = new Random(Guid.NewGuid().GetHashCode()).Next(5, 135);
                PillarBox1.Top = -190 + Offset;
                PillarBox2.Top = 190 + Offset;
                PillarBox1.Left = 400;
                PillarBox2.Left = 400;
            }
            else
            {
                PillarBox1.Left -= 2;
                PillarBox2.Left -= 2;
            }
            if ((BirdBox.Top < 5) || (BirdBox.Top > 365))
            {
                Clock.Enabled = false;
                Moving.Enabled = false;
                Count = 25;
                new SoundPlayer(Properties.Resources.Hit).Play();
                Text = "FlappyBird   【按回车键重新开始】   分数：" + Score.ToString();
                Dead = true;
                return;
            }
            if ((PillarBox1.Left > -10) && (PillarBox1.Left < 102))
            {
                if ((BirdBox.Top > (155 + Offset)) || (BirdBox.Top < (60 + Offset)))
                {
                    Clock.Enabled = false;
                    Moving.Enabled = false;
                    Count = 25;
                    new SoundPlayer(Properties.Resources.Hit).Play();
                    Text = "FlappyBird   【按回车键重新开始】   分数：" + Score.ToString();
                    Dead = true;
                    return;
                }
            }
        }
    }
}