namespace Shot_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Photo = new System.Windows.Forms.PictureBox();
            this.btnLoading = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnBullets = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(204, 60);
            this.Photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(654, 308);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // btnLoading
            // 
            this.btnLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoading.BackgroundImage")));
            this.btnLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoading.Location = new System.Drawing.Point(204, 395);
            this.btnLoading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(304, 117);
            this.btnLoading.TabIndex = 1;
            this.btnLoading.Text = "Loading";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Black;
            this.btnSpin.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.Yellow;
            this.btnSpin.Location = new System.Drawing.Point(29, 522);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(321, 117);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnBullets
            // 
            this.btnBullets.BackColor = System.Drawing.Color.Black;
            this.btnBullets.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBullets.ForeColor = System.Drawing.Color.Yellow;
            this.btnBullets.Location = new System.Drawing.Point(518, 395);
            this.btnBullets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBullets.Name = "btnBullets";
            this.btnBullets.Size = new System.Drawing.Size(321, 117);
            this.btnBullets.TabIndex = 3;
            this.btnBullets.Text = "Load Bullet";
            this.btnBullets.UseVisualStyleBackColor = false;
            this.btnBullets.Click += new System.EventHandler(this.btnBullets_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Black;
            this.btnFire.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.Yellow;
            this.btnFire.Location = new System.Drawing.Point(412, 522);
            this.btnFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(321, 117);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(795, 522);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 117);
            this.button1.TabIndex = 5;
            this.button1.Text = "Shoot Away";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(909, 60);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Try Again";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnBullets);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.Photo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnBullets;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

