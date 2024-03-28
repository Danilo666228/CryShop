namespace CryShop.Windows.Main
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblBalanceUser = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMainControl = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarketControl = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfileControl = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangeAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1700, 43);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1655, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 43);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1610, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 43);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnChangeAccount);
            this.guna2Panel2.Controls.Add(this.btnProfileControl);
            this.guna2Panel2.Controls.Add(this.btnMarketControl);
            this.guna2Panel2.Controls.Add(this.btnMainControl);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 43);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(289, 757);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.lblBalanceUser);
            this.guna2Panel3.Controls.Add(this.lblNameUser);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(289, 100);
            this.guna2Panel3.TabIndex = 0;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameUser.Location = new System.Drawing.Point(99, 13);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(45, 25);
            this.lblNameUser.TabIndex = 0;
            this.lblNameUser.Text = "Имя";
            // 
            // lblBalanceUser
            // 
            this.lblBalanceUser.AutoSize = true;
            this.lblBalanceUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanceUser.Location = new System.Drawing.Point(99, 59);
            this.lblBalanceUser.Name = "lblBalanceUser";
            this.lblBalanceUser.Size = new System.Drawing.Size(78, 25);
            this.lblBalanceUser.TabIndex = 0;
            this.lblBalanceUser.Text = "Баланс";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnMainControl
            // 
            this.btnMainControl.Animated = true;
            this.btnMainControl.BorderRadius = 15;
            this.btnMainControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMainControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMainControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMainControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMainControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainControl.FillColor = System.Drawing.Color.Transparent;
            this.btnMainControl.Font = new System.Drawing.Font("JetBrains Mono", 15.75F);
            this.btnMainControl.ForeColor = System.Drawing.Color.White;
            this.btnMainControl.Location = new System.Drawing.Point(0, 100);
            this.btnMainControl.Name = "btnMainControl";
            this.btnMainControl.Size = new System.Drawing.Size(289, 86);
            this.btnMainControl.TabIndex = 1;
            this.btnMainControl.Text = "Главная";
            // 
            // btnMarketControl
            // 
            this.btnMarketControl.Animated = true;
            this.btnMarketControl.BorderRadius = 15;
            this.btnMarketControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarketControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarketControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarketControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarketControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarketControl.FillColor = System.Drawing.Color.Transparent;
            this.btnMarketControl.Font = new System.Drawing.Font("JetBrains Mono", 15.75F);
            this.btnMarketControl.ForeColor = System.Drawing.Color.White;
            this.btnMarketControl.Location = new System.Drawing.Point(0, 186);
            this.btnMarketControl.Name = "btnMarketControl";
            this.btnMarketControl.Size = new System.Drawing.Size(289, 86);
            this.btnMarketControl.TabIndex = 1;
            this.btnMarketControl.Text = "Рынок";
            // 
            // btnProfileControl
            // 
            this.btnProfileControl.Animated = true;
            this.btnProfileControl.BorderRadius = 15;
            this.btnProfileControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfileControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfileControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfileControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfileControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfileControl.FillColor = System.Drawing.Color.Transparent;
            this.btnProfileControl.Font = new System.Drawing.Font("JetBrains Mono", 15.75F);
            this.btnProfileControl.ForeColor = System.Drawing.Color.White;
            this.btnProfileControl.Location = new System.Drawing.Point(0, 272);
            this.btnProfileControl.Name = "btnProfileControl";
            this.btnProfileControl.Size = new System.Drawing.Size(289, 86);
            this.btnProfileControl.TabIndex = 1;
            this.btnProfileControl.Text = "Профиль";
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Animated = true;
            this.btnChangeAccount.BorderRadius = 15;
            this.btnChangeAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnChangeAccount.Font = new System.Drawing.Font("JetBrains Mono", 15.75F);
            this.btnChangeAccount.ForeColor = System.Drawing.Color.White;
            this.btnChangeAccount.Location = new System.Drawing.Point(0, 671);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(289, 86);
            this.btnChangeAccount.TabIndex = 1;
            this.btnChangeAccount.Text = "Сменить аккаунт";
            this.btnChangeAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1700, 800);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblBalanceUser;
        private System.Windows.Forms.Label lblNameUser;
        private Guna.UI2.WinForms.Guna2Button btnMainControl;
        private Guna.UI2.WinForms.Guna2Button btnChangeAccount;
        private Guna.UI2.WinForms.Guna2Button btnProfileControl;
        private Guna.UI2.WinForms.Guna2Button btnMarketControl;
    }
}