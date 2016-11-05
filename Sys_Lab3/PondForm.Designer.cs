namespace Sys_Lab3
{
    partial class PondForm
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
            this.pictureBoxPond = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelStep = new System.Windows.Forms.Label();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.buttonStep = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPond
            // 
            this.pictureBoxPond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPond.Location = new System.Drawing.Point(10, 130);
            this.pictureBoxPond.Name = "pictureBoxPond";
            this.pictureBoxPond.Size = new System.Drawing.Size(493, 56);
            this.pictureBoxPond.TabIndex = 0;
            this.pictureBoxPond.TabStop = false;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.Location = new System.Drawing.Point(17, 16);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(67, 20);
            this.labelStep.TabIndex = 1;
            this.labelStep.Text = "Такт №:";
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Location = new System.Drawing.Point(12, 52);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(104, 23);
            this.buttonStartPause.TabIndex = 2;
            this.buttonStartPause.Text = "Старт";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(155, 35);
            this.trackBarSpeed.Maximum = 500;
            this.trackBarSpeed.Minimum = 10;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(347, 45);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Tag = "";
            this.trackBarSpeed.TickFrequency = 10;
            this.trackBarSpeed.Value = 10;
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(12, 86);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(104, 23);
            this.buttonStep.TabIndex = 4;
            this.buttonStep.Text = "На крок вперед";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(221, 16);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(225, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Інтервал між тактами (від 10 мс до 500 мс)";
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(155, 86);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(347, 23);
            this.buttonStats.TabIndex = 6;
            this.buttonStats.Text = "Статистика";
            this.buttonStats.UseVisualStyleBackColor = true;
            // 
            // PondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 254);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.pictureBoxPond);
            this.Name = "PondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделювання поведінки риб";
            this.Load += new System.EventHandler(this.PondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button buttonStats;
    }
}