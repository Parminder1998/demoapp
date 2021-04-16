
namespace demoapp
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
            this.btnrannum = new System.Windows.Forms.Button();
            this.lblrannum = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.btnSound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrannum
            // 
            this.btnrannum.Location = new System.Drawing.Point(86, 45);
            this.btnrannum.Name = "btnrannum";
            this.btnrannum.Size = new System.Drawing.Size(111, 32);
            this.btnrannum.TabIndex = 0;
            this.btnrannum.Text = "Random number";
            this.btnrannum.UseVisualStyleBackColor = true;
            this.btnrannum.Click += new System.EventHandler(this.btnrannum_Click);
            // 
            // lblrannum
            // 
            this.lblrannum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblrannum.Location = new System.Drawing.Point(388, 84);
            this.lblrannum.Name = "lblrannum";
            this.lblrannum.Size = new System.Drawing.Size(100, 23);
            this.lblrannum.TabIndex = 1;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(121, 173);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(103, 23);
            this.btnImage.TabIndex = 3;
            this.btnImage.Text = "change image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pbimage
            // 
            this.pbimage.BackgroundImage = global::demoapp.Properties.Resources.IMG_2494;
            this.pbimage.Location = new System.Drawing.Point(391, 154);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(180, 134);
            this.pbimage.TabIndex = 2;
            this.pbimage.TabStop = false;
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(166, 249);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 23);
            this.btnSound.TabIndex = 4;
            this.btnSound.Text = "Play Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pbimage);
            this.Controls.Add(this.lblrannum);
            this.Controls.Add(this.btnrannum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrannum;
        private System.Windows.Forms.Label lblrannum;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnSound;
    }
}

