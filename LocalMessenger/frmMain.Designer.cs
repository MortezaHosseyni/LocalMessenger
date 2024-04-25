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
            this.lsb_NetworkComputers = new System.Windows.Forms.ListBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lsb_MessageBox = new System.Windows.Forms.ListBox();
            this.btn_RefreshNetwork = new System.Windows.Forms.Button();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.txt_MessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsb_NetworkComputers
            // 
            this.lsb_NetworkComputers.FormattingEnabled = true;
            this.lsb_NetworkComputers.ItemHeight = 16;
            this.lsb_NetworkComputers.Location = new System.Drawing.Point(588, 79);
            this.lsb_NetworkComputers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lsb_MessageBox.ItemHeight = 16;
            this.lsb_MessageBox.Location = new System.Drawing.Point(13, 79);
            this.lsb_MessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_MessageBox.Name = "lsb_MessageBox";
            this.lsb_MessageBox.Size = new System.Drawing.Size(567, 308);
            this.lsb_MessageBox.TabIndex = 3;
            // 
            // btn_RefreshNetwork
            // 
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
            // 
            // txt_MessageBox
            // 
            this.txt_MessageBox.Location = new System.Drawing.Point(13, 394);
            this.txt_MessageBox.Name = "txt_MessageBox";
            this.txt_MessageBox.Size = new System.Drawing.Size(519, 23);
            this.txt_MessageBox.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(851, 444);
            this.Controls.Add(this.txt_MessageBox);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.btn_RefreshNetwork);
            this.Controls.Add(this.lsb_MessageBox);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lsb_NetworkComputers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Local Messenger";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
    }
}

