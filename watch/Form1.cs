﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace watch
{
    public partial class Form1 : Form
    {
        // Indicates whether the border is shown or not.
        static bool borderHidden = false;
        bool settingsChosen = Properties.Settings.Default.settingsChosen;

        // A timer to update the watch every second.
        Timer updateTimer = new Timer();

        // Values used to determine color and fontsize.
        static int fontSize = Properties.Settings.Default.fontSize;
        static Font font = Properties.Settings.Default.font;
        static SolidBrush brush = new SolidBrush(Properties.Settings.Default.brushColor);
        static int timeFormat = Properties.Settings.Default.timeFormat;
        // 0 = Long
        // 1 = Short

        Point textOffsetOnBorderToggle = new Point(8, 30);
        SizeF windowSize;

        // The notification-icon options.
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemToggleShow;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemOptions;

        // The window for options.
        FormOptions formOptions;

        // Used to transfer clicks to the window below it effectively making it clickthrough.
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern long GetWindowLong(IntPtr hWnd, int nIndex);

        public Form1()
        {
            InitializeComponent();

            this.Location = Properties.Settings.Default.location;

            // Initializes the form for options.
            formOptions = new FormOptions();

            // Used to make the background transparent.
            TransparencyKey = Color.FromArgb(0, 0, 1);
            BackColor = Color.FromArgb(0, 0, 1);

            // Hides the border.
            FormBorderStyle = FormBorderStyle.None;

            // Starts the timer.
            updateTimer.Interval = 1000;
            updateTimer.Enabled = true;
            updateTimer.Tick += updateTimer_Tick;

            // Initializes the notificationmenu
            #region notificationmenu initialization
            // Initializes the notification-right-click-menu
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemToggleShow = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemOptions = new System.Windows.Forms.MenuItem();

            // Adds items to the menu.
            this.contextMenu1.MenuItems.AddRange(
                new System.Windows.Forms.MenuItem[] 
                { 
                    this.menuItemToggleShow,
                    this.menuItemExit,
                    this.menuItemOptions
                });

            // Toggle border
            this.menuItemToggleShow.Index = 0;
            this.menuItemToggleShow.Text = "Show border";
            this.menuItemToggleShow.Click += menuItemToggleShow_Click;

            // Show options
            this.menuItemOptions.Index = 1;
            this.menuItemOptions.Text = "Show options";
            this.menuItemOptions.Click += menuItemOptions_Click;

            // Exit program
            this.menuItemExit.Index = 2;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += menuItemExit_Click;
            #endregion

            // Sets the contextMenu.
            watchNotifyIcon.ContextMenu = this.contextMenu1;

            // Hooks the clicks and sends the to the window below.
            SetWindowLong(this.Handle, -20, (int)GetWindowLong(this.Handle, -20) | 0x00000020);

            if (!settingsChosen)
            {
                formOptions.Show();
                settingsChosen = true;
            }
        }

        // Shows the options-form.
        void menuItemOptions_Click(object sender, EventArgs e)
        {
            formOptions = new FormOptions();
            formOptions.Show();
        }

        // Toggles the border, changes menutext, sets hidden.
        void menuItemToggleShow_Click(object sender, EventArgs e)
        {
            if (!borderHidden)
            {
                borderHidden = true;
            }
            else
            {
                borderHidden = false;
            }
        }

        // Exits the program.
        void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Refreshes the form.
        void updateTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Size newSize = Size.Round(windowSize);
            newSize.Width += (int)20;
            newSize.Height += (int)60;
            this.Size = newSize;

            if (!borderHidden)
            {
                FormBorderStyle = FormBorderStyle.None;
                menuItemToggleShow.Text = "Show border";
                textOffsetOnBorderToggle = new Point(8, 30);
                SetWindowLong(this.Handle, -20, (int)GetWindowLong(this.Handle, -20) | 0x00000020);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                menuItemToggleShow.Text = "Hide border";
                textOffsetOnBorderToggle = new Point(0, 0);
            }
        }

        // Draws the time.
        protected override void OnPaint(PaintEventArgs e)
        {
            if (timeFormat == 0)
            {
                e.Graphics.DrawString(DateTime.Now.ToLongTimeString(),
                font,
                brush,
                textOffsetOnBorderToggle);
                base.OnPaint(e);

                windowSize = e.Graphics.MeasureString(DateTime.Now.ToLongTimeString(), font);
            }
            else
            {
                e.Graphics.DrawString(DateTime.Now.ToShortTimeString(),
                font,
                brush,
                textOffsetOnBorderToggle);
                base.OnPaint(e);

                windowSize = e.Graphics.MeasureString(DateTime.Now.ToShortTimeString(), font);
            }
            
        }

        /* 
         * Can only be used to hide, since form can't be 
         * targetted by clicking but can be targetted 
         * when border is shown. Eliminates the need 
         * to rightclick the notif-menu to hide again.
         */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                if (!borderHidden)
                {
                    borderHidden = true;
                }
            }
        }

        // A public function to change textcolor(used in optionsform).
        public static void SetTextColor(Color newColor)
        {
            brush = new SolidBrush(newColor);
        }

        // A public function to change font and fontsize(used in optionsform).
        public static void SetFont(string newFont, int newFontSize)
        {
            fontSize = newFontSize;
            if (newFontSize != 0)
            {
                font = new Font(newFont, newFontSize);
            } 
        }

        public static void SetTimeFormat(int newTimeFormat)
        {
            // 0 = Long
            // 1 = Short
            timeFormat = newTimeFormat;
        }

        public static void ToggleShow()
        {
            if (borderHidden)
            {
                borderHidden = false;
            }
            else
            {
                borderHidden = true;
            }
        }

        // Saves all your settings upon closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.fontSize = fontSize;
            Properties.Settings.Default.font = font;
            Properties.Settings.Default.brushColor = brush.Color;
            Properties.Settings.Default.timeFormat = timeFormat;
            Properties.Settings.Default.location = this.Location;
            Properties.Settings.Default.settingsChosen = settingsChosen;
            Properties.Settings.Default.Save();
        }
    }
}
