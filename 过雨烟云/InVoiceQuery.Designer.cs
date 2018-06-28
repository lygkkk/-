using System;
using System.Windows.Forms;

namespace 过雨烟云
{
    partial class InVoiceQuery
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_startTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_endTime = new System.Windows.Forms.DateTimePicker();
            this.tb_invoiceCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_invoiceNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_buyersCommpany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sellersCommpany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_taxRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_payee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_check = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_drawer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_returnMoney = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_query = new System.Windows.Forms.Label();
            this.cbb_invoiceState = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_taxAmount = new System.Windows.Forms.Button();
            this.btn_taxRate = new System.Windows.Forms.Button();
            this.btn_money = new System.Windows.Forms.Button();
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_returnMoney = new System.Windows.Forms.Button();
            this.btn_invoiceState = new System.Windows.Forms.Button();
            this.btn_number = new System.Windows.Forms.Button();
            this.btn_productName = new System.Windows.Forms.Button();
            this.btn_sellersCommpany = new System.Windows.Forms.Button();
            this.btn_buyersCommpany = new System.Windows.Forms.Button();
            this.btn_invoiceNumber = new System.Windows.Forms.Button();
            this.btn_invoiceCode = new System.Windows.Forms.Button();
            this.btn_date = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 262);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtp_startTime
            // 
            this.dtp_startTime.Location = new System.Drawing.Point(256, 22);
            this.dtp_startTime.Name = "dtp_startTime";
            this.dtp_startTime.Size = new System.Drawing.Size(156, 25);
            this.dtp_startTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "结束日期";
            // 
            // dtp_endTime
            // 
            this.dtp_endTime.Location = new System.Drawing.Point(497, 22);
            this.dtp_endTime.Name = "dtp_endTime";
            this.dtp_endTime.Size = new System.Drawing.Size(156, 25);
            this.dtp_endTime.TabIndex = 4;
            // 
            // tb_invoiceCode
            // 
            this.tb_invoiceCode.Location = new System.Drawing.Point(78, 52);
            this.tb_invoiceCode.Name = "tb_invoiceCode";
            this.tb_invoiceCode.Size = new System.Drawing.Size(129, 25);
            this.tb_invoiceCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "发票编码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "发票号码";
            // 
            // tb_invoiceNumber
            // 
            this.tb_invoiceNumber.Location = new System.Drawing.Point(298, 52);
            this.tb_invoiceNumber.Name = "tb_invoiceNumber";
            this.tb_invoiceNumber.Size = new System.Drawing.Size(131, 25);
            this.tb_invoiceNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "购方单位";
            // 
            // tb_buyersCommpany
            // 
            this.tb_buyersCommpany.Location = new System.Drawing.Point(516, 52);
            this.tb_buyersCommpany.Name = "tb_buyersCommpany";
            this.tb_buyersCommpany.Size = new System.Drawing.Size(129, 25);
            this.tb_buyersCommpany.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "销售单位";
            // 
            // tb_sellersCommpany
            // 
            this.tb_sellersCommpany.Location = new System.Drawing.Point(732, 51);
            this.tb_sellersCommpany.Name = "tb_sellersCommpany";
            this.tb_sellersCommpany.Size = new System.Drawing.Size(129, 25);
            this.tb_sellersCommpany.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "产品名称";
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(944, 51);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(129, 25);
            this.tb_productName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "数　　量";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(77, 84);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(129, 25);
            this.tb_number.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(658, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "税　　率";
            // 
            // tb_taxRate
            // 
            this.tb_taxRate.Location = new System.Drawing.Point(731, 83);
            this.tb_taxRate.Name = "tb_taxRate";
            this.tb_taxRate.Size = new System.Drawing.Size(129, 25);
            this.tb_taxRate.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(871, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "备    注";
            // 
            // tb_comment
            // 
            this.tb_comment.Location = new System.Drawing.Point(944, 83);
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(129, 25);
            this.tb_comment.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "收 款 人";
            // 
            // tb_payee
            // 
            this.tb_payee.Location = new System.Drawing.Point(77, 116);
            this.tb_payee.Name = "tb_payee";
            this.tb_payee.Size = new System.Drawing.Size(129, 25);
            this.tb_payee.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "复    核";
            // 
            // tb_check
            // 
            this.tb_check.Location = new System.Drawing.Point(298, 116);
            this.tb_check.Name = "tb_check";
            this.tb_check.Size = new System.Drawing.Size(131, 25);
            this.tb_check.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "开 票 人";
            // 
            // tb_drawer
            // 
            this.tb_drawer.Location = new System.Drawing.Point(516, 116);
            this.tb_drawer.Name = "tb_drawer";
            this.tb_drawer.Size = new System.Drawing.Size(129, 25);
            this.tb_drawer.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "回　　款";
            // 
            // tb_returnMoney
            // 
            this.tb_returnMoney.Location = new System.Drawing.Point(516, 84);
            this.tb_returnMoney.Name = "tb_returnMoney";
            this.tb_returnMoney.Size = new System.Drawing.Size(129, 25);
            this.tb_returnMoney.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "发票状态";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lb_query);
            this.groupBox1.Controls.Add(this.cbb_invoiceState);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_returnMoney);
            this.groupBox1.Controls.Add(this.dtp_startTime);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dtp_endTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_drawer);
            this.groupBox1.Controls.Add(this.tb_invoiceCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_check);
            this.groupBox1.Controls.Add(this.tb_invoiceNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_payee);
            this.groupBox1.Controls.Add(this.tb_buyersCommpany);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_comment);
            this.groupBox1.Controls.Add(this.tb_sellersCommpany);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_taxRate);
            this.groupBox1.Controls.Add(this.tb_productName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_number);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lb_query
            // 
            this.lb_query.BackColor = System.Drawing.Color.Gold;
            this.lb_query.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_query.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_query.Location = new System.Drawing.Point(795, 21);
            this.lb_query.Name = "lb_query";
            this.lb_query.Size = new System.Drawing.Size(100, 23);
            this.lb_query.TabIndex = 32;
            this.lb_query.Text = "查　找";
            this.lb_query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_invoiceState
            // 
            this.cbb_invoiceState.FormattingEnabled = true;
            this.cbb_invoiceState.Location = new System.Drawing.Point(298, 85);
            this.cbb_invoiceState.Name = "cbb_invoiceState";
            this.cbb_invoiceState.Size = new System.Drawing.Size(131, 23);
            this.cbb_invoiceState.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.btn_taxAmount);
            this.groupBox2.Controls.Add(this.btn_taxRate);
            this.groupBox2.Controls.Add(this.btn_money);
            this.groupBox2.Controls.Add(this.btn_comment);
            this.groupBox2.Controls.Add(this.btn_returnMoney);
            this.groupBox2.Controls.Add(this.btn_invoiceState);
            this.groupBox2.Controls.Add(this.btn_number);
            this.groupBox2.Controls.Add(this.btn_productName);
            this.groupBox2.Controls.Add(this.btn_sellersCommpany);
            this.groupBox2.Controls.Add(this.btn_buyersCommpany);
            this.groupBox2.Controls.Add(this.btn_invoiceNumber);
            this.groupBox2.Controls.Add(this.btn_invoiceCode);
            this.groupBox2.Controls.Add(this.btn_date);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1320, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请拖动按钮到下面";
            // 
            // btn_taxAmount
            // 
            this.btn_taxAmount.Location = new System.Drawing.Point(980, 24);
            this.btn_taxAmount.Name = "btn_taxAmount";
            this.btn_taxAmount.Size = new System.Drawing.Size(75, 23);
            this.btn_taxAmount.TabIndex = 12;
            this.btn_taxAmount.Text = "税额";
            this.btn_taxAmount.UseVisualStyleBackColor = true;
            // 
            // btn_taxRate
            // 
            this.btn_taxRate.Location = new System.Drawing.Point(899, 24);
            this.btn_taxRate.Name = "btn_taxRate";
            this.btn_taxRate.Size = new System.Drawing.Size(75, 23);
            this.btn_taxRate.TabIndex = 11;
            this.btn_taxRate.Text = "税率";
            this.btn_taxRate.UseVisualStyleBackColor = true;
            // 
            // btn_money
            // 
            this.btn_money.Location = new System.Drawing.Point(818, 24);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(75, 23);
            this.btn_money.TabIndex = 10;
            this.btn_money.Text = "金额";
            this.btn_money.UseVisualStyleBackColor = true;
            // 
            // btn_comment
            // 
            this.btn_comment.Location = new System.Drawing.Point(737, 24);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(75, 23);
            this.btn_comment.TabIndex = 9;
            this.btn_comment.Text = "备注";
            this.btn_comment.UseVisualStyleBackColor = true;
            // 
            // btn_returnMoney
            // 
            this.btn_returnMoney.Location = new System.Drawing.Point(656, 24);
            this.btn_returnMoney.Name = "btn_returnMoney";
            this.btn_returnMoney.Size = new System.Drawing.Size(75, 23);
            this.btn_returnMoney.TabIndex = 8;
            this.btn_returnMoney.Text = "回款";
            this.btn_returnMoney.UseVisualStyleBackColor = true;
            // 
            // btn_invoiceState
            // 
            this.btn_invoiceState.Location = new System.Drawing.Point(575, 24);
            this.btn_invoiceState.Name = "btn_invoiceState";
            this.btn_invoiceState.Size = new System.Drawing.Size(75, 23);
            this.btn_invoiceState.TabIndex = 7;
            this.btn_invoiceState.Text = "发票状态";
            this.btn_invoiceState.UseVisualStyleBackColor = true;
            // 
            // btn_number
            // 
            this.btn_number.Location = new System.Drawing.Point(494, 24);
            this.btn_number.Name = "btn_number";
            this.btn_number.Size = new System.Drawing.Size(75, 23);
            this.btn_number.TabIndex = 6;
            this.btn_number.Text = "数量";
            this.btn_number.UseVisualStyleBackColor = true;
            // 
            // btn_productName
            // 
            this.btn_productName.Location = new System.Drawing.Point(413, 24);
            this.btn_productName.Name = "btn_productName";
            this.btn_productName.Size = new System.Drawing.Size(75, 23);
            this.btn_productName.TabIndex = 5;
            this.btn_productName.Text = "产品名称";
            this.btn_productName.UseVisualStyleBackColor = true;
            // 
            // btn_sellersCommpany
            // 
            this.btn_sellersCommpany.Location = new System.Drawing.Point(332, 24);
            this.btn_sellersCommpany.Name = "btn_sellersCommpany";
            this.btn_sellersCommpany.Size = new System.Drawing.Size(75, 23);
            this.btn_sellersCommpany.TabIndex = 4;
            this.btn_sellersCommpany.Text = "销售单位";
            this.btn_sellersCommpany.UseVisualStyleBackColor = true;
            // 
            // btn_buyersCommpany
            // 
            this.btn_buyersCommpany.Location = new System.Drawing.Point(251, 24);
            this.btn_buyersCommpany.Name = "btn_buyersCommpany";
            this.btn_buyersCommpany.Size = new System.Drawing.Size(75, 23);
            this.btn_buyersCommpany.TabIndex = 3;
            this.btn_buyersCommpany.Text = "购方单位";
            this.btn_buyersCommpany.UseVisualStyleBackColor = true;
            // 
            // btn_invoiceNumber
            // 
            this.btn_invoiceNumber.Location = new System.Drawing.Point(170, 24);
            this.btn_invoiceNumber.Name = "btn_invoiceNumber";
            this.btn_invoiceNumber.Size = new System.Drawing.Size(75, 23);
            this.btn_invoiceNumber.TabIndex = 2;
            this.btn_invoiceNumber.Text = "发票号码";
            this.btn_invoiceNumber.UseVisualStyleBackColor = true;
            // 
            // btn_invoiceCode
            // 
            this.btn_invoiceCode.Location = new System.Drawing.Point(89, 24);
            this.btn_invoiceCode.Name = "btn_invoiceCode";
            this.btn_invoiceCode.Size = new System.Drawing.Size(75, 23);
            this.btn_invoiceCode.TabIndex = 1;
            this.btn_invoiceCode.Text = "发票编码";
            this.btn_invoiceCode.UseVisualStyleBackColor = true;
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(8, 24);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(75, 23);
            this.btn_date.TabIndex = 0;
            this.btn_date.Text = "日期";
            this.btn_date.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 44);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "按钮拖到这里";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(413, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 44);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数量金额拖到这里";
            // 
            // InVoiceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 508);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InVoiceQuery";
            this.Text = "InVoiceQuery";
            this.Load += new System.EventHandler(this.InVoiceQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_returnMoney;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_drawer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_check;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_payee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_taxRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sellersCommpany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_buyersCommpany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_invoiceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_invoiceCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_endTime;
        private System.Windows.Forms.DateTimePicker dtp_startTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_invoiceState;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Button btn_returnMoney;
        private System.Windows.Forms.Button btn_invoiceState;
        private System.Windows.Forms.Button btn_number;
        private System.Windows.Forms.Button btn_productName;
        private System.Windows.Forms.Button btn_sellersCommpany;
        private System.Windows.Forms.Button btn_buyersCommpany;
        private System.Windows.Forms.Button btn_invoiceNumber;
        private System.Windows.Forms.Button btn_invoiceCode;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_taxAmount;
        private System.Windows.Forms.Button btn_taxRate;
        private System.Windows.Forms.Button btn_money;
        private System.Windows.Forms.GroupBox groupBox3;
        private Label lb_query;
        private GroupBox groupBox4;
    }
}