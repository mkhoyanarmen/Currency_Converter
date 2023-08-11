namespace Currency_Converter
{
    partial class frmConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConverter));
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFromCurrency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbToCurrency = new System.Windows.Forms.ComboBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFromCurrency.Location = new System.Drawing.Point(92, 41);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFromCurrency.Size = new System.Drawing.Size(124, 34);
            this.txtFromCurrency.TabIndex = 0;
            this.txtFromCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromCurrency_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // cbFromCurrency
            // 
            this.cbFromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFromCurrency.Location = new System.Drawing.Point(240, 40);
            this.cbFromCurrency.Name = "cbFromCurrency";
            this.cbFromCurrency.Size = new System.Drawing.Size(81, 36);
            this.cbFromCurrency.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // cbToCurrency
            // 
            this.cbToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbToCurrency.FormattingEnabled = true;
            this.cbToCurrency.Location = new System.Drawing.Point(240, 111);
            this.cbToCurrency.Name = "cbToCurrency";
            this.cbToCurrency.Size = new System.Drawing.Size(81, 36);
            this.cbToCurrency.TabIndex = 4;
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Enabled = false;
            this.txtToCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToCurrency.Location = new System.Drawing.Point(92, 112);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToCurrency.Size = new System.Drawing.Size(124, 34);
            this.txtToCurrency.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(54, 192);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(267, 65);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmConverter
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 293);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbToCurrency);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFromCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Time Currency Converter";
            this.Load += new System.EventHandler(this.frmConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFromCurrency;
        private Label label1;
        private ComboBox cbFromCurrency;
        private Label label2;
        private ComboBox cbToCurrency;
        private TextBox txtToCurrency;
        private Button btnConvert;
    }
}