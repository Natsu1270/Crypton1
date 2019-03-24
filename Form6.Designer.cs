namespace Crypton1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mKey = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.eKey = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.Black;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(134, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(344, 35);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Generate Key Successfully !";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(344, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(47, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "M";
            // 
            // mKey
            // 
            this.mKey.AcceptsReturn = false;
            this.mKey.AcceptsTab = false;
            this.mKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mKey.BackColor = System.Drawing.Color.White;
            this.mKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mKey.BackgroundImage")));
            this.mKey.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.mKey.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.mKey.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.mKey.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.mKey.BorderRadius = 5;
            this.mKey.BorderThickness = 2;
            this.mKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mKey.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKey.DefaultText = "";
            this.mKey.FillColor = System.Drawing.Color.White;
            this.mKey.HideSelection = true;
            this.mKey.IconLeft = null;
            this.mKey.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.mKey.IconPadding = 10;
            this.mKey.IconRight = null;
            this.mKey.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.mKey.Location = new System.Drawing.Point(52, 168);
            this.mKey.MaxLength = 32767;
            this.mKey.MinimumSize = new System.Drawing.Size(100, 35);
            this.mKey.Modified = false;
            this.mKey.Name = "mKey";
            this.mKey.PasswordChar = '\0';
            this.mKey.ReadOnly = false;
            this.mKey.SelectedText = "";
            this.mKey.SelectionLength = 0;
            this.mKey.SelectionStart = 0;
            this.mKey.ShortcutsEnabled = true;
            this.mKey.Size = new System.Drawing.Size(200, 152);
            this.mKey.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.mKey.TabIndex = 4;
            this.mKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mKey.TextMarginLeft = 5;
            this.mKey.TextPlaceholder = "";
            this.mKey.UseSystemPasswordChar = false;
            // 
            // eKey
            // 
            this.eKey.AcceptsReturn = false;
            this.eKey.AcceptsTab = false;
            this.eKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.eKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.eKey.BackColor = System.Drawing.Color.White;
            this.eKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eKey.BackgroundImage")));
            this.eKey.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.eKey.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.eKey.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.eKey.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.eKey.BorderRadius = 5;
            this.eKey.BorderThickness = 2;
            this.eKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.eKey.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eKey.DefaultText = "";
            this.eKey.FillColor = System.Drawing.Color.White;
            this.eKey.HideSelection = true;
            this.eKey.IconLeft = null;
            this.eKey.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.eKey.IconPadding = 10;
            this.eKey.IconRight = null;
            this.eKey.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.eKey.Location = new System.Drawing.Point(349, 168);
            this.eKey.MaxLength = 32767;
            this.eKey.MinimumSize = new System.Drawing.Size(100, 35);
            this.eKey.Modified = false;
            this.eKey.Name = "eKey";
            this.eKey.PasswordChar = '\0';
            this.eKey.ReadOnly = false;
            this.eKey.SelectedText = "";
            this.eKey.SelectionLength = 0;
            this.eKey.SelectionStart = 0;
            this.eKey.ShortcutsEnabled = true;
            this.eKey.Size = new System.Drawing.Size(200, 152);
            this.eKey.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.eKey.TabIndex = 4;
            this.eKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eKey.TextMarginLeft = 5;
            this.eKey.TextPlaceholder = "";
            this.eKey.UseSystemPasswordChar = false;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Close";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(207, 332);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.Size = new System.Drawing.Size(164, 45);
            this.bunifuButton1.TabIndex = 5;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 389);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.eKey);
            this.Controls.Add(this.mKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox mKey;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox eKey;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}