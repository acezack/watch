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
            this.label2 = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.radioButtonLongTime = new System.Windows.Forms.RadioButton();
            this.radioButtonShortTime = new System.Windows.Forms.RadioButton();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelTopmost = new System.Windows.Forms.Label();
            this.checkBoxTopmost = new System.Windows.Forms.CheckBox();
            this.buttonResetPosition = new System.Windows.Forms.Button();
            this.buttonGoToSavedPosition = new System.Windows.Forms.Button();
            this.buttonSavePosition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(10, 66);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(57, 13);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Fontcolor: ";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(75, 63);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 2;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // labelFontsize
            // 
            this.labelFontsize.AutoSize = true;
            this.labelFontsize.Location = new System.Drawing.Point(10, 39);
            this.labelFontsize.Name = "labelFontsize";
            this.labelFontsize.Size = new System.Drawing.Size(49, 13);
            this.labelFontsize.TabIndex = 156;
            this.labelFontsize.Text = "Fontsize:";
            // 
            // numericFontSize
            // 
            this.numericFontSize.Location = new System.Drawing.Point(75, 37);
            this.numericFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(121, 20);
            this.numericFontSize.TabIndex = 1;
            this.numericFontSize.ValueChanged += new System.EventHandler(this.numericFontSize_ValueChanged);
            // 
            // buttonCloseSettings
            // 
            this.buttonCloseSettings.Location = new System.Drawing.Point(110, 197);
            this.buttonCloseSettings.Name = "buttonCloseSettings";
            this.buttonCloseSettings.Size = new System.Drawing.Size(91, 32);
            this.buttonCloseSettings.TabIndex = 7;
            this.buttonCloseSettings.Text = "Close options";
            this.buttonCloseSettings.UseVisualStyleBackColor = true;
            this.buttonCloseSettings.Click += new System.EventHandler(this.buttonCloseSettings_Click);
            // 
            // buttonToggleBorder
            // 
            this.buttonToggleBorder.Location = new System.Drawing.Point(13, 159);
            this.buttonToggleBorder.Name = "buttonToggleBorder";
            this.buttonToggleBorder.Size = new System.Drawing.Size(91, 32);
            this.buttonToggleBorder.TabIndex = 5;
            this.buttonToggleBorder.Text = "Toggle border";
            this.buttonToggleBorder.UseVisualStyleBackColor = true;
            this.buttonToggleBorder.Click += new System.EventHandler(this.buttonToggleBorder_Click);
            // 
            // buttonExitProgram
            // 
            this.buttonExitProgram.Location = new System.Drawing.Point(110, 159);
            this.buttonExitProgram.Name = "buttonExitProgram";
            this.buttonExitProgram.Size = new System.Drawing.Size(91, 32);
            this.buttonExitProgram.TabIndex = 6;
            this.buttonExitProgram.Text = "Exit program";
            this.buttonExitProgram.UseVisualStyleBackColor = true;
            this.buttonExitProgram.Click += new System.EventHandler(this.buttonExitProgram_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Settings can be \r\nopened from \r\nnotification in taskbar.";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(10, 13);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(31, 13);
            this.labelFont.TabIndex = 124;
            this.labelFont.Text = "Font:";
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(75, 10);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFont.TabIndex = 0;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
            // 
            // radioButtonLongTime
            // 
            this.radioButtonLongTime.AutoSize = true;
            this.radioButtonLongTime.Location = new System.Drawing.Point(78, 91);
            this.radioButtonLongTime.Name = "radioButtonLongTime";
            this.radioButtonLongTime.Size = new System.Drawing.Size(49, 17);
            this.radioButtonLongTime.TabIndex = 3;
            this.radioButtonLongTime.TabStop = true;
            this.radioButtonLongTime.Text = "Long";
            this.radioButtonLongTime.UseVisualStyleBackColor = true;
            this.radioButtonLongTime.CheckedChanged += new System.EventHandler(this.radioButtonLongTime_CheckedChanged);
            // 
            // radioButtonShortTime
            // 
            this.radioButtonShortTime.AutoSize = true;
            this.radioButtonShortTime.Location = new System.Drawing.Point(133, 91);
            this.radioButtonShortTime.Name = "radioButtonShortTime";
            this.radioButtonShortTime.Size = new System.Drawing.Size(50, 17);
            this.radioButtonShortTime.TabIndex = 4;
            this.radioButtonShortTime.TabStop = true;
            this.radioButtonShortTime.Text = "Short";
            this.radioButtonShortTime.UseVisualStyleBackColor = true;
            this.radioButtonShortTime.CheckedChanged += new System.EventHandler(this.radioButtonShortTime_CheckedChanged);
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(10, 93);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(62, 13);
            this.labelFormat.TabIndex = 13;
            this.labelFormat.Text = "Timeformat:";
            // 
            // labelTopmost
            // 
            this.labelTopmost.AutoSize = true;
            this.labelTopmost.Location = new System.Drawing.Point(10, 119);
            this.labelTopmost.Name = "labelTopmost";
            this.labelTopmost.Size = new System.Drawing.Size(51, 13);
            this.labelTopmost.TabIndex = 157;
            this.labelTopmost.Text = "Topmost:";
            // 
            // checkBoxTopmost
            // 
            this.checkBoxTopmost.AutoSize = true;
            this.checkBoxTopmost.Location = new System.Drawing.Point(78, 118);
            this.checkBoxTopmost.Name = "checkBoxTopmost";
            this.checkBoxTopmost.Size = new System.Drawing.Size(92, 17);
            this.checkBoxTopmost.TabIndex = 158;
            this.checkBoxTopmost.Text = "Always on top";
            this.checkBoxTopmost.UseVisualStyleBackColor = true;
            this.checkBoxTopmost.CheckedChanged += new System.EventHandler(this.checkBoxTopmost_CheckedChanged);
            // 
            // buttonResetPosition
            // 
            this.buttonResetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPosition.Location = new System.Drawing.Point(59, 235);
            this.buttonResetPosition.Name = "buttonResetPosition";
            this.buttonResetPosition.Size = new System.Drawing.Size(45, 32);
            this.buttonResetPosition.TabIndex = 159;
            this.buttonResetPosition.Text = "Reset position";
            this.buttonResetPosition.UseVisualStyleBackColor = true;
            this.buttonResetPosition.Click += new System.EventHandler(this.buttonResetPosition_Click);
            // 
            // buttonGoToSavedPosition
            // 
            this.buttonGoToSavedPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToSavedPosition.Location = new System.Drawing.Point(13, 197);
            this.buttonGoToSavedPosition.Name = "buttonGoToSavedPosition";
            this.buttonGoToSavedPosition.Size = new System.Drawing.Size(91, 32);
            this.buttonGoToSavedPosition.TabIndex = 160;
            this.buttonGoToSavedPosition.Text = "Saved position";
            this.buttonGoToSavedPosition.UseVisualStyleBackColor = true;
            this.buttonGoToSavedPosition.Click += new System.EventHandler(this.buttonGoToSavedPosition_Click);
            // 
            // buttonSavePosition
            // 
            this.buttonSavePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePosition.Location = new System.Drawing.Point(13, 235);
            this.buttonSavePosition.Name = "buttonSavePosition";
            this.buttonSavePosition.Size = new System.Drawing.Size(45, 32);
            this.buttonSavePosition.TabIndex = 161;
            this.buttonSavePosition.Text = "Save position";
            this.buttonSavePosition.UseVisualStyleBackColor = true;
            this.buttonSavePosition.Click += new System.EventHandler(this.buttonSavePosition_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 272);
            this.Controls.Add(this.buttonSavePosition);
            this.Controls.Add(this.buttonGoToSavedPosition);
            this.Controls.Add(this.buttonResetPosition);
            this.Controls.Add(this.checkBoxTopmost);
            this.Controls.Add(this.labelTopmost);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.radioButtonShortTime);
            this.Controls.Add(this.radioButtonLongTime);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExitProgram);
            this.Controls.Add(this.buttonToggleBorder);
            this.Controls.Add(this.buttonCloseSettings);
            this.Controls.Add(this.numericFontSize);
            this.Controls.Add(this.labelFontsize);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 310);
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.RadioButton radioButtonLongTime;
        private System.Windows.Forms.RadioButton radioButtonShortTime;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelTopmost;
        private System.Windows.Forms.CheckBox checkBoxTopmost;
        private System.Windows.Forms.Button buttonResetPosition;
        private System.Windows.Forms.Button buttonGoToSavedPosition;
        private System.Windows.Forms.Button buttonSavePosition;
    }
}