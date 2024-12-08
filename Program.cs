using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Lb3AutoSvrLib;

namespace Lab4ClientConsoleCh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyMath();
            IMyMath pImyMath = obj;
            Console.WriteLine($"Значение свойства Op1: {pImyMath.Op1}");
            int res = pImyMath.Add(pImyMath.Op1, 10);
            Console.WriteLine(res);
            pImyMath.Op1 = 20;
            Console.WriteLine($"Значение свойства Op1: {pImyMath.Op1}");
            int res2 = pImyMath.Add(pImyMath.Op1, 10);
            Console.WriteLine(res2);

            IVer pIver = (IVer)pImyMath;
            Console.WriteLine(pIver.GetAuthor("Poliak A. gr30331"));
            
            Console.ReadLine();
            
            Marshal.ReleaseComObject(pIver);
            Marshal.ReleaseComObject(pImyMath);

        }
    }
}
