using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M3 {
    class MLST3 {
        public void Fibonacci(int n) {
            int n1 = 0, n2 = 1, n3;
            
            Console.Write(n1 + " " + n2 + " "); 

            for (int i = 2; i < n; ++i) {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
