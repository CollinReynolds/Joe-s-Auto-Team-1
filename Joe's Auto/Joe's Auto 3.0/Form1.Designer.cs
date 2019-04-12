namespace Joe_s_Auto
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
            this.customBtn = new System.Windows.Forms.Button();
            this.partBtn = new System.Windows.Forms.Button();
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customBtn
            // 
            this.customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn.Location = new System.Drawing.Point(147, 124);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(115, 34);
            this.customBtn.TabIndex = 1;
            this.customBtn.Text = "customer";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // partBtn
            // 
            this.partBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partBtn.Location = new System.Drawing.Point(147, 240);
            this.partBtn.Name = "partBtn";
            this.partBtn.Size = new System.Drawing.Size(115, 34);
            this.partBtn.TabIndex = 2;
            this.partBtn.Text = "Parts";
            this.partBtn.UseVisualStyleBackColor = true;
            this.partBtn.Click += new System.EventHandler(this.partBtn_Click);
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleBtn.Location = new System.Drawing.Point(427, 124);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(115, 34);
            this.vehicleBtn.TabIndex = 3;
            this.vehicleBtn.Text = "Vehicle";
            this.vehicleBtn.UseVisualStyleBackColor = true;
            this.vehicleBtn.Click += new System.EventHandler(this.vehicleBtn_Click);
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceBtn.Location = new System.Drawing.Point(427, 240);
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(115, 34);
            this.invoiceBtn.TabIndex = 4;
            this.invoiceBtn.Text = "Invoices";
            this.invoiceBtn.UseVisualStyleBackColor = true;
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 442);
            this.Controls.Add(this.invoiceBtn);
            this.Controls.Add(this.vehicleBtn);
            this.Controls.Add(this.partBtn);
            this.Controls.Add(this.customBtn);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button partBtn;
        private System.Windows.Forms.Button vehicleBtn;
        private System.Windows.Forms.Button invoiceBtn;
    }
}

