using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conapp01
{
    interface IPrintScanTasks
    {
        void PrintContent(string content);
        void ScanContent(string content);
        void PhotoCopyContent(string content);  //xerox feature
    }
    interface IFaxTasks
    {
        void FaxContent(string content);
    }
    interface IDuplexTaskx
    {
        void PrintDuplexContent(string content);
    }
    class HpPrinter : IPrintScanTasks, IFaxTasks
    {
        public void FaxContent(string content)
        {
            Console.WriteLine("Can Send fax to the destination");
        }

        public void PhotoCopyContent(string content)
        {
            Console.WriteLine("Can take xerox copy");
        }

        public void PrintContent(string content)
        {
            Console.WriteLine("Can take a printout");
        }

        public void ScanContent(string content)
        {
            Console.WriteLine("Can scan content to system");
        }
    }
    class CanonPrinter : IPrintScanTasks, IDuplexTaskx
    {

        public void PhotoCopyContent(string content)
        {
            Console.WriteLine("photo copy print features");
        }

        public void PrintContent(string content)
        {
            Console.WriteLine("Print features");
        }

        public void PrintDuplexContent(string content)
        {
            Console.WriteLine("print and duplex features");
        }

        public void ScanContent(string content)
        {
            Console.WriteLine("scanf features");
        }
    }
    class InterfaceSegregationPrinciple
    {
        static void Main(string[] args)
        {
            string msg = "Content";
            HpPrinter o1 = new HpPrinter();
            o1.FaxContent(msg); o1.PrintContent(msg); o1.ScanContent(msg); o1.PhotoCopyContent(msg);

            CanonPrinter o2 = new CanonPrinter();
            o2.PhotoCopyContent(msg); o2.PrintDuplexContent(msg);
        }
    }
}
