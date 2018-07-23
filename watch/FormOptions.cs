using System;
using System.Drawing;
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
            // We take only static property to avoid properties like Name, IsSystemColor ...
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos)
            {
                comboBoxColor.Items.AddRange(new object[] {propInfo.Name});
            }

            // Starting font-color.
            comboBoxColor.SelectedIndex = 50;
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
