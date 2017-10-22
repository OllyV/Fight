namespace Fight
{
    partial class FRMfight
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
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.BTNnew = new System.Windows.Forms.Button();
            this.LBplayerHP = new System.Windows.Forms.Label();
            this.LBcompHP = new System.Windows.Forms.Label();
            this.lSTlog = new System.Windows.Forms.ListBox();
            this.PBplayer = new System.Windows.Forms.ProgressBar();
            this.PBcomp = new System.Windows.Forms.ProgressBar();
            this.TBname = new System.Windows.Forms.TextBox();
            this.LBname = new System.Windows.Forms.Label();
            this.BTNturn = new System.Windows.Forms.Button();
            this.LBplayer = new System.Windows.Forms.Label();
            this.LBcomp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB1.Location = new System.Drawing.Point(64, 316);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(74, 28);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "Head";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB2.Location = new System.Drawing.Point(242, 316);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(76, 28);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "Chest";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB3.Location = new System.Drawing.Point(442, 316);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(69, 28);
            this.RB3.TabIndex = 2;
            this.RB3.TabStop = true;
            this.RB3.Text = "Legs";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // BTNnew
            // 
            this.BTNnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNnew.Location = new System.Drawing.Point(140, 398);
            this.BTNnew.Name = "BTNnew";
            this.BTNnew.Size = new System.Drawing.Size(287, 51);
            this.BTNnew.TabIndex = 3;
            this.BTNnew.Text = "New game";
            this.BTNnew.UseVisualStyleBackColor = true;
            this.BTNnew.Click += new System.EventHandler(this.BTNnew_Click);
            // 
            // LBplayerHP
            // 
            this.LBplayerHP.AutoSize = true;
            this.LBplayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBplayerHP.Location = new System.Drawing.Point(147, 24);
            this.LBplayerHP.Name = "LBplayerHP";
            this.LBplayerHP.Size = new System.Drawing.Size(52, 24);
            this.LBplayerHP.TabIndex = 4;
            this.LBplayerHP.Text = "Fight";
            // 
            // LBcompHP
            // 
            this.LBcompHP.AutoSize = true;
            this.LBcompHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBcompHP.Location = new System.Drawing.Point(503, 24);
            this.LBcompHP.Name = "LBcompHP";
            this.LBcompHP.Size = new System.Drawing.Size(52, 24);
            this.LBcompHP.TabIndex = 5;
            this.LBcompHP.Text = "Fight";
            // 
            // lSTlog
            // 
            this.lSTlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSTlog.FormattingEnabled = true;
            this.lSTlog.ItemHeight = 16;
            this.lSTlog.Location = new System.Drawing.Point(12, 112);
            this.lSTlog.Name = "lSTlog";
            this.lSTlog.Size = new System.Drawing.Size(564, 180);
            this.lSTlog.TabIndex = 6;
            // 
            // PBplayer
            // 
            this.PBplayer.Location = new System.Drawing.Point(30, 65);
            this.PBplayer.Name = "PBplayer";
            this.PBplayer.Size = new System.Drawing.Size(204, 28);
            this.PBplayer.TabIndex = 7;
            // 
            // PBcomp
            // 
            this.PBcomp.Location = new System.Drawing.Point(359, 65);
            this.PBcomp.Name = "PBcomp";
            this.PBcomp.Size = new System.Drawing.Size(204, 28);
            this.PBcomp.TabIndex = 8;
            // 
            // TBname
            // 
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBname.Location = new System.Drawing.Point(187, 363);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(344, 29);
            this.TBname.TabIndex = 9;
            this.TBname.Text = "Player1";
            // 
            // LBname
            // 
            this.LBname.AutoSize = true;
            this.LBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBname.Location = new System.Drawing.Point(60, 366);
            this.LBname.Name = "LBname";
            this.LBname.Size = new System.Drawing.Size(109, 24);
            this.LBname.TabIndex = 10;
            this.LBname.Text = "Input name:";
            // 
            // BTNturn
            // 
            this.BTNturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNturn.Location = new System.Drawing.Point(140, 363);
            this.BTNturn.Name = "BTNturn";
            this.BTNturn.Size = new System.Drawing.Size(287, 86);
            this.BTNturn.TabIndex = 11;
            this.BTNturn.UseVisualStyleBackColor = true;
            this.BTNturn.Visible = false;
            this.BTNturn.Click += new System.EventHandler(this.BTNturn_Click);
            // 
            // LBplayer
            // 
            this.LBplayer.AutoSize = true;
            this.LBplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBplayer.Location = new System.Drawing.Point(12, 24);
            this.LBplayer.Name = "LBplayer";
            this.LBplayer.Size = new System.Drawing.Size(72, 24);
            this.LBplayer.TabIndex = 12;
            this.LBplayer.Text = "Player1";
            // 
            // LBcomp
            // 
            this.LBcomp.AutoSize = true;
            this.LBcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBcomp.Location = new System.Drawing.Point(355, 24);
            this.LBcomp.Name = "LBcomp";
            this.LBcomp.Size = new System.Drawing.Size(72, 24);
            this.LBcomp.TabIndex = 13;
            this.LBcomp.Text = "Player2";
            // 
            // FRMfight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 461);
            this.Controls.Add(this.LBcomp);
            this.Controls.Add(this.LBplayer);
            this.Controls.Add(this.BTNturn);
            this.Controls.Add(this.LBname);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.PBcomp);
            this.Controls.Add(this.PBplayer);
            this.Controls.Add(this.lSTlog);
            this.Controls.Add(this.LBcompHP);
            this.Controls.Add(this.LBplayerHP);
            this.Controls.Add(this.BTNnew);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Name = "FRMfight";
            this.Text = "Fight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.Button BTNnew;
        private System.Windows.Forms.Label LBplayerHP;
        private System.Windows.Forms.Label LBcompHP;
        private System.Windows.Forms.ListBox lSTlog;
        private System.Windows.Forms.ProgressBar PBplayer;
        private System.Windows.Forms.ProgressBar PBcomp;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label LBname;
        private System.Windows.Forms.Button BTNturn;
        private System.Windows.Forms.Label LBplayer;
        private System.Windows.Forms.Label LBcomp;
    }
}

