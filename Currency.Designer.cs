namespace Currency_Conversion
{
   public partial class Currency
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toComboBoX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titlelabel.Location = new System.Drawing.Point(108, 35);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(351, 43);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Currency Conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(223, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESULT";
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(178, 262);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(199, 44);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "CONVERT";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.Location = new System.Drawing.Point(426, 315);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(76, 36);
            this.buttonclose.TabIndex = 3;
            this.buttonclose.Text = "Close";
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(200, 159);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(118, 24);
            this.FromComboBox.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(200, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(200, 112);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(148, 24);
            this.amountTextBox.TabIndex = 11;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.Amountlabel.Location = new System.Drawing.Point(102, 112);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(86, 25);
            this.Amountlabel.TabIndex = 7;
            this.Amountlabel.Text = "Amount:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.fromLabel.Location = new System.Drawing.Point(130, 159);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(53, 20);
            this.fromLabel.TabIndex = 8;
            this.fromLabel.Text = "From:";
            // 
            // toComboBoX
            // 
            this.toComboBoX.AutoSize = true;
            this.toComboBoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toComboBoX.ForeColor = System.Drawing.Color.SteelBlue;
            this.toComboBoX.Location = new System.Drawing.Point(147, 209);
            this.toComboBoX.Name = "toComboBoX";
            this.toComboBoX.Size = new System.Drawing.Size(28, 20);
            this.toComboBoX.TabIndex = 9;
            this.toComboBoX.Text = "to:";
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 353);
            this.Controls.Add(this.toComboBoX);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titlelabel);
            this.Name = "Currency";
            this.Text = "sss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toComboBoX;
    }
}

