using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FileManagement
{

    public partial class Form1 : Form
    {
        //Variables
        private Size originalSize;
        private Point originalLocation;
        private Point lastLocation;
        private bool mouseDown;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,      // x-coordinate of upper-left corner
    int nTopRect,       // y-coordinate of upper-left corner
    int nRightRect,     // x-coordinate of lower-right corner
    int nBottomRect,    // y-coordinate of lower-right corner
    int nWidthEllipse,  // width of ellipse
    int nHeightEllipse  // height of ellipse
);

        public Form1()
        {
            InitializeComponent();
            originalSize = this.Size;
            this.Resize += Form1_Resize;
            int cornerRadius = 20;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, cornerRadius, cornerRadius));
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;   
            
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
                
            {
                
                this.Location = new Point(
                   (this.Location.X - lastLocation.X)+ e.X,(this.Location.Y - lastLocation.Y)+ e.Y);
                this.Update();
               
                
               
            }
           

        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown=false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int cornerRadius = 0;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, cornerRadius, cornerRadius));

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Normal)
            {
                originalLocation = this.Location;
                WindowState = FormWindowState.Maximized;
            }
            else 
            {
                this.Size = originalSize;
                
                this.Location = originalLocation;
            } 
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
