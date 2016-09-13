using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Core.Entidades.Billing.Payments;
using Core.Entities.Billing;
using Core.Entities.Company;

namespace Core.Entities
{
    public class Prints
    {
        //Properties
        private static Bill _Bill { get; set; }
        private static Payments Payment { get; set; }
        

        //Private methods
        private static void SetPayment(PrintPageEventArgs e)
        {
            var graphic = e.Graphics;

            var font = new Font("Courier new", 12);

            var fontHeight = font.GetHeight();

            var startX = 10;
            var startY = 10;
            var offset = 40;

            var Info = CompanyInfo.GetInfo();

            graphic.DrawString("           " + Info.CommercialName, new Font("Courier new", 18, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);

            offset += 40;

            graphic.DrawString("Num. Pago: " + Payment.Number, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Fecha: " + Payment.Date, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 30);
            graphic.DrawString("Cliente: " + Payment.Customer, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 50);
            graphic.DrawString("Pago: " + Payment.PayMethod, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 70);
            graphic.DrawString("Cajero(a): " + Payment.Cashier, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 90);
            graphic.DrawString("****************************************", new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 120);

            offset = 240;

            var Description = "Descripcion".PadRight(15);
            var Quantity = "Cantidad".PadRight(8);
            var Total = "Total";
            var Line = Description + Quantity + Total;

            graphic.DrawString(Line, new Font("Courier new", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset += 50;

            var proDescription = "Abono a cuenta".PadRight(20);
            var proQuantity = "1".PadRight(5);
            var proTotal = String.Format("{0:c}", Payment.Amount);
            var proLine = proDescription + proQuantity + proTotal;

            graphic.DrawString(proLine, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + 5;

            graphic.DrawString("****************************************", new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 20);

            offset += 70;

            graphic.DrawString("Total Importe: " + String.Format("{0:c}", Payment.Amount), new Font("Courier new", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
        }

        private static void SetBill(PrintPageEventArgs e)
        {
            var graphic = e.Graphics;

            var font = new Font("Courier new", 12);

            var fontHeight = font.GetHeight();

            var startX = 10;
            var startY = 10;
            var offset = 40;

            var Info = CompanyInfo.GetInfo();

            graphic.DrawString("           " + Info.CommercialName, new Font("Courier new", 18, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);

            offset += 40;

            graphic.DrawString("Num. Factura: " + _Bill.Number, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Fecha: " + _Bill.BillDate, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 30);
            graphic.DrawString("Cliente: " + _Bill.Customer, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 50);
            graphic.DrawString("Condicion: " + _Bill.Condition, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 70);
            graphic.DrawString("Pago: " + _Bill.PaymentMethod, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 90);
            graphic.DrawString("Cajero(a): " + _Bill.Employee, new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 120);
            graphic.DrawString("****************************************", new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 140);

            offset = 240;

            var Description = "Descripcion".PadRight(15);
            var Quantity = "Cantidad".PadRight(8);
            var Total = "Total";
            var Line = Description + Quantity + Total;

            graphic.DrawString(Line, new Font("Courier new", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset += 50;

            foreach (var product in _Bill.Details)
            {
                var length = product.Name.Length;

                var proDescription = product.Name.Substring(0, length > 10 ? 9 : length).PadRight(20);
                var proQuantity = product.Quantity.ToString().PadRight(5);
                var proTotal = String.Format("{0:c}", product.Total);
                var proLine = proDescription + proQuantity + proTotal;

                graphic.DrawString(proLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            graphic.DrawString("****************************************", new Font("Courier new", 12), new SolidBrush(Color.Black), startX, startY + offset + 20);

            offset += 70;

            graphic.DrawString("Total: " + String.Format("{0:c}", _Bill.Total), new Font("Courier new", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
        }

        //Static methods
        public static void PrintBill(Bill bill)
        {
            _Bill = bill;
            
            var printDialog = new PrintDialog();
            var printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            var result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public static void PrintPayment(Payments payment)
        {
            Payment = payment;

            var printDialog = new PrintDialog();
            var printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printPayment_Printpage);

            var result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }


        //Print Bill
        private static void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            SetBill(e);
        }

        //Print Payment
        public static void printPayment_Printpage(object sender, PrintPageEventArgs e)
        {
            SetPayment(e);
        }
    }
}
