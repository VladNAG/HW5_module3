using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HW5_module3
{
    internal class Program
    {
        public static async void Main(string[] args)
        {
           await Starer.Start();
        }
    }
}