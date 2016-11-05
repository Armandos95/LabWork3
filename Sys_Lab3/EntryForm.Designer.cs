namespace Sys_Lab3
{
    partial class EntryForm
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
            this.textBoxSizeX = new System.Windows.Forms.TextBox();
            this.labelSizeX = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSizeY = new System.Windows.Forms.Label();
            this.labelPreyAmount = new System.Windows.Forms.Label();
            this.labelPreyStart = new System.Windows.Forms.Label();
            this.labelPreyPeriod = new System.Windows.Forms.Label();
            this.labelPredatorAmount = new System.Windows.Forms.Label();
            this.labelPredatorStart = new System.Windows.Forms.Label();
            this.labelPredatorPeriod = new System.Windows.Forms.Label();
            this.labelPredatorStarve = new System.Windows.Forms.Label();
            this.textBoxSizeY = new System.Windows.Forms.TextBox();
            this.textBoxPreyAmount = new System.Windows.Forms.TextBox();
            this.textBoxPreyStart = new System.Windows.Forms.TextBox();
            this.textBoxPreyPeriod = new System.Windows.Forms.TextBox();
            this.textBoxPredatorAmount = new System.Windows.Forms.TextBox();
            this.textBoxPredatorStart = new System.Windows.Forms.TextBox();
            this.textBoxPredatorPeriod = new System.Windows.Forms.TextBox();
            this.textBoxPredatorStarve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSizeX
            // 
            this.textBoxSizeX.Location = new System.Drawing.Point(240, 17);
            this.textBoxSizeX.Name = "textBoxSizeX";
            this.textBoxSizeX.Size = new System.Drawing.Size(100, 20);
            this.textBoxSizeX.TabIndex = 0;
            this.textBoxSizeX.Text = "100";
            // 
            // labelSizeX
            // 
            this.labelSizeX.AutoSize = true;
            this.labelSizeX.Location = new System.Drawing.Point(20, 20);
            this.labelSizeX.Name = "labelSizeX";
            this.labelSizeX.Size = new System.Drawing.Size(95, 13);
            this.labelSizeX.TabIndex = 1;
            this.labelSizeX.Text = "Розмір сітки по X";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(23, 297);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(317, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSizeY
            // 
            this.labelSizeY.AutoSize = true;
            this.labelSizeY.Location = new System.Drawing.Point(20, 50);
            this.labelSizeY.Name = "labelSizeY";
            this.labelSizeY.Size = new System.Drawing.Size(95, 13);
            this.labelSizeY.TabIndex = 3;
            this.labelSizeY.Text = "Розмір сітки по Y";
            // 
            // labelPreyAmount
            // 
            this.labelPreyAmount.AutoSize = true;
            this.labelPreyAmount.Location = new System.Drawing.Point(20, 80);
            this.labelPreyAmount.Name = "labelPreyAmount";
            this.labelPreyAmount.Size = new System.Drawing.Size(87, 13);
            this.labelPreyAmount.TabIndex = 4;
            this.labelPreyAmount.Text = "Кількість жертв";
            // 
            // labelPreyStart
            // 
            this.labelPreyStart.AutoSize = true;
            this.labelPreyStart.Location = new System.Drawing.Point(20, 110);
            this.labelPreyStart.Name = "labelPreyStart";
            this.labelPreyStart.Size = new System.Drawing.Size(191, 13);
            this.labelPreyStart.TabIndex = 7;
            this.labelPreyStart.Text = "Початковий вік розмноження жертв";
            // 
            // labelPreyPeriod
            // 
            this.labelPreyPeriod.AutoSize = true;
            this.labelPreyPeriod.Location = new System.Drawing.Point(20, 140);
            this.labelPreyPeriod.Name = "labelPreyPeriod";
            this.labelPreyPeriod.Size = new System.Drawing.Size(148, 13);
            this.labelPreyPeriod.TabIndex = 6;
            this.labelPreyPeriod.Text = "Період розмноження жертв";
            // 
            // labelPredatorAmount
            // 
            this.labelPredatorAmount.AutoSize = true;
            this.labelPredatorAmount.Location = new System.Drawing.Point(20, 170);
            this.labelPredatorAmount.Name = "labelPredatorAmount";
            this.labelPredatorAmount.Size = new System.Drawing.Size(95, 13);
            this.labelPredatorAmount.TabIndex = 5;
            this.labelPredatorAmount.Text = "Кількість хижаків";
            // 
            // labelPredatorStart
            // 
            this.labelPredatorStart.AutoSize = true;
            this.labelPredatorStart.Location = new System.Drawing.Point(20, 200);
            this.labelPredatorStart.Name = "labelPredatorStart";
            this.labelPredatorStart.Size = new System.Drawing.Size(199, 13);
            this.labelPredatorStart.TabIndex = 10;
            this.labelPredatorStart.Text = "Початковий вік розмноження хижаків";
            // 
            // labelPredatorPeriod
            // 
            this.labelPredatorPeriod.AutoSize = true;
            this.labelPredatorPeriod.Location = new System.Drawing.Point(20, 230);
            this.labelPredatorPeriod.Name = "labelPredatorPeriod";
            this.labelPredatorPeriod.Size = new System.Drawing.Size(156, 13);
            this.labelPredatorPeriod.TabIndex = 9;
            this.labelPredatorPeriod.Text = "Період розмноження хижаків";
            // 
            // labelPredatorStarve
            // 
            this.labelPredatorStarve.AutoSize = true;
            this.labelPredatorStarve.Location = new System.Drawing.Point(20, 260);
            this.labelPredatorStarve.Name = "labelPredatorStarve";
            this.labelPredatorStarve.Size = new System.Drawing.Size(107, 13);
            this.labelPredatorStarve.TabIndex = 8;
            this.labelPredatorStarve.Text = "Хижак живе без їжї";
            // 
            // textBoxSizeY
            // 
            this.textBoxSizeY.Location = new System.Drawing.Point(240, 47);
            this.textBoxSizeY.Name = "textBoxSizeY";
            this.textBoxSizeY.Size = new System.Drawing.Size(100, 20);
            this.textBoxSizeY.TabIndex = 1;
            this.textBoxSizeY.Text = "100";
            // 
            // textBoxPreyAmount
            // 
            this.textBoxPreyAmount.Location = new System.Drawing.Point(240, 77);
            this.textBoxPreyAmount.Name = "textBoxPreyAmount";
            this.textBoxPreyAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreyAmount.TabIndex = 2;
            this.textBoxPreyAmount.Text = "5000";
            // 
            // textBoxPreyStart
            // 
            this.textBoxPreyStart.Location = new System.Drawing.Point(240, 107);
            this.textBoxPreyStart.Name = "textBoxPreyStart";
            this.textBoxPreyStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreyStart.TabIndex = 3;
            this.textBoxPreyStart.Text = "3";
            // 
            // textBoxPreyPeriod
            // 
            this.textBoxPreyPeriod.Location = new System.Drawing.Point(240, 137);
            this.textBoxPreyPeriod.Name = "textBoxPreyPeriod";
            this.textBoxPreyPeriod.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreyPeriod.TabIndex = 4;
            this.textBoxPreyPeriod.Text = "3";
            // 
            // textBoxPredatorAmount
            // 
            this.textBoxPredatorAmount.Location = new System.Drawing.Point(240, 167);
            this.textBoxPredatorAmount.Name = "textBoxPredatorAmount";
            this.textBoxPredatorAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPredatorAmount.TabIndex = 5;
            this.textBoxPredatorAmount.Text = "200";
            // 
            // textBoxPredatorStart
            // 
            this.textBoxPredatorStart.Location = new System.Drawing.Point(240, 197);
            this.textBoxPredatorStart.Name = "textBoxPredatorStart";
            this.textBoxPredatorStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPredatorStart.TabIndex = 6;
            this.textBoxPredatorStart.Text = "9";
            // 
            // textBoxPredatorPeriod
            // 
            this.textBoxPredatorPeriod.Location = new System.Drawing.Point(240, 227);
            this.textBoxPredatorPeriod.Name = "textBoxPredatorPeriod";
            this.textBoxPredatorPeriod.Size = new System.Drawing.Size(100, 20);
            this.textBoxPredatorPeriod.TabIndex = 7;
            this.textBoxPredatorPeriod.Text = "9";
            // 
            // textBoxPredatorStarve
            // 
            this.textBoxPredatorStarve.Location = new System.Drawing.Point(240, 257);
            this.textBoxPredatorStarve.Name = "textBoxPredatorStarve";
            this.textBoxPredatorStarve.Size = new System.Drawing.Size(100, 20);
            this.textBoxPredatorStarve.TabIndex = 8;
            this.textBoxPredatorStarve.Text = "4";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 337);
            this.Controls.Add(this.textBoxPredatorStart);
            this.Controls.Add(this.textBoxPredatorPeriod);
            this.Controls.Add(this.textBoxPredatorStarve);
            this.Controls.Add(this.textBoxPreyStart);
            this.Controls.Add(this.textBoxPreyPeriod);
            this.Controls.Add(this.textBoxPredatorAmount);
            this.Controls.Add(this.textBoxPreyAmount);
            this.Controls.Add(this.textBoxSizeY);
            this.Controls.Add(this.labelPredatorStart);
            this.Controls.Add(this.labelPredatorPeriod);
            this.Controls.Add(this.labelPredatorStarve);
            this.Controls.Add(this.labelPreyStart);
            this.Controls.Add(this.labelPreyPeriod);
            this.Controls.Add(this.labelPredatorAmount);
            this.Controls.Add(this.labelPreyAmount);
            this.Controls.Add(this.labelSizeY);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSizeX);
            this.Controls.Add(this.textBoxSizeX);
            this.Name = "EntryForm";
            this.Text = "Задання параметрів";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSizeX;
        private System.Windows.Forms.Label labelSizeX;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSizeY;
        private System.Windows.Forms.Label labelPreyAmount;
        private System.Windows.Forms.Label labelPreyStart;
        private System.Windows.Forms.Label labelPreyPeriod;
        private System.Windows.Forms.Label labelPredatorAmount;
        private System.Windows.Forms.Label labelPredatorStart;
        private System.Windows.Forms.Label labelPredatorPeriod;
        private System.Windows.Forms.Label labelPredatorStarve;
        private System.Windows.Forms.TextBox textBoxSizeY;
        private System.Windows.Forms.TextBox textBoxPreyAmount;
        private System.Windows.Forms.TextBox textBoxPreyStart;
        private System.Windows.Forms.TextBox textBoxPreyPeriod;
        private System.Windows.Forms.TextBox textBoxPredatorAmount;
        private System.Windows.Forms.TextBox textBoxPredatorStart;
        private System.Windows.Forms.TextBox textBoxPredatorPeriod;
        private System.Windows.Forms.TextBox textBoxPredatorStarve;
    }
}

