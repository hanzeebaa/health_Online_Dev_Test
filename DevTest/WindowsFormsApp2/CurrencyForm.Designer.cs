namespace WindowsFormsApp2
{
    partial class CurrencyForm
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
            System.Windows.Forms.RadioButton radioButtonProvider1;
            this.listView1 = new System.Windows.Forms.ListView();
            this.currencyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.provider1Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.provider2Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.currencyFrom = new System.Windows.Forms.ComboBox();
            this.currencyTo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.conversionValue = new System.Windows.Forms.TextBox();
            this.radioButtonProvider2 = new System.Windows.Forms.RadioButton();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelCurrencyFrom = new System.Windows.Forms.Label();
            this.labelCurrencyTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            radioButtonProvider1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonProvider1
            // 
            radioButtonProvider1.AutoSize = true;
            radioButtonProvider1.Checked = true;
            radioButtonProvider1.Location = new System.Drawing.Point(113, 224);
            radioButtonProvider1.Name = "radioButtonProvider1";
            radioButtonProvider1.Size = new System.Drawing.Size(73, 17);
            radioButtonProvider1.TabIndex = 6;
            radioButtonProvider1.TabStop = true;
            radioButtonProvider1.Text = "Provider 1";
            radioButtonProvider1.UseVisualStyleBackColor = true;
            radioButtonProvider1.CheckedChanged += new System.EventHandler(this.radioButtonProvider1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.currencyHeader,
            this.provider1Header,
            this.provider2Header});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(113, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 151);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // currencyHeader
            // 
            this.currencyHeader.Text = "Currency";
            this.currencyHeader.Width = 248;
            // 
            // provider1Header
            // 
            this.provider1Header.Text = "Provider 1";
            this.provider1Header.Width = 135;
            // 
            // provider2Header
            // 
            this.provider2Header.Text = "Provider 2";
            this.provider2Header.Width = 171;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency Converter";
            // 
            // currencyFrom
            // 
            this.currencyFrom.AllowDrop = true;
            this.currencyFrom.FormattingEnabled = true;
            this.currencyFrom.Location = new System.Drawing.Point(273, 286);
            this.currencyFrom.Name = "currencyFrom";
            this.currencyFrom.Size = new System.Drawing.Size(151, 21);
            this.currencyFrom.TabIndex = 2;
            this.currencyFrom.SelectedIndexChanged += new System.EventHandler(this.currencyFrom_SelectedIndexChanged);
            // 
            // currencyTo
            // 
            this.currencyTo.FormattingEnabled = true;
            this.currencyTo.Location = new System.Drawing.Point(273, 330);
            this.currencyTo.Name = "currencyTo";
            this.currencyTo.Size = new System.Drawing.Size(151, 21);
            this.currencyTo.TabIndex = 3;
            this.currencyTo.SelectedIndexChanged += new System.EventHandler(this.currencyTo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // conversionValue
            // 
            this.conversionValue.Location = new System.Drawing.Point(641, 286);
            this.conversionValue.Name = "conversionValue";
            this.conversionValue.Size = new System.Drawing.Size(125, 20);
            this.conversionValue.TabIndex = 5;
            // 
            // radioButtonProvider2
            // 
            this.radioButtonProvider2.AutoSize = true;
            this.radioButtonProvider2.Location = new System.Drawing.Point(249, 224);
            this.radioButtonProvider2.Name = "radioButtonProvider2";
            this.radioButtonProvider2.Size = new System.Drawing.Size(73, 17);
            this.radioButtonProvider2.TabIndex = 7;
            this.radioButtonProvider2.TabStop = true;
            this.radioButtonProvider2.Text = "Provider 2";
            this.radioButtonProvider2.UseVisualStyleBackColor = true;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvider.Location = new System.Drawing.Point(113, 200);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(176, 20);
            this.labelProvider.TabIndex = 8;
            this.labelProvider.Text = "Select required provider";
            // 
            // labelCurrencyFrom
            // 
            this.labelCurrencyFrom.AutoSize = true;
            this.labelCurrencyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrencyFrom.Location = new System.Drawing.Point(270, 265);
            this.labelCurrencyFrom.Name = "labelCurrencyFrom";
            this.labelCurrencyFrom.Size = new System.Drawing.Size(40, 17);
            this.labelCurrencyFrom.TabIndex = 9;
            this.labelCurrencyFrom.Text = "From";
            // 
            // labelCurrencyTo
            // 
            this.labelCurrencyTo.AutoSize = true;
            this.labelCurrencyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrencyTo.Location = new System.Drawing.Point(270, 310);
            this.labelCurrencyTo.Name = "labelCurrencyTo";
            this.labelCurrencyTo.Size = new System.Drawing.Size(25, 17);
            this.labelCurrencyTo.TabIndex = 10;
            this.labelCurrencyTo.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(466, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrencyTo);
            this.Controls.Add(this.labelCurrencyFrom);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.radioButtonProvider2);
            this.Controls.Add(radioButtonProvider1);
            this.Controls.Add(this.conversionValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currencyTo);
            this.Controls.Add(this.currencyFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "CurrencyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader currencyHeader;
        private System.Windows.Forms.ColumnHeader provider1Header;
        private System.Windows.Forms.ColumnHeader provider2Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currencyFrom;
        private System.Windows.Forms.ComboBox currencyTo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox conversionValue;
        private System.Windows.Forms.RadioButton radioButtonProvider2;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelCurrencyFrom;
        private System.Windows.Forms.Label labelCurrencyTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

