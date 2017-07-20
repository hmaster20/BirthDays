using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
  partial  class FormChangeHour
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
            this.rbForward = new RadioButton();
            this.rbBackward = new RadioButton();
            this.dtpTimeShift = new DateTimePicker();
            this.btOk = new Button();
            this.btCancel = new Button();
            this.SuspendLayout();
            this.rbForward.AutoSize = true;
            this.rbForward.Checked = true;
            this.rbForward.Location = new Point(19, 11);
            this.rbForward.Name = "rbForward";
            this.rbForward.Size = new Size(62, 17);
            this.rbForward.TabIndex = 0;
            this.rbForward.TabStop = true;
            this.rbForward.Text = "Вперед";
            this.rbForward.UseVisualStyleBackColor = true;
            this.rbBackward.AutoSize = true;
            this.rbBackward.Location = new Point(19, 34);
            this.rbBackward.Name = "rbBackward";
            this.rbBackward.Size = new Size(57, 17);
            this.rbBackward.TabIndex = 1;
            this.rbBackward.Text = "Назад";
            this.rbBackward.UseVisualStyleBackColor = true;
            this.dtpTimeShift.CustomFormat = "HH:mm";
            this.dtpTimeShift.Format = DateTimePickerFormat.Custom;
            this.dtpTimeShift.Location = new Point(102, 21);
            this.dtpTimeShift.Name = "dtpTimeShift";
            this.dtpTimeShift.ShowUpDown = true;
            this.dtpTimeShift.Size = new Size(53, 20);
            this.dtpTimeShift.TabIndex = 2;
            this.dtpTimeShift.Value = new DateTime(2015, 11, 13, 0, 0, 0, 0);
            this.btOk.Location = new Point(12, 57);
            this.btOk.Name = "btOk";
            this.btOk.Size = new Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new EventHandler(this.btOk_Click);
            this.btCancel.Location = new Point(93, 57);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = (IButtonControl)this.btCancel;
            this.ClientSize = new Size(187, 87);
            this.Controls.Add((Control)this.btCancel);
            this.Controls.Add((Control)this.btOk);
            this.Controls.Add((Control)this.dtpTimeShift);
            this.Controls.Add((Control)this.rbBackward);
            this.Controls.Add((Control)this.rbForward);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeHour";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Смена часового пояса";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public bool Forward = true;
        public TimeSpan TimeShift = TimeSpan.Zero;
        private RadioButton rbForward;
        private RadioButton rbBackward;
        private DateTimePicker dtpTimeShift;
        private Button btOk;
        private Button btCancel;

    }
}
