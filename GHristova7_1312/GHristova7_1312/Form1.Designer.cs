
namespace GHristova7_1312
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_morning = new System.Windows.Forms.RadioButton();
            this.rb_afternoon = new System.Windows.Forms.RadioButton();
            this.rb_night = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_cal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_sport = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Време за трениране в минути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид спорт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кога ще тренирате";
            // 
            // rb_morning
            // 
            this.rb_morning.AutoSize = true;
            this.rb_morning.Location = new System.Drawing.Point(333, 228);
            this.rb_morning.Name = "rb_morning";
            this.rb_morning.Size = new System.Drawing.Size(110, 21);
            this.rb_morning.TabIndex = 3;
            this.rb_morning.TabStop = true;
            this.rb_morning.Text = "рано сутрин";
            this.rb_morning.UseVisualStyleBackColor = true;
            // 
            // rb_afternoon
            // 
            this.rb_afternoon.AutoSize = true;
            this.rb_afternoon.Location = new System.Drawing.Point(333, 298);
            this.rb_afternoon.Name = "rb_afternoon";
            this.rb_afternoon.Size = new System.Drawing.Size(96, 21);
            this.rb_afternoon.TabIndex = 4;
            this.rb_afternoon.TabStop = true;
            this.rb_afternoon.Text = "през деня";
            this.rb_afternoon.UseVisualStyleBackColor = true;
            // 
            // rb_night
            // 
            this.rb_night.AutoSize = true;
            this.rb_night.Location = new System.Drawing.Point(333, 365);
            this.rb_night.Name = "rb_night";
            this.rb_night.Size = new System.Drawing.Size(68, 21);
            this.rb_night.TabIndex = 5;
            this.rb_night.TabStop = true;
            this.rb_night.Text = "вечер";
            this.rb_night.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Изразходени калории";
            // 
            // lb_cal
            // 
            this.lb_cal.AutoSize = true;
            this.lb_cal.Location = new System.Drawing.Point(491, 455);
            this.lb_cal.Name = "lb_cal";
            this.lb_cal.Size = new System.Drawing.Size(46, 17);
            this.lb_cal.TabIndex = 7;
            this.lb_cal.Text = "label5";
            this.lb_cal.Click += new System.EventHandler(this.lb_cal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вие избрахте да тренирате:";
            // 
            // lb_sport
            // 
            this.lb_sport.AutoSize = true;
            this.lb_sport.Location = new System.Drawing.Point(494, 555);
            this.lb_sport.Name = "lb_sport";
            this.lb_sport.Size = new System.Drawing.Size(46, 17);
            this.lb_sport.TabIndex = 9;
            this.lb_sport.Text = "label7";
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(388, 90);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(100, 22);
            this.tb_time.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Плуване",
            "Бягане",
            "Ходене",
            "Колоездене"});
            this.comboBox1.Location = new System.Drawing.Point(388, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Изчисли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.lb_sport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_cal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_night);
            this.Controls.Add(this.rb_afternoon);
            this.Controls.Add(this.rb_morning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_morning;
        private System.Windows.Forms.RadioButton rb_afternoon;
        private System.Windows.Forms.RadioButton rb_night;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_cal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_sport;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

