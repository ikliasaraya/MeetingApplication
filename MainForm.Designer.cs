namespace MeetingApplication
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCalender = new System.Windows.Forms.MonthCalendar();
            this.olustur = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.joinBtn = new System.Windows.Forms.Button();
            this.invCodeTxt = new System.Windows.Forms.TextBox();
            this.selectUserBox = new System.Windows.Forms.CheckedListBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.toplantilar = new System.Windows.Forms.GroupBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.mList = new System.Windows.Forms.ListView();
            this.meetingCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meetingTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meetingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meetingDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.olustur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toplantilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameBtn);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 34);
            this.panel1.TabIndex = 0;
            // 
            // nameBtn
            // 
            this.nameBtn.Location = new System.Drawing.Point(131, 3);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(79, 27);
            this.nameBtn.TabIndex = 2;
            this.nameBtn.Text = "Giriş";
            this.nameBtn.UseVisualStyleBackColor = true;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(3, 3);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(122, 27);
            this.nameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateCalender
            // 
            this.dateCalender.Location = new System.Drawing.Point(234, 70);
            this.dateCalender.Name = "dateCalender";
            this.dateCalender.TabIndex = 2;
            this.dateCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dateCalender_DateSelected);
            // 
            // olustur
            // 
            this.olustur.Controls.Add(this.groupBox3);
            this.olustur.Controls.Add(this.selectUserBox);
            this.olustur.Controls.Add(this.descTxt);
            this.olustur.Controls.Add(this.label3);
            this.olustur.Controls.Add(this.label2);
            this.olustur.Controls.Add(this.dateCalender);
            this.olustur.Controls.Add(this.titleTxt);
            this.olustur.Controls.Add(this.createBtn);
            this.olustur.Location = new System.Drawing.Point(969, 12);
            this.olustur.Name = "olustur";
            this.olustur.Size = new System.Drawing.Size(501, 437);
            this.olustur.TabIndex = 3;
            this.olustur.TabStop = false;
            this.olustur.Text = "Toplantı Oluştur";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.joinBtn);
            this.groupBox3.Controls.Add(this.invCodeTxt);
            this.groupBox3.Location = new System.Drawing.Point(234, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 61);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Davet Kodu ile Toplantıya Katıl";
            // 
            // joinBtn
            // 
            this.joinBtn.Location = new System.Drawing.Point(169, 21);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(80, 29);
            this.joinBtn.TabIndex = 1;
            this.joinBtn.Text = "Katıl";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // invCodeTxt
            // 
            this.invCodeTxt.Location = new System.Drawing.Point(6, 21);
            this.invCodeTxt.Multiline = true;
            this.invCodeTxt.Name = "invCodeTxt";
            this.invCodeTxt.Size = new System.Drawing.Size(157, 29);
            this.invCodeTxt.TabIndex = 0;
            // 
            // selectUserBox
            // 
            this.selectUserBox.FormattingEnabled = true;
            this.selectUserBox.Location = new System.Drawing.Point(9, 280);
            this.selectUserBox.Name = "selectUserBox";
            this.selectUserBox.Size = new System.Drawing.Size(196, 140);
            this.selectUserBox.TabIndex = 9;
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(9, 95);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(196, 173);
            this.descTxt.TabIndex = 9;
            this.descTxt.MouseEnter += new System.EventHandler(this.descTxt_MouseEnter);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toplantı açıklaması:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplantı başlığı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(124, 28);
            this.titleTxt.Multiline = true;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(365, 30);
            this.titleTxt.TabIndex = 5;
            this.titleTxt.MouseEnter += new System.EventHandler(this.titleTxt_MouseEnter);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(234, 280);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(255, 31);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Oluştur";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            this.createBtn.MouseEnter += new System.EventHandler(this.createBtn_MouseEnter);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(253, 317);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 16);
            this.test.TabIndex = 4;
            // 
            // toplantilar
            // 
            this.toplantilar.Controls.Add(this.searchLbl);
            this.toplantilar.Controls.Add(this.searchTxt);
            this.toplantilar.Controls.Add(this.mList);
            this.toplantilar.Location = new System.Drawing.Point(307, 12);
            this.toplantilar.Name = "toplantilar";
            this.toplantilar.Size = new System.Drawing.Size(647, 352);
            this.toplantilar.TabIndex = 5;
            this.toplantilar.TabStop = false;
            this.toplantilar.Text = "Toplantılar";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(3, 320);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(249, 16);
            this.searchLbl.TabIndex = 6;
            this.searchLbl.Text = "Bir toplantı özelliğine göre toplantı arayın:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(271, 317);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(370, 28);
            this.searchTxt.TabIndex = 7;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // mList
            // 
            this.mList.CheckBoxes = true;
            this.mList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.meetingCode,
            this.meetingTitle,
            this.meetingDate,
            this.meetingDesc,
            this.partic});
            this.mList.GridLines = true;
            this.mList.HideSelection = false;
            this.mList.Location = new System.Drawing.Point(6, 21);
            this.mList.Name = "mList";
            this.mList.Size = new System.Drawing.Size(635, 290);
            this.mList.TabIndex = 0;
            this.mList.UseCompatibleStateImageBehavior = false;
            this.mList.View = System.Windows.Forms.View.Details;
            this.mList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mList_ItemSelectionChanged);
            // 
            // meetingCode
            // 
            this.meetingCode.Text = "Toplantı Kodu";
            this.meetingCode.Width = 120;
            // 
            // meetingTitle
            // 
            this.meetingTitle.Text = "Toplantı Başlığı";
            this.meetingTitle.Width = 120;
            // 
            // meetingDate
            // 
            this.meetingDate.Text = "Toplantı Tarihi";
            this.meetingDate.Width = 108;
            // 
            // meetingDesc
            // 
            this.meetingDesc.Text = "Açıklama";
            this.meetingDesc.Width = 97;
            // 
            // partic
            // 
            this.partic.Text = "Katılımcı";
            this.partic.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1482, 755);
            this.Controls.Add(this.toplantilar);
            this.Controls.Add(this.test);
            this.Controls.Add(this.olustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Toplantı Uygulaması";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.olustur.ResumeLayout(false);
            this.olustur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toplantilar.ResumeLayout(false);
            this.toplantilar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button nameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar dateCalender;
        private System.Windows.Forms.GroupBox olustur;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.GroupBox toplantilar;
        private System.Windows.Forms.ListView mList;
        private System.Windows.Forms.ColumnHeader meetingCode;
        private System.Windows.Forms.ColumnHeader meetingTitle;
        private System.Windows.Forms.ColumnHeader meetingDate;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ColumnHeader meetingDesc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.TextBox invCodeTxt;
        private System.Windows.Forms.CheckedListBox selectUserBox;
        private System.Windows.Forms.ColumnHeader partic;
    }
}