
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
            this.components = new System.ComponentModel.Container();
            this.brdTopLeft = new System.Windows.Forms.Button();
            this.brdTopCenter = new System.Windows.Forms.Button();
            this.brdTopRight = new System.Windows.Forms.Button();
            this.brdCenterLeft = new System.Windows.Forms.Button();
            this.brdCenterCenter = new System.Windows.Forms.Button();
            this.brdCenterRight = new System.Windows.Forms.Button();
            this.brdBottomLeft = new System.Windows.Forms.Button();
            this.brdBottomCenter = new System.Windows.Forms.Button();
            this.brdBottomRight = new System.Windows.Forms.Button();
            this.TimerBar = new System.Windows.Forms.ProgressBar();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brdTopLeft
            // 
            this.brdTopLeft.Enabled = false;
            this.brdTopLeft.Location = new System.Drawing.Point(12, 12);
            this.brdTopLeft.Name = "brdTopLeft";
            this.brdTopLeft.Size = new System.Drawing.Size(75, 76);
            this.brdTopLeft.TabIndex = 0;
            this.brdTopLeft.UseVisualStyleBackColor = true;
            this.brdTopLeft.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdTopCenter
            // 
            this.brdTopCenter.Enabled = false;
            this.brdTopCenter.Location = new System.Drawing.Point(93, 12);
            this.brdTopCenter.Name = "brdTopCenter";
            this.brdTopCenter.Size = new System.Drawing.Size(75, 76);
            this.brdTopCenter.TabIndex = 1;
            this.brdTopCenter.UseVisualStyleBackColor = true;
            this.brdTopCenter.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdTopRight
            // 
            this.brdTopRight.Enabled = false;
            this.brdTopRight.Location = new System.Drawing.Point(174, 12);
            this.brdTopRight.Name = "brdTopRight";
            this.brdTopRight.Size = new System.Drawing.Size(75, 76);
            this.brdTopRight.TabIndex = 2;
            this.brdTopRight.UseVisualStyleBackColor = true;
            this.brdTopRight.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdCenterLeft
            // 
            this.brdCenterLeft.Enabled = false;
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
            this.brdCenterCenter.Enabled = false;
            this.brdCenterCenter.Location = new System.Drawing.Point(93, 94);
            this.brdCenterCenter.Name = "brdCenterCenter";
            this.brdCenterCenter.Size = new System.Drawing.Size(75, 76);
            this.brdCenterCenter.TabIndex = 4;
            this.brdCenterCenter.UseVisualStyleBackColor = true;
            this.brdCenterCenter.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdCenterRight
            // 
            this.brdCenterRight.Enabled = false;
            this.brdCenterRight.Location = new System.Drawing.Point(174, 94);
            this.brdCenterRight.Name = "brdCenterRight";
            this.brdCenterRight.Size = new System.Drawing.Size(75, 76);
            this.brdCenterRight.TabIndex = 5;
            this.brdCenterRight.UseVisualStyleBackColor = true;
            this.brdCenterRight.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdBottomLeft
            // 
            this.brdBottomLeft.Enabled = false;
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
            this.brdBottomCenter.Enabled = false;
            this.brdBottomCenter.Location = new System.Drawing.Point(93, 176);
            this.brdBottomCenter.Name = "brdBottomCenter";
            this.brdBottomCenter.Size = new System.Drawing.Size(75, 76);
            this.brdBottomCenter.TabIndex = 7;
            this.brdBottomCenter.UseVisualStyleBackColor = true;
            this.brdBottomCenter.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // brdBottomRight
            // 
            this.brdBottomRight.Enabled = false;
            this.brdBottomRight.Location = new System.Drawing.Point(174, 176);
            this.brdBottomRight.Name = "brdBottomRight";
            this.brdBottomRight.Size = new System.Drawing.Size(75, 76);
            this.brdBottomRight.TabIndex = 8;
            this.brdBottomRight.UseVisualStyleBackColor = true;
            this.brdBottomRight.Click += new System.EventHandler(this.BrdButton_Click);
            // 
            // TimerBar
            // 
            this.TimerBar.Location = new System.Drawing.Point(255, 12);
            this.TimerBar.Name = "TimerBar";
            this.TimerBar.Size = new System.Drawing.Size(284, 23);
            this.TimerBar.TabIndex = 9;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 50;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnStart.Location = new System.Drawing.Point(263, 203);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(135, 49);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(404, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 49);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 264);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TimerBar);
            this.Controls.Add(this.brdBottomRight);
            this.Controls.Add(this.brdBottomCenter);
            this.Controls.Add(this.brdBottomLeft);
            this.Controls.Add(this.brdCenterRight);
            this.Controls.Add(this.brdCenterCenter);
            this.Controls.Add(this.brdCenterLeft);
            this.Controls.Add(this.brdTopRight);
            this.Controls.Add(this.brdTopCenter);
            this.Controls.Add(this.brdTopLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ProgressBar TimerBar;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button btnReset;
    }
}

