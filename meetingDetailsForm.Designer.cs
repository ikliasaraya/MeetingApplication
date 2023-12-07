namespace MeetingApplication
{
    partial class meetingDetailsForm
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
            this.meetingInfo = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meetingInfo
            // 
            this.meetingInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.meetingInfo.Location = new System.Drawing.Point(12, 9);
            this.meetingInfo.Name = "meetingInfo";
            this.meetingInfo.Size = new System.Drawing.Size(286, 228);
            this.meetingInfo.TabIndex = 1;
            this.meetingInfo.Text = "label2";
            this.meetingInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 281);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(286, 35);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Toplantıyı Bitir";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // leaveBtn
            // 
            this.leaveBtn.Location = new System.Drawing.Point(12, 240);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(286, 35);
            this.leaveBtn.TabIndex = 3;
            this.leaveBtn.Text = "Toplantıdan Ayrıl";
            this.leaveBtn.UseVisualStyleBackColor = true;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // meetingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(310, 328);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.meetingInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "meetingDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toplantı Detayları";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label meetingInfo;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button leaveBtn;
    }
}