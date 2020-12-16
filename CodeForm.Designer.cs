namespace CompleteAssement1
{
    partial class CodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeForm));
            this.LongDistanceShooting = new System.Windows.Forms.Button();
            this.ReloadMagButton = new System.Windows.Forms.Button();
            this.SwipegunBtn = new System.Windows.Forms.Button();
            this.BulletShootingBtn = new System.Windows.Forms.Button();
            this.RetryBtn = new System.Windows.Forms.Button();
            this.GameView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameView)).BeginInit();
            this.SuspendLayout();
            // 
            // LongDistanceShooting
            // 
            this.LongDistanceShooting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LongDistanceShooting.ForeColor = System.Drawing.Color.Maroon;
            this.LongDistanceShooting.Location = new System.Drawing.Point(195, 199);
            this.LongDistanceShooting.Margin = new System.Windows.Forms.Padding(2);
            this.LongDistanceShooting.Name = "LongDistanceShooting";
            this.LongDistanceShooting.Size = new System.Drawing.Size(121, 63);
            this.LongDistanceShooting.TabIndex = 2;
            this.LongDistanceShooting.Text = "Long Shoot";
            this.LongDistanceShooting.UseVisualStyleBackColor = false;
            this.LongDistanceShooting.Click += new System.EventHandler(this.LongDistanceShooting_Click);
            // 
            // ReloadMagButton
            // 
            this.ReloadMagButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReloadMagButton.ForeColor = System.Drawing.Color.Maroon;
            this.ReloadMagButton.Location = new System.Drawing.Point(96, 228);
            this.ReloadMagButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReloadMagButton.Name = "ReloadMagButton";
            this.ReloadMagButton.Size = new System.Drawing.Size(81, 34);
            this.ReloadMagButton.TabIndex = 5;
            this.ReloadMagButton.Text = "Reload Mag";
            this.ReloadMagButton.UseVisualStyleBackColor = false;
            this.ReloadMagButton.Click += new System.EventHandler(this.ReloadMagButton_Click);
            // 
            // SwipegunBtn
            // 
            this.SwipegunBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SwipegunBtn.ForeColor = System.Drawing.Color.Maroon;
            this.SwipegunBtn.Location = new System.Drawing.Point(96, 199);
            this.SwipegunBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SwipegunBtn.Name = "SwipegunBtn";
            this.SwipegunBtn.Size = new System.Drawing.Size(81, 35);
            this.SwipegunBtn.TabIndex = 6;
            this.SwipegunBtn.Text = "Swipe Gun";
            this.SwipegunBtn.UseVisualStyleBackColor = false;
            this.SwipegunBtn.Click += new System.EventHandler(this.SwipegunBtn_Click);
            // 
            // BulletShootingBtn
            // 
            this.BulletShootingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BulletShootingBtn.ForeColor = System.Drawing.Color.Maroon;
            this.BulletShootingBtn.Location = new System.Drawing.Point(8, 228);
            this.BulletShootingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BulletShootingBtn.Name = "BulletShootingBtn";
            this.BulletShootingBtn.Size = new System.Drawing.Size(74, 34);
            this.BulletShootingBtn.TabIndex = 1;
            this.BulletShootingBtn.Text = "Bullet Shoot";
            this.BulletShootingBtn.UseVisualStyleBackColor = false;
            this.BulletShootingBtn.Click += new System.EventHandler(this.GunShootBt_Click);
            // 
            // RetryBtn
            // 
            this.RetryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RetryBtn.ForeColor = System.Drawing.Color.Maroon;
            this.RetryBtn.Location = new System.Drawing.Point(8, 199);
            this.RetryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RetryBtn.Name = "RetryBtn";
            this.RetryBtn.Size = new System.Drawing.Size(74, 35);
            this.RetryBtn.TabIndex = 7;
            this.RetryBtn.Text = "Retry";
            this.RetryBtn.UseVisualStyleBackColor = false;
            this.RetryBtn.Click += new System.EventHandler(this.RetryBtn_Click);
            // 
            // GameView
            // 
            this.GameView.Image = ((System.Drawing.Image)(resources.GetObject("GameView.Image")));
            this.GameView.Location = new System.Drawing.Point(-11, -8);
            this.GameView.Margin = new System.Windows.Forms.Padding(2);
            this.GameView.Name = "GameView";
            this.GameView.Size = new System.Drawing.Size(636, 299);
            this.GameView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameView.TabIndex = 0;
            this.GameView.TabStop = false;
            this.GameView.Click += new System.EventHandler(this.GameView_Click);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 292);
            this.Controls.Add(this.RetryBtn);
            this.Controls.Add(this.SwipegunBtn);
            this.Controls.Add(this.ReloadMagButton);
            this.Controls.Add(this.LongDistanceShooting);
            this.Controls.Add(this.BulletShootingBtn);
            this.Controls.Add(this.GameView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CodeForm";
            this.Text = " CodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.GameView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameView;
        private System.Windows.Forms.Button BulletShootingBtn;
        private System.Windows.Forms.Button LongDistanceShooting;
        private System.Windows.Forms.Button ReloadMagButton;
        private System.Windows.Forms.Button SwipegunBtn;
        private System.Windows.Forms.Button RetryBtn;
    }
}

