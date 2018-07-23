﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace watch
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();

            // Starting font-value
            numericFontSize.Value = 40;
            
            Type colorType = typeof(System.Drawing.Color);
            // Adds the colors to the selector.
            // We take only static property to avoid properties like Name, IsSystemColor.
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos)
            {
                comboBoxColor.Items.AddRange(new object[] {propInfo.Name});
            }

            InstalledFontCollection fontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontCollection.Families;
            List<string> fonts = new List<string>();
            foreach (FontFamily font in fontFamilies)
            {
                if (font.IsStyleAvailable(FontStyle.Regular))
                {
                    comboBoxFont.Items.AddRange(new object[] { font.Name });
                }
                
            }
            comboBoxFont.SelectedItem = "Mangal";

            // Starting font-color.
            comboBoxColor.SelectedIndex = 50;
        }

        // Calls the SetFont from mainform on indexChanged.
        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.SetFont(comboBoxFont.SelectedItem.ToString(), (int)numericFontSize.Value);
        }

        // Calls the SetFontSize from mainform on valueChanged.
        private void numericFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxFont.SelectedItem != null)
            {
                Form1.SetFont(comboBoxFont.SelectedItem.ToString(), (int)numericFontSize.Value);
            }            
        }

        // Calls the SetTextColor from mainforn on indexChanged.
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.SetTextColor(Color.FromName(comboBoxColor.Text));
        }

        // Closes the optionsform
        private void buttonCloseSettings_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonToggleBorder_Click(object sender, EventArgs e)
        {
            Form1.ToggleShow();
        }

        private void buttonExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
    }
}
