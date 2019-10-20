using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebbTelescope
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            info.Text = "";
            timer1.Enabled = true;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
        private void Form1_Close(object sender, EventArgs e)
        {
           this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 10)
            {
                label3.Text = "Follow the procedures down bellow to\nfully assemble James Webb Telescop\nand prepare it for launch.";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
        }
    
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void goldPanels_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                goldPanels.Left = e.X + goldPanels.Left - MouseDownLocation.X;
                goldPanels.Top = e.Y + goldPanels.Top - MouseDownLocation.Y;

            }
        }
        private void solarShield_MouseMove(object sender, MouseEventArgs e)
        {
             if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    solarShield.Left = e.X + solarShield.Left - MouseDownLocation.X;
                    solarShield.Top = e.Y + solarShield.Top - MouseDownLocation.Y;
                }
        }

        private void spaceCraft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                spaceCraft.Left = e.X + spaceCraft.Left - MouseDownLocation.X;
                spaceCraft.Top = e.Y + spaceCraft.Top - MouseDownLocation.Y;
            }
        }

        private void starTracker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                starTracker.Left = e.X + starTracker.Left - MouseDownLocation.X;
                starTracker.Top = e.Y + starTracker.Top - MouseDownLocation.Y;
            }
        }

        private void focusKnob_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                focusKnob.Left = e.X + focusKnob.Left - MouseDownLocation.X;
                focusKnob.Top = e.Y + focusKnob.Top - MouseDownLocation.Y;
            }
        }

        private void panelHolder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panelHolder.Left = e.X + panelHolder.Left - MouseDownLocation.X;
                panelHolder.Top = e.Y + panelHolder.Top - MouseDownLocation.Y;
            }
        }

        private void panelHolder_Click(object sender, EventArgs e)
        {
            info.Text = "The backplane of the Webb Telescope serves\nas the base structure of the mirrors and instruments.\nThe backplane had to be specially designed\nto withstand the\ncold temperatures that the mirror is kept at\nand to keep the mirror segments very steady.";
        }

        private void solarShield_Click(object sender, EventArgs e)
        {
            info.Text = "Webb will observe primary infrared light\nfrom very faint and distant objects.\nThe sunshield will keep infrared light (or heat)\nfrom both the sun and the spacecraft bus electronics from\nreaching the mirror and the instruments";
        }

        private void goldPanels_Click(object sender, EventArgs e)
        {
            info.Text = "The primary mirror is the main light-gathering\nsurface on a reflecting telescope.\nInstead of glass, Webb s primary mirror is made of beryllium, a very lightweight and strong material.\nWebb s primary mirror is a very large - 6.5m in height.\nThe mirror is made up of 18 hexagonal segments\nthat will work together as a single mirror.";
        }

        private void spaceCraft_Click(object sender, EventArgs e)
        {
            info.Text = "The Space Craft is the main base of the \nJames Webb Telescope and it is used to store\nall fragile electronic parts and to steer\nand maneuver the telescope.";
        }

        private void starTracker_Click(object sender, EventArgs e)
        {
            info.Text = "The Webb has star trackers that are used to\ncoarsely point the telescope.\nDuring an observation, the Fine Guidance Sensor,\nwhich is located in the same box as the instruments,\nis used for fine adjustments";
        }

        private void focusKnob_Click(object sender, EventArgs e)
        {
            info.Text = "Though the Webb does not have an eyepiece \nwith a focus knob,it  can still be focused.\nWebb s secondary mirror is moveable and \ncan be adjusted to focus the telescope.\nIn addition, nearly all the instruments\nhave infernal focusing mechanisms for fine adjustments.\nEach segment of Webb s 18-section primary mirror is also adjustable\nso that the segments can be focused and aligned\nrelative to each other\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelHolder.Location = new Point(682, 148);
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            focusKnob.Location = new Point(227,70);
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spaceCraft.Location = new Point(648,449);
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goldPanels.Location = new Point(499,102);
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            starTracker.Location = new Point(619,488);
            MessageBox.Show("Now you are ready to explore with James Webb Telescope.", "Congratulations!", MessageBoxButtons.OK);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Visible = false;

            panelHolder.Location = new Point(639,25);
            focusKnob.Location = new Point(-19,12);
            spaceCraft.Location = new Point(689, 502);
            goldPanels.Location = new Point(339, 12);
            starTracker.Location = new Point(603, 537);
        }

        
        

        

        

        

        

        

             
    }
}

