using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
    partial class FormEventInfo
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormEventInfo));
            this.btOk = new Button();
            this.label1 = new Label();
            this.dtpEventDate = new DateTimePicker();
            this.tbEventInfo = new TextBox();
            this.label2 = new Label();
            this.gbContactInfo = new GroupBox();
            this.label3 = new Label();
            this.tbContactInfo = new TextBox();
            this.label4 = new Label();
            this.dtpBirthDate = new DateTimePicker();
            this.tbFio = new TextBox();
            this.label5 = new Label();
            this.gbContactInfo.SuspendLayout();
            this.SuspendLayout();
            this.btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btOk.DialogResult = DialogResult.Cancel;
            this.btOk.Location = new Point(222, 314);
            this.btOk.Name = "btOk";
            this.btOk.Size = new Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            this.dtpEventDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpEventDate.Format = DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new Point(109, 9);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new Size(125, 20);
            this.dtpEventDate.TabIndex = 0;
            this.tbEventInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tbEventInfo.Location = new Point(109, 35);
            this.tbEventInfo.Name = "tbEventInfo";
            this.tbEventInfo.Size = new Size(188, 20);
            this.tbEventInfo.TabIndex = 1;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Информация";
            this.gbContactInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gbContactInfo.Controls.Add((Control)this.label3);
            this.gbContactInfo.Controls.Add((Control)this.tbContactInfo);
            this.gbContactInfo.Controls.Add((Control)this.label4);
            this.gbContactInfo.Controls.Add((Control)this.dtpBirthDate);
            this.gbContactInfo.Controls.Add((Control)this.tbFio);
            this.gbContactInfo.Controls.Add((Control)this.label5);
            this.gbContactInfo.Location = new Point(12, 61);
            this.gbContactInfo.Name = "gbContactInfo";
            this.gbContactInfo.Size = new Size(291, 246);
            this.gbContactInfo.TabIndex = 2;
            this.gbContactInfo.TabStop = false;
            this.gbContactInfo.Text = "Контакт";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Инфо";
            this.tbContactInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tbContactInfo.Location = new Point(6, 80);
            this.tbContactInfo.Multiline = true;
            this.tbContactInfo.Name = "tbContactInfo";
            this.tbContactInfo.Size = new Size(279, 151);
            this.tbContactInfo.TabIndex = 5;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(4, 41);
            this.label4.Name = "label4";
            this.label4.Size = new Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            this.dtpBirthDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBirthDate.Format = DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new Point(96, 39);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new Size(126, 20);
            this.dtpBirthDate.TabIndex = 4;
            this.tbFio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tbFio.Location = new Point(97, 12);
            this.tbFio.Name = "tbFio";
            this.tbFio.Size = new Size(188, 20);
            this.tbFio.TabIndex = 3;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ФИО";
            this.AcceptButton = (IButtonControl)this.btOk;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = (IButtonControl)this.btOk;
            this.ClientSize = new Size(310, 349);
            this.Controls.Add((Control)this.gbContactInfo);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.tbEventInfo);
            this.Controls.Add((Control)this.dtpEventDate);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.btOk);
            this.Icon = Days.Properties.Resources.EventInfo;
            this.Name = "FormEventInfo";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Информация о событии";
            this.gbContactInfo.ResumeLayout(false);
            this.gbContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private Button btOk;
        private Label label1;
        private DateTimePicker dtpEventDate;
        private TextBox tbEventInfo;
        private Label label2;
        private GroupBox gbContactInfo;
        private Label label3;
        private TextBox tbContactInfo;
        private Label label4;
        private DateTimePicker dtpBirthDate;
        private TextBox tbFio;
        private Label label5;
    }
}
