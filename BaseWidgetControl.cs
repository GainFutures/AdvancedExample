using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TraderLight
{
    
    public partial class BaseWidgetControl : UserControl
    {
        
        public static bool IsDesignMode =
                    string.Compare(System.Diagnostics.Process.GetCurrentProcess().ProcessName, "devenv", true) == 0;
        

        public string Caption
        {
            get {return lbName.Text;}
            set { lbName.Text = value; }
        }

        int m_minWidth = 30;
        public int MinWidth
        {
            get { return m_minWidth; }
            set { m_minWidth = value; }
        }

        int m_minHeight = 30;
        public int MinHeight
        {
            get { return m_minHeight; }
            set { m_minHeight = value; }
        }

        public BaseWidgetControl()
        {
            InitializeComponent();
            
        }

        #region widget moving
        int mx = -1;
        int my = -1;
        /// <summary>
        /// Resets saved mouse coordinates, completes control moving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbName_MouseCaptureChanged(object sender, EventArgs e)
        {
            mx = my = -1;
        }
        /// <summary>
        /// Saves coordinates of positions, where mouse was down, to compute then new position of control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbName_MouseDown(object sender, MouseEventArgs e)
        {
            this.BringToFront();
            mx = e.X;
            my = e.Y;
        }
        /// <summary>
        /// Moving control to it's new position, if mouse was down (and it's coordinates was saved with MouseDown event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbName_MouseMove(object sender, MouseEventArgs e)
        {
            if (mx < 0)
                return;
            
            //setting new coordinates 
            int dx = e.X - mx;
            int dy = e.Y - my;

            //corrects out-of-border new coordinates
            int newX = this.Left + dx;
            int newY = this.Top + dy;
            if (newX < 0) newX = 0;
            if (newY < 0) newY = 0;
            int rightBorder= this.Parent.Width - this.Width;
            int bottomBorder = this.Parent.Height - this.Height;
            if (newX > rightBorder) newX = rightBorder;
            if (newY > bottomBorder) newY = bottomBorder;

            //place widget on it's new position
            this.Location = new Point(newX, newY);
            this.Invalidate();            
        }
        #endregion

        #region widget sizing
        int sx = -1;
        int sy = -1;
        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            sx = sy = -1;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sx = e.X;
            sy = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sx < 0)
                return;

            int dx = e.X - sx;
            int dy = e.Y - sy;
            int newWidth = this.Width + dx;
            int newHeight = this.Height + dy;

            if (newWidth < MinWidth) newWidth = MinWidth;
            if (newHeight < MinHeight) newHeight = MinHeight;

            int maxWidth = this.Parent.Width - this.Left;
            int maxHeight = this.Parent.Height - this.Top;
            if (newWidth > maxWidth) newWidth = maxWidth;
            if (newHeight > maxHeight) newHeight = maxHeight;

            this.Size = new Size(newWidth, newHeight);
            this.Invalidate();
        }
        #endregion

        private void BaseWidgetControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.BringToFront();
        }

        
    }
}
