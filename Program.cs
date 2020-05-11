using System;
using System.IO;
using Org.BouncyCastle.X509;

namespace CertDecode1
{
    class Program
    {
        static void Main(string[] args)
        {
            var certificateBase64 = File.ReadAllText("cert.txt");
            var certData = Convert.FromBase64String(certificateBase64);
            var parser = new X509CertificateParser();
            var cert = parser.ReadCertificate(certData);
            Console.WriteLine(cert.SubjectDN);
        }
    }
}
