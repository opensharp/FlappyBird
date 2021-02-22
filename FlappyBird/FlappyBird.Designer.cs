namespace FlappyBird
{
    partial class FlappyBird
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BirdBox = new System.Windows.Forms.PictureBox();
            this.PillarBox2 = new System.Windows.Forms.PictureBox();
            this.PillarBox1 = new System.Windows.Forms.PictureBox();
            this.GrassBox = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Moving = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BirdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PillarBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PillarBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BirdBox
            // 
            this.BirdBox.BackColor = System.Drawing.Color.Transparent;
            this.BirdBox.Image = global::FlappyBird.Properties.Resources.Bird;
            this.BirdBox.Location = new System.Drawing.Point(60, 120);
            this.BirdBox.Name = "BirdBox";
            this.BirdBox.Size = new System.Drawing.Size(45, 32);
            this.BirdBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BirdBox.TabIndex = 0;
            this.BirdBox.TabStop = false;
            // 
            // PillarBox2
            // 
            this.PillarBox2.BackColor = System.Drawing.Color.Transparent;
            this.PillarBox2.Image = global::FlappyBird.Properties.Resources.Pillar2;
            this.PillarBox2.Location = new System.Drawing.Point(240, 190);
            this.PillarBox2.Name = "PillarBox2";
            this.PillarBox2.Size = new System.Drawing.Size(70, 250);
            this.PillarBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PillarBox2.TabIndex = 1;
            this.PillarBox2.TabStop = false;
            // 
            // PillarBox1
            // 
            this.PillarBox1.BackColor = System.Drawing.Color.Transparent;
            this.PillarBox1.Image = global::FlappyBird.Properties.Resources.Pillar1;
            this.PillarBox1.Location = new System.Drawing.Point(240, -190);
            this.PillarBox1.Name = "PillarBox1";
            this.PillarBox1.Size = new System.Drawing.Size(70, 250);
            this.PillarBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PillarBox1.TabIndex = 2;
            this.PillarBox1.TabStop = false;
            // 
            // GrassBox
            // 
            this.GrassBox.BackColor = System.Drawing.Color.Transparent;
            this.GrassBox.Image = global::FlappyBird.Properties.Resources.Grass;
            this.GrassBox.Location = new System.Drawing.Point(0, 399);
            this.GrassBox.Name = "GrassBox";
            this.GrassBox.Size = new System.Drawing.Size(384, 49);
            this.GrassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GrassBox.TabIndex = 3;
            this.GrassBox.TabStop = false;
            // 
            // Clock
            // 
            this.Clock.Interval = 12;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Moving
            // 
            this.Moving.Interval = 15;
            this.Moving.Tick += new System.EventHandler(this.Moving_Tick);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 448);
            this.Controls.Add(this.GrassBox);
            this.Controls.Add(this.PillarBox1);
            this.Controls.Add(this.PillarBox2);
            this.Controls.Add(this.BirdBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird   【按空格键开始游戏】   分数：0";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FlappyBird_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.BirdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PillarBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PillarBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BirdBox;
        private System.Windows.Forms.PictureBox PillarBox2;
        private System.Windows.Forms.PictureBox PillarBox1;
        private System.Windows.Forms.PictureBox GrassBox;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Timer Moving;
    }
}

