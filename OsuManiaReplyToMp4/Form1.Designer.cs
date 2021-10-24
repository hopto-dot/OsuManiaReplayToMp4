
namespace OsuManiaReplyToMp4
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
            this.pbFrame = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFrame
            // 
            this.pbFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFrame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrame.Location = new System.Drawing.Point(12, 48);
            this.pbFrame.Name = "pbFrame";
            this.pbFrame.Size = new System.Drawing.Size(500, 282);
            this.pbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFrame.TabIndex = 0;
            this.pbFrame.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(101, 30);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test Render";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 342);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pbFrame);
            this.MinimumSize = new System.Drawing.Size(140, 153);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFrame;
        private System.Windows.Forms.Button btnTest;
    }
}

