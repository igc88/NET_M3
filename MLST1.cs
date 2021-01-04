using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M3 {
    class MLST1 {
        public void fase1() {
            string barcelona, madrid, valencia, malaga, cadis, santander;
            string[] arrayCiudades = new string[6];
            string[] arrayCiudadesModificadas = new string[6];

            Console.WriteLine("Intruduzca los nombres de las ciudades por teclado: ");
            
            barcelona = Console.ReadLine();
            madrid = Console.ReadLine();
            valencia = Console.ReadLine();
            malaga = Console.ReadLine();
            cadis = Console.ReadLine();
            santander = Console.ReadLine();

            Console.WriteLine("Las ciudades introducidas son: {0}, {1}, {2}, {3}, {4}, {5}", barcelona, madrid, valencia, malaga, cadis, santander);

            arrayCiudades[0] = barcelona;
            arrayCiudades[1] = madrid;
            arrayCiudades[2] = valencia;
            arrayCiudades[3] = malaga;
            arrayCiudades[4] = cadis;
            arrayCiudades[5] = santander;

            Console.WriteLine("Ciudades en orden alfabético: ");
            Array.Sort(arrayCiudades);

            foreach (string ciudad in arrayCiudades) {
                Console.WriteLine(ciudad);
            }

            for (int i=0; i<arrayCiudades.Length; i++) {
                arrayCiudadesModificadas[i] = arrayCiudades[i].Replace("a", "4");
            }

            Console.WriteLine("Ciudades modificadas: ");
            foreach (string ciudad in arrayCiudadesModificadas) {
                Console.WriteLine(ciudad);
            }

            char[] arrayBarcelona = barcelona.ToCharArray();
            char[] arrayMadrid = madrid.ToCharArray();
            char[] arrayValencia = valencia.ToCharArray();
            char[] arrayMalaga = malaga.ToCharArray();
            char[] arrayCadis = cadis.ToCharArray();
            char[] arraySantander = santander.ToCharArray();

            showCharArray(arrayBarcelona);
            showCharArray(arrayMadrid);
            showCharArray(arrayValencia);
            showCharArray(arrayMalaga);
            showCharArray(arrayCadis);
            showCharArray(arraySantander);
        }

        private void showCharArray(char[] array) {
            Array.Reverse(array);
            
            foreach (char c in array) {
                Console.Write(c);
            }

            Console.WriteLine();
        }
    }
}
