﻿namespace Crypton1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDES = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnXXX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(399, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 61);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Teal;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 2;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(802, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 33);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(853, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRYPTO";
            // 
            // btnDES
            // 
            this.btnDES.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDES.FlatAppearance.BorderSize = 2;
            this.btnDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDES.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDES.Location = new System.Drawing.Point(52, 193);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(161, 131);
            this.btnDES.TabIndex = 2;
            this.btnDES.Text = "DES";
            this.btnDES.UseVisualStyleBackColor = false;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRSA.FlatAppearance.BorderSize = 2;
            this.btnRSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSA.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRSA.Location = new System.Drawing.Point(378, 193);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(161, 131);
            this.btnRSA.TabIndex = 2;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = false;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnXXX
            // 
            this.btnXXX.BackColor = System.Drawing.Color.MediumPurple;
            this.btnXXX.FlatAppearance.BorderSize = 2;
            this.btnXXX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXX.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXXX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXXX.Location = new System.Drawing.Point(701, 193);
            this.btnXXX.Name = "btnXXX";
            this.btnXXX.Size = new System.Drawing.Size(161, 131);
            this.btnXXX.TabIndex = 2;
            this.btnXXX.Text = "XXX";
            this.btnXXX.UseVisualStyleBackColor = false;
            this.btnXXX.Click += new System.EventHandler(this.btnXXX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 530);
            this.Controls.Add(this.btnXXX);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnXXX;
    }
}

