﻿namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            txtres = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            clear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(559, 18);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Сюда вводим числа";
            // 
            // txtres
            // 
            txtres.Dock = DockStyle.Top;
            txtres.Location = new Point(2, 18);
            txtres.Name = "txtres";
            txtres.Size = new Size(557, 23);
            txtres.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(485, 141);
            button1.Name = "button1";
            button1.Size = new Size(192, 25);
            button1.TabIndex = 1;
            button1.Text = "Решаем";
            button1.UseVisualStyleBackColor = true;
            button1.Click += resClick;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(clear);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtres);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(678, 227);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // clear
            // 
            clear.Location = new Point(485, 90);
            clear.Name = "clear";
            clear.Size = new Size(191, 23);
            clear.TabIndex = 3;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 227);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "№14";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Label label1;
        private TextBox txtres;
        private Button button1;
        private GroupBox groupBox1;
        private Button clear;
    }
}