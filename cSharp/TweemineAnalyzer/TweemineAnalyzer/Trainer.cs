using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweemineAnalyzer
{
    public partial class Trainer : Form
    {
        string filePath = "";
        public Trainer()
        {
            InitializeComponent();
            pnlResults.Visible = false;
        }

        private void BtnAnnandResultButton_Click(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            pnlPicker.Top = button.Top;
            pnlPicker.BackColor = button.BackColor;

            if (button.Tag.ToString() == "1")
            {
                pnlANNInfo.Visible = true;
                pnlResults.Visible = false;

            }
            if (button.Tag.ToString() == "2")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = true;

            }
        }
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TrackBars_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = ((TrackBar)sender);
            if (trackBar.Tag.ToString() == "LR")
                lblLearningRate.Text = ((trackBar.Value / 100.0f)).ToString();
            else if (trackBar.Tag.ToString() == "HN")
                lblHiddenNeuronCount.Text = trackBar.Value.ToString();
            else
                lblTestCount.Text = trackBar.Value.ToString()+" %";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.SafeFileName;
                filePath = openFileDialog.FileName;
            }
        }
    }
}
