namespace Bakery_Shop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ITEM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.proceed = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Green;
            this.radioButton1.Location = new System.Drawing.Point(205, 158);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VEG";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Location = new System.Drawing.Point(351, 158);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NON VEG";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmb_items
            // 
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(171, 208);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(516, 24);
            this.cmb_items.TabIndex = 3;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECT ITEM";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(35, 290);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(112, 22);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "QTY";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(375, 289);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(112, 22);
            this.txt_total.TabIndex = 5;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_total.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD ITEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ITEM,
            this.QTY,
            this.RATE,
            this.TOTAL});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 340);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 253);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ITEM
            // 
            this.ITEM.Text = "ITEM NAME";
            this.ITEM.Width = 250;
            // 
            // QTY
            // 
            this.QTY.Text = "QTY";
            this.QTY.Width = 70;
            // 
            // RATE
            // 
            this.RATE.Text = "PRICE";
            this.RATE.Width = 70;
            // 
            // TOTAL
            // 
            this.TOTAL.Text = "TOTAL";
            this.TOTAL.Width = 70;
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(129, 615);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(112, 22);
            this.txt_sub.TabIndex = 9;
            this.txt_sub.Text = "0";
            this.txt_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 618);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "SUB TOTAL";
            // 
            // txt_dis
            // 
            this.txt_dis.Location = new System.Drawing.Point(375, 615);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(112, 22);
            this.txt_dis.TabIndex = 9;
            this.txt_dis.Text = "0";
            this.txt_dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dis.TextChanged += new System.EventHandler(this.txt_dis_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "DISCOUNT %";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(564, 615);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(112, 22);
            this.txt_net.TabIndex = 9;
            this.txt_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_net.TextChanged += new System.EventHandler(this.txt_net_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "NET";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 94);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "REMOVE ITEM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // proceed
            // 
            this.proceed.Location = new System.Drawing.Point(529, 671);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(147, 23);
            this.proceed.TabIndex = 13;
            this.proceed.Text = "PROCEED";
            this.proceed.UseVisualStyleBackColor = true;
            this.proceed.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(529, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 20);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "COKE";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(529, 725);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(147, 23);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(205, 289);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(120, 22);
            this.txt_qty.TabIndex = 16;
            this.txt_qty.ValueChanged += new System.EventHandler(this.txt_qty_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 760);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_dis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Pizza Ordering System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cmb_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader ITEM;
        private System.Windows.Forms.ColumnHeader QTY;
        private System.Windows.Forms.ColumnHeader RATE;
        private System.Windows.Forms.ColumnHeader TOTAL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown txt_qty;
    }
}

