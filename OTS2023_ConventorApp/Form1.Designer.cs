namespace OTS2023_ConventorApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCustomMoney = new System.Windows.Forms.RadioButton();
            this.rbtnTime = new System.Windows.Forms.RadioButton();
            this.rbtnMoney = new System.Windows.Forms.RadioButton();
            this.rbtnLength = new System.Windows.Forms.RadioButton();
            this.rbtnMass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbxTime = new System.Windows.Forms.GroupBox();
            this.rbtnSeconds = new System.Windows.Forms.RadioButton();
            this.rbtnMinutes = new System.Windows.Forms.RadioButton();
            this.rbtnHours = new System.Windows.Forms.RadioButton();
            this.grbxSegment = new System.Windows.Forms.GroupBox();
            this.rbtnArray = new System.Windows.Forms.RadioButton();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grbxTime.SuspendLayout();
            this.grbxSegment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCustomMoney);
            this.groupBox1.Controls.Add(this.rbtnTime);
            this.groupBox1.Controls.Add(this.rbtnMoney);
            this.groupBox1.Controls.Add(this.rbtnLength);
            this.groupBox1.Controls.Add(this.rbtnMass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter type";
            // 
            // rbtnCustomMoney
            // 
            this.rbtnCustomMoney.AutoSize = true;
            this.rbtnCustomMoney.Location = new System.Drawing.Point(47, 116);
            this.rbtnCustomMoney.Name = "rbtnCustomMoney";
            this.rbtnCustomMoney.Size = new System.Drawing.Size(142, 24);
            this.rbtnCustomMoney.TabIndex = 4;
            this.rbtnCustomMoney.TabStop = true;
            this.rbtnCustomMoney.Text = "Custom Money";
            this.rbtnCustomMoney.UseVisualStyleBackColor = true;
            this.rbtnCustomMoney.CheckedChanged += new System.EventHandler(this.rbtnCustomMoney_CheckedChanged);
            // 
            // rbtnTime
            // 
            this.rbtnTime.AutoSize = true;
            this.rbtnTime.Location = new System.Drawing.Point(143, 71);
            this.rbtnTime.Name = "rbtnTime";
            this.rbtnTime.Size = new System.Drawing.Size(67, 24);
            this.rbtnTime.TabIndex = 3;
            this.rbtnTime.TabStop = true;
            this.rbtnTime.Text = "Time";
            this.rbtnTime.UseVisualStyleBackColor = true;
            this.rbtnTime.CheckedChanged += new System.EventHandler(this.rbtnTime_CheckedChanged);
            // 
            // rbtnMoney
            // 
            this.rbtnMoney.AutoSize = true;
            this.rbtnMoney.Location = new System.Drawing.Point(143, 30);
            this.rbtnMoney.Name = "rbtnMoney";
            this.rbtnMoney.Size = new System.Drawing.Size(79, 24);
            this.rbtnMoney.TabIndex = 2;
            this.rbtnMoney.TabStop = true;
            this.rbtnMoney.Text = "Money";
            this.rbtnMoney.UseVisualStyleBackColor = true;
            this.rbtnMoney.CheckedChanged += new System.EventHandler(this.rbtnMoney_CheckedChanged);
            // 
            // rbtnLength
            // 
            this.rbtnLength.AutoSize = true;
            this.rbtnLength.Location = new System.Drawing.Point(17, 67);
            this.rbtnLength.Name = "rbtnLength";
            this.rbtnLength.Size = new System.Drawing.Size(81, 24);
            this.rbtnLength.TabIndex = 1;
            this.rbtnLength.TabStop = true;
            this.rbtnLength.Text = "Length";
            this.rbtnLength.UseVisualStyleBackColor = true;
            this.rbtnLength.CheckedChanged += new System.EventHandler(this.rbtnLength_CheckedChanged);
            // 
            // rbtnMass
            // 
            this.rbtnMass.AutoSize = true;
            this.rbtnMass.Location = new System.Drawing.Point(17, 27);
            this.rbtnMass.Name = "rbtnMass";
            this.rbtnMass.Size = new System.Drawing.Size(71, 24);
            this.rbtnMass.TabIndex = 0;
            this.rbtnMass.TabStop = true;
            this.rbtnMass.Text = "Mass";
            this.rbtnMass.UseVisualStyleBackColor = true;
            this.rbtnMass.CheckedChanged += new System.EventHandler(this.rbtnMass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(321, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbxTime
            // 
            this.grbxTime.Controls.Add(this.rbtnSeconds);
            this.grbxTime.Controls.Add(this.rbtnMinutes);
            this.grbxTime.Controls.Add(this.rbtnHours);
            this.grbxTime.Location = new System.Drawing.Point(321, 12);
            this.grbxTime.Name = "grbxTime";
            this.grbxTime.Size = new System.Drawing.Size(224, 149);
            this.grbxTime.TabIndex = 6;
            this.grbxTime.TabStop = false;
            this.grbxTime.Text = "Time Output";
            this.grbxTime.Visible = false;
            // 
            // rbtnSeconds
            // 
            this.rbtnSeconds.AutoSize = true;
            this.rbtnSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSeconds.Location = new System.Drawing.Point(19, 104);
            this.rbtnSeconds.Name = "rbtnSeconds";
            this.rbtnSeconds.Size = new System.Drawing.Size(95, 24);
            this.rbtnSeconds.TabIndex = 2;
            this.rbtnSeconds.TabStop = true;
            this.rbtnSeconds.Text = "Seconds";
            this.rbtnSeconds.UseVisualStyleBackColor = true;
            this.rbtnSeconds.CheckedChanged += new System.EventHandler(this.rbtnSeconds_CheckedChanged);
            // 
            // rbtnMinutes
            // 
            this.rbtnMinutes.AutoSize = true;
            this.rbtnMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMinutes.Location = new System.Drawing.Point(19, 62);
            this.rbtnMinutes.Name = "rbtnMinutes";
            this.rbtnMinutes.Size = new System.Drawing.Size(89, 24);
            this.rbtnMinutes.TabIndex = 1;
            this.rbtnMinutes.TabStop = true;
            this.rbtnMinutes.Text = "Minutes";
            this.rbtnMinutes.UseVisualStyleBackColor = true;
            this.rbtnMinutes.CheckedChanged += new System.EventHandler(this.rbtnMinutes_CheckedChanged);
            // 
            // rbtnHours
            // 
            this.rbtnHours.AutoSize = true;
            this.rbtnHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHours.Location = new System.Drawing.Point(19, 22);
            this.rbtnHours.Name = "rbtnHours";
            this.rbtnHours.Size = new System.Drawing.Size(76, 24);
            this.rbtnHours.TabIndex = 0;
            this.rbtnHours.TabStop = true;
            this.rbtnHours.Text = "Hours";
            this.rbtnHours.UseVisualStyleBackColor = true;
            this.rbtnHours.CheckedChanged += new System.EventHandler(this.rbtnHours_CheckedChanged);
            // 
            // grbxSegment
            // 
            this.grbxSegment.Controls.Add(this.rbtnArray);
            this.grbxSegment.Controls.Add(this.rbtnSingle);
            this.grbxSegment.Location = new System.Drawing.Point(568, 12);
            this.grbxSegment.Name = "grbxSegment";
            this.grbxSegment.Size = new System.Drawing.Size(209, 149);
            this.grbxSegment.TabIndex = 7;
            this.grbxSegment.TabStop = false;
            this.grbxSegment.Text = "Segment Type";
            this.grbxSegment.Visible = false;
            // 
            // rbtnArray
            // 
            this.rbtnArray.AutoSize = true;
            this.rbtnArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnArray.Location = new System.Drawing.Point(22, 74);
            this.rbtnArray.Name = "rbtnArray";
            this.rbtnArray.Size = new System.Drawing.Size(142, 24);
            this.rbtnArray.TabIndex = 1;
            this.rbtnArray.TabStop = true;
            this.rbtnArray.Text = "Array of values";
            this.rbtnArray.UseVisualStyleBackColor = true;
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSingle.Location = new System.Drawing.Point(22, 33);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(120, 24);
            this.rbtnSingle.TabIndex = 0;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single value";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 447);
            this.Controls.Add(this.grbxSegment);
            this.Controls.Add(this.grbxTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxTime.ResumeLayout(false);
            this.grbxTime.PerformLayout();
            this.grbxSegment.ResumeLayout(false);
            this.grbxSegment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnLength;
        private System.Windows.Forms.RadioButton rbtnMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnCustomMoney;
        private System.Windows.Forms.RadioButton rbtnTime;
        private System.Windows.Forms.RadioButton rbtnMoney;
        private System.Windows.Forms.GroupBox grbxTime;
        private System.Windows.Forms.RadioButton rbtnSeconds;
        private System.Windows.Forms.RadioButton rbtnMinutes;
        private System.Windows.Forms.RadioButton rbtnHours;
        private System.Windows.Forms.GroupBox grbxSegment;
        private System.Windows.Forms.RadioButton rbtnArray;
        private System.Windows.Forms.RadioButton rbtnSingle;
    }
}

