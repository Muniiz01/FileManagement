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
        
        private bool isDragging = false;
        private Point cursorRelativeToForm;
        private Size previousSize;
        private Point previousLocation;

        public Form1()
        {
            InitializeComponent();
            exit.MouseEnter += exit_MouseEnter;
            exit.MouseLeave += exit_MouseLeave;

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                isDragging = true;

                cursorRelativeToForm = new Point(e.X, e.Y);

                Console.WriteLine(cursorRelativeToForm);

                previousSize = this.Size;
                previousLocation = this.Location;

            }
            
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDragging)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    // if (cursorRelativeToForm.X >= 1200) { cursorRelativeToForm.X -= 700; }

                    switch (cursorRelativeToForm.X)
                    {
                        case int v when (v >= 1700): 
                            cursorRelativeToForm.X -= 700;
                            break;
                        case int v when (v >= 1200):
                            cursorRelativeToForm.X -= 600;
                            break;
                        case int v when (v <= 1200):
                            cursorRelativeToForm.X -= 400;
                            break;

                    }

                    this.WindowState = FormWindowState.Normal;

                    Point newCursorPos = this.PointToScreen(cursorRelativeToForm);
                    Cursor.Position = newCursorPos;
                }

                this.Location = new Point(Cursor.Position.X - cursorRelativeToForm.X, Cursor.Position.Y - cursorRelativeToForm.Y);
            }

        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

       
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.Red;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.Transparent;
        }
    }
}
