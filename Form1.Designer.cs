namespace AmaniVoiceAnimator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.peakTracker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiobtn_gamepad = new System.Windows.Forms.RadioButton();
            this.radiobtn_laptop = new System.Windows.Forms.RadioButton();
            this.lbl_sensitivityValue = new System.Windows.Forms.Label();
            this.lbl_sensitivity = new System.Windows.Forms.Label();
            this.slider_sensitivity = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_source = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_expressions = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_sensitivity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // peakTracker
            // 
            this.peakTracker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PeakTracker_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_sensitivityValue);
            this.groupBox1.Controls.Add(this.lbl_sensitivity);
            this.groupBox1.Controls.Add(this.slider_sensitivity);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBox_source);
            this.groupBox1.Location = new System.Drawing.Point(15, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radiobtn_gamepad);
            this.groupBox3.Controls.Add(this.radiobtn_laptop);
            this.groupBox3.Location = new System.Drawing.Point(7, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 43);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pose";
            // 
            // radiobtn_gamepad
            // 
            this.radiobtn_gamepad.AutoSize = true;
            this.radiobtn_gamepad.Location = new System.Drawing.Point(82, 19);
            this.radiobtn_gamepad.Name = "radiobtn_gamepad";
            this.radiobtn_gamepad.Size = new System.Drawing.Size(71, 17);
            this.radiobtn_gamepad.TabIndex = 8;
            this.radiobtn_gamepad.TabStop = true;
            this.radiobtn_gamepad.Text = "Gamepad";
            this.radiobtn_gamepad.UseVisualStyleBackColor = true;
            this.radiobtn_gamepad.CheckedChanged += new System.EventHandler(this.Radiobtn_gamepad_CheckedChanged);
            // 
            // radiobtn_laptop
            // 
            this.radiobtn_laptop.AutoSize = true;
            this.radiobtn_laptop.Location = new System.Drawing.Point(199, 19);
            this.radiobtn_laptop.Name = "radiobtn_laptop";
            this.radiobtn_laptop.Size = new System.Drawing.Size(58, 17);
            this.radiobtn_laptop.TabIndex = 7;
            this.radiobtn_laptop.TabStop = true;
            this.radiobtn_laptop.Text = "Laptop";
            this.radiobtn_laptop.UseVisualStyleBackColor = true;
            this.radiobtn_laptop.CheckedChanged += new System.EventHandler(this.Radiobtn_laptop_CheckedChanged);
            // 
            // lbl_sensitivityValue
            // 
            this.lbl_sensitivityValue.AutoSize = true;
            this.lbl_sensitivityValue.Location = new System.Drawing.Point(160, 159);
            this.lbl_sensitivityValue.Name = "lbl_sensitivityValue";
            this.lbl_sensitivityValue.Size = new System.Drawing.Size(25, 13);
            this.lbl_sensitivityValue.TabIndex = 6;
            this.lbl_sensitivityValue.Text = "( 0 )";
            this.lbl_sensitivityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_sensitivityValue.Click += new System.EventHandler(this.Lbl_sensitivityValue_Click);
            // 
            // lbl_sensitivity
            // 
            this.lbl_sensitivity.AutoSize = true;
            this.lbl_sensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sensitivity.Location = new System.Drawing.Point(137, 105);
            this.lbl_sensitivity.Name = "lbl_sensitivity";
            this.lbl_sensitivity.Size = new System.Drawing.Size(65, 13);
            this.lbl_sensitivity.TabIndex = 5;
            this.lbl_sensitivity.Text = "Sensitivity";
            // 
            // slider_sensitivity
            // 
            this.slider_sensitivity.Enabled = false;
            this.slider_sensitivity.Location = new System.Drawing.Point(5, 127);
            this.slider_sensitivity.Maximum = 1000;
            this.slider_sensitivity.Name = "slider_sensitivity";
            this.slider_sensitivity.Size = new System.Drawing.Size(329, 45);
            this.slider_sensitivity.TabIndex = 4;
            this.slider_sensitivity.Scroll += new System.EventHandler(this.Slider_sensitivity_Scroll);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(86, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(107, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Source List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbBox_source
            // 
            this.cmbBox_source.FormattingEnabled = true;
            this.cmbBox_source.Location = new System.Drawing.Point(65, 43);
            this.cmbBox_source.Name = "cmbBox_source";
            this.cmbBox_source.Size = new System.Drawing.Size(211, 21);
            this.cmbBox_source.TabIndex = 0;
            this.cmbBox_source.SelectedIndexChanged += new System.EventHandler(this.CmbBox_source_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amani Voice Animator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_expressions);
            this.groupBox2.Location = new System.Drawing.Point(362, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expressions";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter_1);
            // 
            // list_expressions
            // 
            this.list_expressions.FormattingEnabled = true;
            this.list_expressions.Location = new System.Drawing.Point(6, 21);
            this.list_expressions.MultiColumn = true;
            this.list_expressions.Name = "list_expressions";
            this.list_expressions.Size = new System.Drawing.Size(178, 251);
            this.list_expressions.TabIndex = 11;
            this.list_expressions.SelectedIndexChanged += new System.EventHandler(this.List_expressions_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Amani Voice Animator v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_sensitivity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker peakTracker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_source;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbl_sensitivity;
        private System.Windows.Forms.TrackBar slider_sensitivity;
        private System.Windows.Forms.Label lbl_sensitivityValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_expressions;
        private System.Windows.Forms.RadioButton radiobtn_laptop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radiobtn_gamepad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

