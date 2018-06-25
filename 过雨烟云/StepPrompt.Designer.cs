namespace 过雨烟云
{
    partial class StepPrompt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commpanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.commpanyName,
            this.taxNumber,
            this.address,
            this.bank});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 38);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 362);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // id
            // 
            this.id.DisplayIndex = 4;
            // 
            // commpanyName
            // 
            this.commpanyName.DisplayIndex = 0;
            this.commpanyName.Text = "单位名称";
            this.commpanyName.Width = 150;
            // 
            // taxNumber
            // 
            this.taxNumber.DisplayIndex = 1;
            this.taxNumber.Text = "税号";
            this.taxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taxNumber.Width = 100;
            // 
            // address
            // 
            this.address.DisplayIndex = 2;
            this.address.Text = "地址、电话";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.Width = 100;
            // 
            // bank
            // 
            this.bank.DisplayIndex = 3;
            this.bank.Text = "银行卡号";
            this.bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bank.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "关键字";
            // 
            // StepPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 400);
            this.Name = "StepPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StepPrompt";
            this.Load += new System.EventHandler(this.StepPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader commpanyName;
        private System.Windows.Forms.ColumnHeader taxNumber;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader bank;
        private System.Windows.Forms.Label label1;
    }
}