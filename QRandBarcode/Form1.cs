using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QRandBarcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the combo box with options
            formatComboBox.Items.Add("QR Code");
            formatComboBox.Items.Add("Barcode");
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formatComboBox.SelectedItem.ToString() == "QR Code")
            {
                // Set visibility of PictureBoxes
                qrCodePictureBox.Visible = true;
                barcodePictureBox.Visible = false;
            }
            else if (formatComboBox.SelectedItem.ToString() == "Barcode")
            {
                // Set visibility of PictureBoxes
                qrCodePictureBox.Visible = false;
                barcodePictureBox.Visible = true;
            }
        }

        private void GenerateBarcodeButton_Click(object sender, EventArgs e)
        {
            if (formatComboBox.SelectedItem.ToString() == "QR Code")
            {
                GenerateQRCode(qrCodePictureBox);
            }
            else if (formatComboBox.SelectedItem.ToString() == "Barcode")
            {
                GenerateBarcode(barcodePictureBox);
            }
        }

        private void GenerateQRCode(PictureBox pictureBox)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE; // Use QR_CODE for QR codes

            string oilName = OilNameTextBox.Text;
            string vehicleName = VehicleNameTextBox.Text;

            string formattedInfo = GetFormattedInformation(oilName, vehicleName);

            // Format the information for QR code content
            string qrCodeContent = $"Oilname:     {oilName}\nVechiclename: {vehicleName}";

            Bitmap qrCodeBitmap = barcodeWriter.Write(qrCodeContent);
            pictureBox.Image = qrCodeBitmap;

            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                int infoX = 10;
                int infoY = qrCodeBitmap.Height + 10; // Adjust for spacing

                string oilText = $"Oilname: {oilName}";
                string vehicleText = $"Vechiclename: {vehicleName}";

                g.DrawString(oilText, new Font("Arial", 10), Brushes.Black, new PointF(infoX, infoY));
                g.DrawString(vehicleText, new Font("Arial", 10), Brushes.Black, new PointF(infoX, infoY + 20)); // Adjust Y coordinate for spacing
            }

            pictureBox.Refresh();
        }

        private void GenerateBarcode(PictureBox pictureBox)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128; // Use CODE_128 for barcodes


            barcodeWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = 50, // Set the desired width in pixels
                Height = 90  // Set the desired DPI value
            };

            string oilName = OilNameTextBox.Text;
            string vehicleName = VehicleNameTextBox.Text;

            string formattedInfo = GetFormattedInformation(oilName, vehicleName);


            // Format the information for barcode content
            string barcodeContent = $"Oilname: {oilName}\nVechiclename: {vehicleName}";

            Bitmap barcodeBitmap = barcodeWriter.Write(barcodeContent);
            pictureBox.Image = barcodeBitmap;

            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                int infoX = 10;
                int infoY = barcodeBitmap.Height + 10; // Adjust for spacing

                string oilText = $"Oilname: {oilName}";
                string vehicleText = $"Vechiclename: {vehicleName}";

                g.DrawString(oilText, new Font("Arial", 10), Brushes.Black, new PointF(infoX, infoY));
                g.DrawString(vehicleText, new Font("Arial", 10), Brushes.Black, new PointF(infoX, infoY + 20)); // Adjust Y coordinate for spacing
            }

            pictureBox.Refresh();
        }

        private string GetFormattedInformation(string oilName, string vehicleName)
        {
            string formattedInfo = $"OilName: {oilName}\nVechicalName: {vehicleName}";
            return formattedInfo;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (formatComboBox.SelectedItem.ToString() == "QR Code")
            {
                PrintGeneratedInfo(qrCodePictureBox);
            }
            else if (formatComboBox.SelectedItem.ToString() == "Barcode")
            {
                PrintGeneratedInfo(barcodePictureBox);
            }
        }

        private void PrintGeneratedInfo(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    // Print the image
                    ev.Graphics.DrawImage(pictureBox.Image, new Point(50, 100));

                    // Get the oil and vehicle names
                    string oilName = OilNameTextBox.Text;
                    string vehicleName = VehicleNameTextBox.Text;

                    // Get the formatted information
                    string formattedInfo = GetFormattedInformation(oilName, vehicleName);

                    // Print the formatted information below the image
                    ev.Graphics.DrawString(formattedInfo, new Font("Arial", 10), Brushes.Black, new Point(50, 100 + pictureBox.Image.Height + 10));
                };

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
