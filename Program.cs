using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(BerechneSummeBis(100));
            Console.ReadLine();
        }

        //static int BerechneSummeBis(int n) {
        //    for (int i = 0; i == n; i++) {
        //        result += i;
        //    }



        //    return result;
        //}

        static int BerechneSummeBis(int n) {
            if (n == 1) {
                return 1;
            }
            return BerechneSummeBis(n - 1) + n;

        }
    }
}
