using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolme_Operatorsuz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bolunen reqemi daxil edin: ");
            int bolunen;
            bolunen = Int32.Parse(Console.ReadLine());

            Console.Write("bolen reqemi daxil edin: ");
            int bolen;
            bolen = Int32.Parse(Console.ReadLine());

            int netice=0;
            int qaliq=bolunen;

            while(qaliq>=bolen)
            {
                qaliq = qaliq - bolen;
                netice++;
            }

            Console.WriteLine("{0} reqemini {1} reqemine boldukde netice {2} qaliq ise {3}-dir",bolunen,bolen,netice,qaliq);
        }
    }
}
