
namespace YT_Tic_Tac_Toe
{
    partial class Tic_Tac_Toe
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
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.closeLbl = new System.Windows.Forms.Label();
            this.winLogs = new System.Windows.Forms.ListBox();
            this.switchPlayerTurnCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.AutoSize = true;
            this.playerTurnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLbl.Location = new System.Drawing.Point(85, 9);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(179, 31);
            this.playerTurnLbl.TabIndex = 0;
            this.playerTurnLbl.Text = "Player X Turn";
            // 
            // a1
            // 
            this.a1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(60, 77);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a2
            // 
            this.a2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(141, 77);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // a3
            // 
            this.a3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(222, 77);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // b3
            // 
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(222, 158);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(141, 158);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(60, 158);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 4;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // c3
            // 
            this.c3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(222, 239);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.c3_Click);
            // 
            // c2
            // 
            this.c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(141, 239);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 8;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // c1
            // 
            this.c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(60, 239);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 7;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // closeLbl
            // 
            this.closeLbl.AutoSize = true;
            this.closeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLbl.Location = new System.Drawing.Point(327, 5);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(32, 31);
            this.closeLbl.TabIndex = 10;
            this.closeLbl.Text = "X";
            this.closeLbl.Click += new System.EventHandler(this.closeLbl_Click);
            // 
            // winLogs
            // 
            this.winLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.winLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winLogs.FormattingEnabled = true;
            this.winLogs.Location = new System.Drawing.Point(10, 341);
            this.winLogs.Name = "winLogs";
            this.winLogs.Size = new System.Drawing.Size(342, 195);
            this.winLogs.TabIndex = 11;
            // 
            // switchPlayerTurnCB
            // 
            this.switchPlayerTurnCB.AutoSize = true;
            this.switchPlayerTurnCB.Location = new System.Drawing.Point(141, 54);
            this.switchPlayerTurnCB.Name = "switchPlayerTurnCB";
            this.switchPlayerTurnCB.Size = new System.Drawing.Size(81, 17);
            this.switchPlayerTurnCB.TabIndex = 12;
            this.switchPlayerTurnCB.Text = "Start with O";
            this.switchPlayerTurnCB.UseVisualStyleBackColor = true;
            this.switchPlayerTurnCB.CheckedChanged += new System.EventHandler(this.switchPlayerTurnCB_CheckedChanged);
            // 
            // Tic_Tac_Toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(364, 552);
            this.Controls.Add(this.switchPlayerTurnCB);
            this.Controls.Add(this.winLogs);
            this.Controls.Add(this.closeLbl);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.playerTurnLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tic_Tac_Toe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic_Tac_Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerTurnLbl;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.ListBox winLogs;
        private System.Windows.Forms.CheckBox switchPlayerTurnCB;
    }
}