﻿
namespace Тест_на_IQ
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_CheckResult = new System.Windows.Forms.Button();
            this.Nickname_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(40, 449);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(204, 68);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Начать тест";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CheckResult
            // 
            this.btn_CheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CheckResult.Location = new System.Drawing.Point(375, 425);
            this.btn_CheckResult.Name = "btn_CheckResult";
            this.btn_CheckResult.Size = new System.Drawing.Size(204, 68);
            this.btn_CheckResult.TabIndex = 1;
            this.btn_CheckResult.Text = "Посмотреть результаты";
            this.btn_CheckResult.UseVisualStyleBackColor = true;
            this.btn_CheckResult.Click += new System.EventHandler(this.btn_CheckResult_Click);
            // 
            // Nickname_textBox
            // 
            this.Nickname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname_textBox.Location = new System.Drawing.Point(40, 403);
            this.Nickname_textBox.Name = "Nickname_textBox";
            this.Nickname_textBox.Size = new System.Drawing.Size(204, 29);
            this.Nickname_textBox.TabIndex = 2;
            this.Nickname_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите свой ник:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тест на IQ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "../.../Resources/brain.png";
            this.pictureBox1.InitialImage = global::Тест_на_IQ.Properties.Resources.brain;
            this.pictureBox1.Location = new System.Drawing.Point(302, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 305);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 207);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname_textBox);
            this.Controls.Add(this.btn_CheckResult);
            this.Controls.Add(this.btn_Start);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_CheckResult;
        private System.Windows.Forms.TextBox Nickname_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}