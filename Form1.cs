using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;
using System.Diagnostics;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace AmaniVoiceAnimator
{

    public partial class Form1 : Form
    {

        private int sensitivity = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            //Get all audio sources
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {

                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));

            }

            cmbBox_source.Items.Clear();

            foreach (NAudio.Wave.WaveInCapabilities source in sources)
            {

                cmbBox_source.Items.Add(source.ProductName);

            }

        }

        private NAudio.Wave.WaveInEvent sourceEvent = null;

        private void BtnStart_Click(object sender, EventArgs e)
        {

            if (cmbBox_source.SelectedIndex != -1 && btnStart.Text == "Start")
            {
                
                int deviceNum = cmbBox_source.SelectedIndex;

                sourceEvent = new NAudio.Wave.WaveInEvent();
                sourceEvent.DeviceNumber = deviceNum;
                sourceEvent.DataAvailable += OnDataAvailable;
                sourceEvent.StartRecording();

                btnStart.Text = "Stop";
                cmbBox_source.Enabled = false;
                btnRefresh.Enabled = false;

            }
            else if (btnStart.Text == "Stop")
            {

                sourceEvent.StopRecording();
                btnStart.Text = "Start";
                cmbBox_source.Enabled = true;
                btnRefresh.Enabled = true;

            }

        }

        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {

            float avg = 0;
            float sum = 0;
            NAudio.Wave.WaveBuffer buff = new NAudio.Wave.WaveBuffer(args.Buffer);
            // interpret as 32 bit floating point audio
            for (int index = 0; index < args.BytesRecorded / 4; index++)
            {
                short sample = buff.ShortBuffer[index];

                // absolute value 
                if (sample < 0) sample = (short)-sample;
                // is this the max value?
                sum += sample;

            }

            avg = sum / (args.BytesRecorded / 4);

            Amani.Update(avg, slider_sensitivity.Value);

        }

        public Amani.Expression CreateNewExpression(string name, Bitmap open, Bitmap closed, Key key)
        {
            Amani.Expression exp = new Amani.Expression();
            exp.name = name;
            exp.open = open;
            exp.closed = closed;
            exp.key = key;
            return exp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Form2().Show();

            //Load expressions
            expressions.Add(CreateNewExpression("Focused",
                                                new Bitmap("Assets\\expression_default_open.png"),
                                                new Bitmap("Assets\\expression_default.png"),
                                                Key.NumPad7));
            expressions.Add(CreateNewExpression("Amazed",
                                                new Bitmap("Assets\\Amani_amazed_open.png"),
                                                new Bitmap("Assets\\Amani_amazed.png"),
                                                Key.Divide));
            expressions.Add(CreateNewExpression("Smug",
                                                new Bitmap("Assets\\Amani_smug_open.png"),
                                                new Bitmap("Assets\\Amani_smug.png"),
                                                Key.Multiply));
            expressions.Add(CreateNewExpression("Suprised",
                                                new Bitmap("Assets\\Amani_suprised_open.png"),
                                                new Bitmap("Assets\\Amani_suprised.png"),
                                                Key.Subtract));
            expressions.Add(CreateNewExpression("You Know",
                                                new Bitmap("Assets\\Amani_youknow_open.png"),
                                                new Bitmap("Assets\\Amani_youknow.png"),
                                                Key.NumPad8));
            expressions.Add(CreateNewExpression("Disappointed",
                                                new Bitmap("Assets\\Amani_disappointed_open.png"),
                                                new Bitmap("Assets\\Amani_disappointed.png"),
                                                Key.NumPad9));
            expressions.Add(CreateNewExpression("Angry",
                                                new Bitmap("Assets\\Amani_angry_open.png"),
                                                new Bitmap("Assets\\Amani_angry.png"),
                                                Key.NumPad4));
            expressions.Add(CreateNewExpression("Big Smile",
                                                new Bitmap("Assets\\Amani_bigsmile_open.png"),
                                                new Bitmap("Assets\\Amani_bigsmile.png"),
                                                Key.NumPad5));
            expressions.Add(CreateNewExpression("Excited",
                                                new Bitmap("Assets\\Amani_excited_open.png"),
                                                new Bitmap("Assets\\Amani_excited.png"),
                                                Key.NumPad6));
            expressions.Add(CreateNewExpression("Laughing",
                                                new Bitmap("Assets\\Amani_laugh_open.png"),
                                                new Bitmap("Assets\\Amani_laugh.png"),
                                                Key.NumPad1));
            expressions.Add(CreateNewExpression("Crying",
                                                new Bitmap("Assets\\Amani_cry_open.png"),
                                                new Bitmap("Assets\\Amani_cry.png"),
                                                Key.NumPad2));
            expressions.Add(CreateNewExpression("Oh",
                                                new Bitmap("Assets\\Amani_ohshit_open.png"),
                                                new Bitmap("Assets\\Amani_ohshit.png"),
                                                Key.NumPad3));
            expressions.Add(CreateNewExpression("In Love",
                                                new Bitmap("Assets\\Amani_love_open.png"),
                                                new Bitmap("Assets\\Amani_love.png"),
                                                Key.NumPad0));
            expressions.Add(CreateNewExpression("Scared",
                                                new Bitmap("Assets\\Amani_scared_open.png"),
                                                new Bitmap("Assets\\Amani_scared.png"),
                                                Key.Decimal));
            expressions.Add(CreateNewExpression("What",
                                                new Bitmap("Assets\\Amani_uh_open.png"),
                                                new Bitmap("Assets\\Amani_uh.png"),
                                                Key.Add));

            foreach (Amani.Expression exp in expressions)
            {
                ListViewItem item = new ListViewItem(exp.name);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, exp.key.ToString()));
                list_expressions.Items.Add(item);
            }

            Amani.SetExpression(expressions[0]);
            list_expressions.SelectedIndex = 0;

            Thread keyChecker = new Thread(CheckKeys);
            keyChecker.SetApartmentState(ApartmentState.STA);

            keyChecker.Start();

        }

        public bool isRunning = true;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (sourceEvent != null) { sourceEvent.StopRecording(); }
            isRunning = false;

        }

        private void PeakTracker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void CmbBox_source_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBox_source.SelectedIndex == -1)
            {

                btnStart.Enabled = false;
                slider_sensitivity.Enabled = false;

            }
            else
            {

                btnStart.Enabled = true;
                slider_sensitivity.Enabled = true;

            }

        }

        private void Lbl_sensitivityValue_Click(object sender, EventArgs e)
        {

        }

        private void Slider_sensitivity_Scroll(object sender, EventArgs e)
        {

            lbl_sensitivityValue.Text = "( " + slider_sensitivity.Value.ToString() + " )";
            sensitivity = slider_sensitivity.Value;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {


        }

        private void Btn_expdel_Click(object sender, EventArgs e)
        {
            if (list_expressions.SelectedIndex != -1)
            {
                expressions.RemoveAt(list_expressions.SelectedIndex);
                list_expressions.Items.RemoveAt(list_expressions.SelectedIndex);
            }
        }

        private List<Amani.Expression> expressions = new List<Amani.Expression>();

        private void List_expressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_expressions.SelectedIndex != -1)
            {
                Amani.SetExpression(expressions[list_expressions.SelectedIndex]);
            }
        }

        private void Radiobtn_laptop_CheckedChanged(object sender, EventArgs e)
        {
            Amani.SetPose(Amani.POSE_LAPTOP);
        }

        private void Radiobtn_gamepad_CheckedChanged(object sender, EventArgs e)
        {
            Amani.SetPose(Amani.POSE_GAMEPAD);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }
    }

    public class Amani
    {

        public static Bitmap POSE_LAPTOP;
        public static Bitmap POSE_GAMEPAD;

        public struct Expression
        {
            public Bitmap open;
            public Bitmap closed;
            public string name;
            public System.Windows.Input.Key key;
        }

        private static PictureBox imgBx;
        private static Expression curExpression;

        public static void Init(PictureBox amaniBox)
        {
            imgBx = amaniBox;
            try
            {
                POSE_LAPTOP = new Bitmap("C:\\Users\\beach\\source\\repos\\AmaniVoiceAnimator\\bin\\Release\\Assets\\pose_laptop.png");
            } catch { Console.WriteLine("Hey there"); }
            try {
                POSE_GAMEPAD = new Bitmap("C:\\Users\\beach\\source\\repos\\AmaniVoiceAnimator\\bin\\Release\\Assets\\pose_laptop_gamepad.png");
            }
            catch { Console.WriteLine("Hey there"); }
            Expression exp = new Expression();
            exp.name = "Default";
            try {
                exp.open = new Bitmap("C:\\Users\\beach\\source\\repos\\AmaniVoiceAnimator\\bin\\Release\\Assets\\expression_default_open.png");
            }
            catch { Console.WriteLine("Hey there"); }
            try
            {
                exp.closed = new Bitmap("C:\\Users\\beach\\source\\repos\\AmaniVoiceAnimator\\bin\\Release\\Assets\\expression_default.png");
            }
            catch { Console.WriteLine("Hey there"); }
            exp.key = Key.NumLock;
            SetExpression(exp);
        }

        public static void SetExpression(Expression expression)
        {
            if (expression.closed != null && expression.open != null)
            {
                curExpression = expression;
                imgBx.Image = expression.closed;
            }
        }

        public static void SetPose(Bitmap pose)
        {
            imgBx.BackgroundImage = pose;
        }

        public static void Update(float sample, int sensetivity)
        {
            try
            {
                imgBx.Image = sample >= sensetivity ? curExpression.open : curExpression.closed;
            }
            catch { }
        }

    }

}
