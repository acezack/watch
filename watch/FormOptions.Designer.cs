namespace watch
{
    partial class FormOptions
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
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelFontsize = new System.Windows.Forms.Label();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.buttonCloseSettings = new System.Windows.Forms.Button();
            this.buttonToggleBorder = new System.Windows.Forms.Button();
            this.buttonExitProgram = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(13, 13);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(37, 13);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "Color: ";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(77, 10);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 1;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // labelFontsize
            // 
            this.labelFontsize.AutoSize = true;
            this.labelFontsize.Location = new System.Drawing.Point(12, 40);
            this.labelFontsize.Name = "labelFontsize";
            this.labelFontsize.Size = new System.Drawing.Size(49, 13);
            this.labelFontsize.TabIndex = 2;
            this.labelFontsize.Text = "Fontsize:";
            // 
            // numericFontSize
            // 
            this.numericFontSize.Location = new System.Drawing.Point(77, 38);
            this.numericFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(121, 20);
            this.numericFontSize.TabIndex = 3;
            this.numericFontSize.ValueChanged += new System.EventHandler(this.numericFontSize_ValueChanged);
            // 
            // buttonCloseSettings
            // 
            this.buttonCloseSettings.Location = new System.Drawing.Point(110, 218);
            this.buttonCloseSettings.Name = "buttonCloseSettings";
            this.buttonCloseSettings.Size = new System.Drawing.Size(91, 32);
            this.buttonCloseSettings.TabIndex = 4;
            this.buttonCloseSettings.Text = "Close options";
            this.buttonCloseSettings.UseVisualStyleBackColor = true;
            this.buttonCloseSettings.Click += new System.EventHandler(this.buttonCloseSettings_Click);
            // 
            // buttonToggleBorder
            // 
            this.buttonToggleBorder.Location = new System.Drawing.Point(12, 180);
            this.buttonToggleBorder.Name = "buttonToggleBorder";
            this.buttonToggleBorder.Size = new System.Drawing.Size(91, 32);
            this.buttonToggleBorder.TabIndex = 5;
            this.buttonToggleBorder.Text = "Toggle border";
            this.buttonToggleBorder.UseVisualStyleBackColor = true;
            this.buttonToggleBorder.Click += new System.EventHandler(this.buttonToggleBorder_Click);
            // 
            // buttonExitProgram
            // 
            this.buttonExitProgram.Location = new System.Drawing.Point(110, 180);
            this.buttonExitProgram.Name = "buttonExitProgram";
            this.buttonExitProgram.Size = new System.Drawing.Size(91, 32);
            this.buttonExitProgram.TabIndex = 6;
            this.buttonExitProgram.Text = "Exit program";
            this.buttonExitProgram.UseVisualStyleBackColor = true;
            this.buttonExitProgram.Click += new System.EventHandler(this.buttonExitProgram_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "To enable moving.";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExitProgram);
            this.Controls.Add(this.buttonToggleBorder);
            this.Controls.Add(this.buttonCloseSettings);
            this.Controls.Add(this.numericFontSize);
            this.Controls.Add(this.labelFontsize);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 300);
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelFontsize;
        private System.Windows.Forms.NumericUpDown numericFontSize;
        private System.Windows.Forms.Button buttonCloseSettings;
        private System.Windows.Forms.Button buttonToggleBorder;
        private System.Windows.Forms.Button buttonExitProgram;
        private System.Windows.Forms.Label label1;
    }
}