namespace AutoPingerRises.ChildForms
{
    partial class Converter
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
            this.iconButtonFrom = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check = new FontAwesome.Sharp.IconPictureBox();
            this.notCheck = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonFrom
            // 
            this.iconButtonFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonFrom.FlatAppearance.BorderSize = 0;
            this.iconButtonFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFrom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonFrom.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonFrom.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonFrom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonFrom.IconSize = 32;
            this.iconButtonFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonFrom.Location = new System.Drawing.Point(-1, -1);
            this.iconButtonFrom.Name = "iconButtonFrom";
            this.iconButtonFrom.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonFrom.Rotation = 0D;
            this.iconButtonFrom.Size = new System.Drawing.Size(855, 60);
            this.iconButtonFrom.TabIndex = 2;
            this.iconButtonFrom.Text = "Select log file";
            this.iconButtonFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFrom.UseVisualStyleBackColor = true;
            this.iconButtonFrom.Click += new System.EventHandler(this.iconButtonFrom_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(-1, 94);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(855, 60);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Select save path";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(0, 195);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(854, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check);
            this.panel1.Controls.Add(this.notCheck);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButtonFrom);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 445);
            this.panel1.TabIndex = 6;
            // 
            // check
            // 
            this.check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.ForeColor = System.Drawing.Color.Lime;
            this.check.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.check.IconColor = System.Drawing.Color.Lime;
            this.check.IconSize = 194;
            this.check.Location = new System.Drawing.Point(12, 238);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(234, 194);
            this.check.TabIndex = 6;
            this.check.TabStop = false;
            // 
            // notCheck
            // 
            this.notCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notCheck.BackColor = System.Drawing.Color.Transparent;
            this.notCheck.ForeColor = System.Drawing.Color.Red;
            this.notCheck.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.notCheck.IconColor = System.Drawing.Color.Red;
            this.notCheck.IconSize = 194;
            this.notCheck.Location = new System.Drawing.Point(611, 238);
            this.notCheck.Name = "notCheck";
            this.notCheck.Size = new System.Drawing.Size(234, 194);
            this.notCheck.TabIndex = 7;
            this.notCheck.TabStop = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(0, 385);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(856, 60);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.Text = "Start Converting";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(858, 445);
            this.Controls.Add(this.panel1);
            this.Name = "Converter";
            this.Text = "Convert";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonFrom;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconPictureBox check;
        private FontAwesome.Sharp.IconPictureBox notCheck;
    }
}