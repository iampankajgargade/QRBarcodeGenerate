namespace QRandBarcode
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
            this.label3 = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.barcodePictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.qrCodePictureBox = new System.Windows.Forms.PictureBox();
            this.GenerateBarcodeButton = new System.Windows.Forms.Button();
            this.VehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.OilNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Type";
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(171, 123);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(183, 21);
            this.formatComboBox.TabIndex = 18;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.barcodePictureBox.Location = new System.Drawing.Point(215, 206);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(139, 75);
            this.barcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barcodePictureBox.TabIndex = 17;
            this.barcodePictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vechicle Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Oil Name";
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Transparent;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintButton.Location = new System.Drawing.Point(288, 154);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(70, 30);
            this.PrintButton.TabIndex = 14;
            this.PrintButton.Text = "Print ";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // qrCodePictureBox
            // 
            this.qrCodePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.qrCodePictureBox.Location = new System.Drawing.Point(46, 206);
            this.qrCodePictureBox.Name = "qrCodePictureBox";
            this.qrCodePictureBox.Size = new System.Drawing.Size(88, 75);
            this.qrCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrCodePictureBox.TabIndex = 13;
            this.qrCodePictureBox.TabStop = false;
            // 
            // GenerateBarcodeButton
            // 
            this.GenerateBarcodeButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateBarcodeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBarcodeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateBarcodeButton.Location = new System.Drawing.Point(171, 154);
            this.GenerateBarcodeButton.Name = "GenerateBarcodeButton";
            this.GenerateBarcodeButton.Size = new System.Drawing.Size(70, 30);
            this.GenerateBarcodeButton.TabIndex = 12;
            this.GenerateBarcodeButton.Text = "Generate Barcode";
            this.GenerateBarcodeButton.UseVisualStyleBackColor = false;
            this.GenerateBarcodeButton.Click += new System.EventHandler(this.GenerateBarcodeButton_Click);
            // 
            // VehicleNameTextBox
            // 
            this.VehicleNameTextBox.Location = new System.Drawing.Point(171, 86);
            this.VehicleNameTextBox.Name = "VehicleNameTextBox";
            this.VehicleNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.VehicleNameTextBox.TabIndex = 11;
            // 
            // OilNameTextBox
            // 
            this.OilNameTextBox.Location = new System.Drawing.Point(171, 40);
            this.OilNameTextBox.Name = "OilNameTextBox";
            this.OilNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.OilNameTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.barcodePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.qrCodePictureBox);
            this.Controls.Add(this.GenerateBarcodeButton);
            this.Controls.Add(this.VehicleNameTextBox);
            this.Controls.Add(this.OilNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.PictureBox barcodePictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PictureBox qrCodePictureBox;
        private System.Windows.Forms.Button GenerateBarcodeButton;
        private System.Windows.Forms.TextBox VehicleNameTextBox;
        private System.Windows.Forms.TextBox OilNameTextBox;
    }
}

