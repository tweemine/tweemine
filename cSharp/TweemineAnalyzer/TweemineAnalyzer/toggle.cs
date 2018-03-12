///This controller created by Şamil SOFTSAM
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TweemineAnalyzer
{
    public partial class toggle : UserControl
    {
        string toggleText1,toggleText2;
        Color colorToggle1, colorToggle2;
        bool state;

        public delegate void Toggled(bool val);
        public event Toggled ToggleChanged;

        

         delegate void ObjectChangedHandler(object sender);
         event ObjectChangedHandler ObjectChanged;

        delegate void ColorChangedHandler(Color color);
        event ColorChangedHandler ColorChanged;

        public bool State { get { return state; } set { state = value;//ToggleChanged?.Invoke(value);
                if(value==true)
                {
                    button1_Click(button1, new EventArgs());
                }
                else
                {
                    button1_Click(button2, new EventArgs());
                }

            } }
        public Color Toggle1Color { get { return colorToggle1; } set { colorToggle1 = value; } }
        public Color Toggle2Color { get { return colorToggle2; } set { colorToggle2 = value; ColorChanged?.Invoke(value); } }
        public string Toggle1Text { get { return toggleText1; } set { toggleText1 = value; ObjectChanged?.Invoke(button1); } }
        public string Toggle2Text { get { return toggleText2; } set { toggleText2 = value;ObjectChanged?.Invoke(button2);  } }

        public toggle()
        {
            InitializeComponent();
            Toggle1Color = Color.Green;
            Toggle2Color = Color.Red;
            BackColor = Toggle2Color;
            button1.Text = Toggle1Text;
            button2.Text = Toggle2Text;
            ObjectChanged += Toggle_ObjectChanged;
            ColorChanged += Toggle_ColorChanged;
        }

        private void Toggle_ColorChanged(Color color)
        {
            BackColor = color;
        }

        private void toggle_Load(object sender, EventArgs e)
        {
           // State = true;
        }

        private void Toggle_ObjectChanged(object sender)
        {
            ((Button)sender).Text = ((Button)sender).Tag.ToString() == "true" ? toggleText1 : toggleText2;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            ((Button)sender).Visible = false;
            string tag = ((Button)sender).Tag.ToString();
            bool buttonVal = bool.Parse(tag);
            if (buttonVal == true)
            {
                BackColor = Toggle1Color;
            }
            else
            {
                BackColor = Toggle2Color;
            }
            ToggleChanged?.Invoke(bool.Parse(tag));

        }

    }
}
