
namespace Tic_Tac_Toe
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
            this.brdTopLeft = new System.Windows.Forms.Button();
            this.brdTopCenter = new System.Windows.Forms.Button();
            this.brdTopRight = new System.Windows.Forms.Button();
            this.brdCenterLeft = new System.Windows.Forms.Button();
            this.brdCenterCenter = new System.Windows.Forms.Button();
            this.brdCenterRight = new System.Windows.Forms.Button();
            this.brdBottomLeft = new System.Windows.Forms.Button();
            this.brdBottomCenter = new System.Windows.Forms.Button();
            this.brdBottomRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brdTopLeft
            // 
            this.brdTopLeft.Location = new System.Drawing.Point(12, 12);
            this.brdTopLeft.Name = "brdTopLeft";
            this.brdTopLeft.Size = new System.Drawing.Size(75, 76);
            this.brdTopLeft.TabIndex = 0;
            this.brdTopLeft.UseVisualStyleBackColor = true;
            this.brdTopLeft.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdTopCenter
            // 
            this.brdTopCenter.Location = new System.Drawing.Point(93, 12);
            this.brdTopCenter.Name = "brdTopCenter";
            this.brdTopCenter.Size = new System.Drawing.Size(75, 76);
            this.brdTopCenter.TabIndex = 1;
            this.brdTopCenter.UseVisualStyleBackColor = true;
            this.brdTopCenter.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdTopRight
            // 
            this.brdTopRight.Location = new System.Drawing.Point(174, 12);
            this.brdTopRight.Name = "brdTopRight";
            this.brdTopRight.Size = new System.Drawing.Size(75, 76);
            this.brdTopRight.TabIndex = 2;
            this.brdTopRight.UseVisualStyleBackColor = true;
            this.brdTopRight.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdCenterLeft
            // 
            this.brdCenterLeft.Location = new System.Drawing.Point(12, 94);
            this.brdCenterLeft.Name = "brdCenterLeft";
            this.brdCenterLeft.Size = new System.Drawing.Size(75, 76);
            this.brdCenterLeft.TabIndex = 3;
            this.brdCenterLeft.UseVisualStyleBackColor = true;
            this.brdCenterLeft.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdCenterCenter
            // 
            this.brdCenterCenter.AccessibleDescription = "";
            this.brdCenterCenter.Location = new System.Drawing.Point(93, 94);
            this.brdCenterCenter.Name = "brdCenterCenter";
            this.brdCenterCenter.Size = new System.Drawing.Size(75, 76);
            this.brdCenterCenter.TabIndex = 4;
            this.brdCenterCenter.UseVisualStyleBackColor = true;
            this.brdCenterCenter.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdCenterRight
            // 
            this.brdCenterRight.Location = new System.Drawing.Point(174, 94);
            this.brdCenterRight.Name = "brdCenterRight";
            this.brdCenterRight.Size = new System.Drawing.Size(75, 76);
            this.brdCenterRight.TabIndex = 5;
            this.brdCenterRight.UseVisualStyleBackColor = true;
            this.brdCenterRight.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdBottomLeft
            // 
            this.brdBottomLeft.Location = new System.Drawing.Point(12, 176);
            this.brdBottomLeft.Name = "brdBottomLeft";
            this.brdBottomLeft.Size = new System.Drawing.Size(75, 76);
            this.brdBottomLeft.TabIndex = 6;
            this.brdBottomLeft.Text = " ";
            this.brdBottomLeft.UseVisualStyleBackColor = true;
            this.brdBottomLeft.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdBottomCenter
            // 
            this.brdBottomCenter.Location = new System.Drawing.Point(93, 176);
            this.brdBottomCenter.Name = "brdBottomCenter";
            this.brdBottomCenter.Size = new System.Drawing.Size(75, 76);
            this.brdBottomCenter.TabIndex = 7;
            this.brdBottomCenter.UseVisualStyleBackColor = true;
            this.brdBottomCenter.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdBottomRight
            // 
            this.brdBottomRight.Location = new System.Drawing.Point(174, 176);
            this.brdBottomRight.Name = "brdBottomRight";
            this.brdBottomRight.Size = new System.Drawing.Size(75, 76);
            this.brdBottomRight.TabIndex = 8;
            this.brdBottomRight.UseVisualStyleBackColor = true;
            this.brdBottomRight.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brdBottomRight);
            this.Controls.Add(this.brdBottomCenter);
            this.Controls.Add(this.brdBottomLeft);
            this.Controls.Add(this.brdCenterRight);
            this.Controls.Add(this.brdCenterCenter);
            this.Controls.Add(this.brdCenterLeft);
            this.Controls.Add(this.brdTopRight);
            this.Controls.Add(this.brdTopCenter);
            this.Controls.Add(this.brdTopLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brdTopLeft;
        private System.Windows.Forms.Button brdTopCenter;
        private System.Windows.Forms.Button brdTopRight;
        private System.Windows.Forms.Button brdCenterLeft;
        private System.Windows.Forms.Button brdCenterCenter;
        private System.Windows.Forms.Button brdCenterRight;
        private System.Windows.Forms.Button brdBottomLeft;
        private System.Windows.Forms.Button brdBottomCenter;
        private System.Windows.Forms.Button brdBottomRight;
    }
}

