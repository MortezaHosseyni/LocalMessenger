namespace LocalMessenger
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lsb_NetworkComputers = new System.Windows.Forms.ListBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lsb_MessageBox = new System.Windows.Forms.ListBox();
            this.btn_RefreshNetwork = new System.Windows.Forms.Button();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.txt_MessageBox = new System.Windows.Forms.TextBox();
            this.sss_StatusBox = new System.Windows.Forms.StatusStrip();
            this.ctx_StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sss_StatusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_NetworkComputers
            // 
            this.lsb_NetworkComputers.Enabled = false;
            this.lsb_NetworkComputers.FormattingEnabled = true;
            this.lsb_NetworkComputers.HorizontalScrollbar = true;
            this.lsb_NetworkComputers.ItemHeight = 16;
            this.lsb_NetworkComputers.Location = new System.Drawing.Point(588, 79);
            this.lsb_NetworkComputers.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_NetworkComputers.Name = "lsb_NetworkComputers";
            this.lsb_NetworkComputers.Size = new System.Drawing.Size(250, 308);
            this.lsb_NetworkComputers.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl_Title.Location = new System.Drawing.Point(294, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(242, 36);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Local Messenger";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Author.Location = new System.Drawing.Point(434, 45);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(102, 13);
            this.lbl_Author.TabIndex = 2;
            this.lbl_Author.Text = "by Morteza Hosseini";
            // 
            // lsb_MessageBox
            // 
            this.lsb_MessageBox.FormattingEnabled = true;
            this.lsb_MessageBox.HorizontalScrollbar = true;
            this.lsb_MessageBox.ItemHeight = 16;
            this.lsb_MessageBox.Location = new System.Drawing.Point(13, 79);
            this.lsb_MessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_MessageBox.Name = "lsb_MessageBox";
            this.lsb_MessageBox.Size = new System.Drawing.Size(567, 308);
            this.lsb_MessageBox.TabIndex = 3;
            // 
            // btn_RefreshNetwork
            // 
            this.btn_RefreshNetwork.Enabled = false;
            this.btn_RefreshNetwork.Location = new System.Drawing.Point(588, 394);
            this.btn_RefreshNetwork.Name = "btn_RefreshNetwork";
            this.btn_RefreshNetwork.Size = new System.Drawing.Size(250, 24);
            this.btn_RefreshNetwork.TabIndex = 4;
            this.btn_RefreshNetwork.Text = "Refresh Network";
            this.btn_RefreshNetwork.UseVisualStyleBackColor = true;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(538, 394);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(42, 23);
            this.btn_SendMessage.TabIndex = 5;
            this.btn_SendMessage.Text = "✉️";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // txt_MessageBox
            // 
            this.txt_MessageBox.Location = new System.Drawing.Point(13, 394);
            this.txt_MessageBox.Name = "txt_MessageBox";
            this.txt_MessageBox.Size = new System.Drawing.Size(519, 23);
            this.txt_MessageBox.TabIndex = 6;
            this.txt_MessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MessageBox_KeyDown);
            // 
            // sss_StatusBox
            // 
            this.sss_StatusBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_StatusText});
            this.sss_StatusBox.Location = new System.Drawing.Point(0, 437);
            this.sss_StatusBox.Name = "sss_StatusBox";
            this.sss_StatusBox.Size = new System.Drawing.Size(851, 22);
            this.sss_StatusBox.TabIndex = 7;
            // 
            // ctx_StatusText
            // 
            this.ctx_StatusText.Name = "ctx_StatusText";
            this.ctx_StatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(649, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contacts List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(666, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Coming Soon";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(851, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sss_StatusBox);
            this.Controls.Add(this.txt_MessageBox);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.btn_RefreshNetwork);
            this.Controls.Add(this.lsb_MessageBox);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lsb_NetworkComputers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(867, 498);
            this.MinimumSize = new System.Drawing.Size(867, 498);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sss_StatusBox.ResumeLayout(false);
            this.sss_StatusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_NetworkComputers;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.ListBox lsb_MessageBox;
        private System.Windows.Forms.Button btn_RefreshNetwork;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.TextBox txt_MessageBox;
        private System.Windows.Forms.StatusStrip sss_StatusBox;
        private System.Windows.Forms.ToolStripStatusLabel ctx_StatusText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

