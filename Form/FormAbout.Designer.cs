using Days.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Days
{
    partial class FormAbout
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormAbout));
            this.label1 = new Label();
            this.label3 = new Label();
            this.label5 = new Label();
            this.btOk = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.tbVersion = new TextBox();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Версия:";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес для связи";
            this.btOk.DialogResult = DialogResult.Cancel;
            this.btOk.Location = new Point(95, 112);
            this.btOk.Name = "btOk";
            this.btOk.Size = new Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.textBox1.BorderStyle = BorderStyle.None;
            this.textBox1.Location = new Point(123, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(100, 13);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "glumist@gmail.com";
            this.textBox2.BorderStyle = BorderStyle.None;
            this.textBox2.Location = new Point(123, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(140, 13);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Александр 'Glum' Торбин";
            this.tbVersion.BorderStyle = BorderStyle.None;
            this.tbVersion.Location = new Point(123, 30);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.ReadOnly = true;
            this.tbVersion.Size = new Size(140, 13);
            this.tbVersion.TabIndex = 9;
            this.tbVersion.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = (IButtonControl)this.btOk;
            this.ClientSize = new Size(275, 152);
            this.Controls.Add((Control)this.tbVersion);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.btOk);
            this.Controls.Add((Control)this.label5);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Days.Properties.Resources.about;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label label1;
        private Label label3;
        private Label label5;
        private Button btOk;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tbVersion;
    }
}
