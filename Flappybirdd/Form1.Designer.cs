
namespace Flappybirdd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipebot = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pipebot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pipebot
            // 
            this.pipebot.Image = ((System.Drawing.Image)(resources.GetObject("pipebot.Image")));
            this.pipebot.Location = new System.Drawing.Point(346, 508);
            this.pipebot.Name = "pipebot";
            this.pipebot.Size = new System.Drawing.Size(137, 142);
            this.pipebot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebot.TabIndex = 0;
            this.pipebot.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = ((System.Drawing.Image)(resources.GetObject("pipetop.Image")));
            this.pipetop.Location = new System.Drawing.Point(346, -1);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(130, 188);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-9, 646);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(521, 62);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(59, 298);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(131, 98);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Aqua;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(23, 30);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(191, 63);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playagain
            // 
            this.playagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagain.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playagain.Location = new System.Drawing.Point(184, 285);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(184, 128);
            this.playagain.TabIndex = 5;
            this.playagain.Text = "Play AGAIN!";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Visible = false;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(507, 707);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipebot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipebot;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playagain;
    }
}

