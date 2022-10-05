namespace Bakery_Shop
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_bal = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.RadioButton();
            this.card = new System.Windows.Forms.RadioButton();
            this.upi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(438, 343);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(210, 22);
            this.txt_amount.TabIndex = 2;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // txt_bal
            // 
            this.txt_bal.Location = new System.Drawing.Point(438, 423);
            this.txt_bal.Name = "txt_bal";
            this.txt_bal.Size = new System.Drawing.Size(210, 22);
            this.txt_bal.TabIndex = 3;
            this.txt_bal.TextChanged += new System.EventHandler(this.txt_bal_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(276, 579);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(138, 23);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "BALANCE";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(40, 185);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(69, 20);
            this.cash.TabIndex = 7;
            this.cash.TabStop = true;
            this.cash.Text = "CASH";
            this.cash.UseVisualStyleBackColor = true;
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Location = new System.Drawing.Point(270, 185);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(70, 20);
            this.card.TabIndex = 7;
            this.card.TabStop = true;
            this.card.Text = "CARD";
            this.card.UseVisualStyleBackColor = true;
            this.card.CheckedChanged += new System.EventHandler(this.card_CheckedChanged);
            // 
            // upi
            // 
            this.upi.AutoSize = true;
            this.upi.Location = new System.Drawing.Point(511, 185);
            this.upi.Name = "upi";
            this.upi.Size = new System.Drawing.Size(53, 20);
            this.upi.TabIndex = 7;
            this.upi.TabStop = true;
            this.upi.Text = "UPI";
            this.upi.UseVisualStyleBackColor = true;
            this.upi.CheckedChanged += new System.EventHandler(this.upi_CheckedChanged);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 614);
            this.Controls.Add(this.upi);
            this.Controls.Add(this.card);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.txt_bal);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_bal;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.RadioButton card;
        private System.Windows.Forms.RadioButton upi;
    }
}