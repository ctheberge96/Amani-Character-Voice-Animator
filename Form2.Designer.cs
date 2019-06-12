namespace AmaniVoiceAnimator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imgBox_amaniPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_amaniPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox_amaniPreview
            // 
            this.imgBox_amaniPreview.BackColor = System.Drawing.Color.Transparent;
            this.imgBox_amaniPreview.BackgroundImage = global::AmaniVoiceAnimator.Properties.Resources.pose_laptop;
            this.imgBox_amaniPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBox_amaniPreview.Image = global::AmaniVoiceAnimator.Properties.Resources.expression_focused;
            this.imgBox_amaniPreview.Location = new System.Drawing.Point(-100, 0);
            this.imgBox_amaniPreview.Name = "imgBox_amaniPreview";
            this.imgBox_amaniPreview.Size = new System.Drawing.Size(825, 841);
            this.imgBox_amaniPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_amaniPreview.TabIndex = 2;
            this.imgBox_amaniPreview.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 666);
            this.Controls.Add(this.imgBox_amaniPreview);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Amani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_amaniPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox_amaniPreview;
    }
}