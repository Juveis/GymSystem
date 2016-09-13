using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace GYM_System
{
    public class Print
    {
        public static void PrintDoc()
        {
            var printerName = "";
            
            for (var i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                var printer = new PrinterSettings { PrinterName = PrinterSettings.InstalledPrinters[i].ToString() };

                if (printer.IsDefaultPrinter)
                {
                    printerName = PrinterSettings.InstalledPrinters[i].ToString();
                }
            }
        }
    }
}
