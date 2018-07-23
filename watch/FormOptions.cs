using System;
using System.Drawing;
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

            // Gets all the known colors and adds the to the selector.
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor knownColor in colors)
            {
                comboBoxColor.Items.AddRange(new object[] 
                {
                    knownColor
                });
            }

            // Starting font-color.
            comboBoxColor.SelectedIndex = 76;
        }

        // Calls the SetTextColor from mainforn on indexChanged.
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.SetTextColor(Color.FromName(comboBoxColor.Text));
        }

        // Calls the SetFontSize from mainform on valueChanged.
        private void numericFontSize_ValueChanged(object sender, EventArgs e)
        {
            Form1.SetFontSize((int)numericFontSize.Value);
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
    }
}
