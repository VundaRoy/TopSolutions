using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Security.Certificate
{
    public class CertificateExtraction
    {
        static void Main()
        {
            string pfxFilePath = "path/to/your/certificate.pfx";
            string pfxPassword = "yourPfxPassword";

            // Load the PFX file
            X509Certificate2 certificate = new X509Certificate2(pfxFilePath, pfxPassword);

            // Get the serial number
            string serialNumber = certificate.SerialNumber;

            Console.WriteLine($"Serial Number: {serialNumber}");
        }
    }
}
