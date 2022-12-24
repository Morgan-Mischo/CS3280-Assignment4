
namespace CS3280_Assignment4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.game_status = new System.Windows.Forms.GroupBox();
            this.game_status_text = new System.Windows.Forms.Label();
            this.statistics = new System.Windows.Forms.GroupBox();
            this.statistics_text = new System.Windows.Forms.Label();
            this.start_game_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.game_status.SuspendLayout();
            this.statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 10);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 10);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 260);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(191, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 260);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // game_status
            // 
            this.game_status.Controls.Add(this.game_status_text);
            this.game_status.Location = new System.Drawing.Point(22, 306);
            this.game_status.Name = "game_status";
            this.game_status.Size = new System.Drawing.Size(200, 100);
            this.game_status.TabIndex = 6;
            this.game_status.TabStop = false;
            this.game_status.Text = "Game Status";
            // 
            // game_status_text
            // 
            this.game_status_text.BackColor = System.Drawing.Color.PowderBlue;
            this.game_status_text.Location = new System.Drawing.Point(15, 26);
            this.game_status_text.Name = "game_status_text";
            this.game_status_text.Size = new System.Drawing.Size(166, 58);
            this.game_status_text.TabIndex = 7;
            this.game_status_text.Text = "game_status_text";
            // 
            // statistics
            // 
            this.statistics.Controls.Add(this.statistics_text);
            this.statistics.Location = new System.Drawing.Point(346, 79);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(200, 100);
            this.statistics.TabIndex = 8;
            this.statistics.TabStop = false;
            this.statistics.Text = "Statistics";
            // 
            // statistics_text
            // 
            this.statistics_text.BackColor = System.Drawing.Color.PowderBlue;
            this.statistics_text.Location = new System.Drawing.Point(15, 26);
            this.statistics_text.Name = "statistics_text";
            this.statistics_text.Size = new System.Drawing.Size(166, 58);
            this.statistics_text.TabIndex = 7;
            this.statistics_text.Text = "statistics_text";
            // 
            // start_game_btn
            // 
            this.start_game_btn.BackColor = System.Drawing.Color.LightGray;
            this.start_game_btn.Location = new System.Drawing.Point(403, 30);
            this.start_game_btn.Name = "start_game_btn";
            this.start_game_btn.Size = new System.Drawing.Size(75, 23);
            this.start_game_btn.TabIndex = 9;
            this.start_game_btn.Text = "Start Game";
            this.start_game_btn.UseVisualStyleBackColor = false;
            this.start_game_btn.Click += new System.EventHandler(this.startGame);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 77);
            this.button1.TabIndex = 10;
            this.button1.Tag = "play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 77);
            this.button2.TabIndex = 11;
            this.button2.Tag = "play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 77);
            this.button3.TabIndex = 12;
            this.button3.Tag = "play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 77);
            this.button4.TabIndex = 13;
            this.button4.Tag = "play";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 77);
            this.button5.TabIndex = 14;
            this.button5.Tag = "play";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(207, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 77);
            this.button6.TabIndex = 15;
            this.button6.Tag = "play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 77);
            this.button7.TabIndex = 16;
            this.button7.Tag = "play";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 77);
            this.button8.TabIndex = 17;
            this.button8.Tag = "play";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(207, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 77);
            this.button9.TabIndex = 18;
            this.button9.Tag = "play";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // AImoves
            // 
            this.AImoves.Interval = 1000;
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_game_btn);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.game_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.game_status.ResumeLayout(false);
            this.statistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox game_status;
        private System.Windows.Forms.Label game_status_text;
        private System.Windows.Forms.GroupBox statistics;
        private System.Windows.Forms.Label statistics_text;
        private System.Windows.Forms.Button start_game_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer AImoves;
    }
}

