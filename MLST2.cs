using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M3 {
    class MLST2 {
        public void init() {
            int[,] notas = new int[5,3];

            for (int i=0; i<5; i++) {
                Console.WriteLine("Introduzca las notas del alumno {0} separadas por [ESPACIO]: ", i);
                
                string notasInput = Console.ReadLine();

                string[] notasAlumno = notasInput.Split(' ');
                int[] intNotasAlumno = ArrayStringToInt(notasAlumno);

                for (int j=0; j<3; j++) {
                    notas[i,j] = intNotasAlumno[j];
                }
            }

            for (int i = 0; i < 5; i++) {
                int media = 0;

                for (int j = 0; j < 3; j++) {
                    media += notas[i, j];
                }

                media /= 3;

                Console.WriteLine("Alumno {0}: {1} - {2}", i, (media<5) ? "Suspendido": "Aprovado");
            }
        }

        private int[] ArrayStringToInt(string[] notasAlumno) {
            int[] newArray = new int[notasAlumno.Length];

            for (int i=0; i<newArray.Length; i++) {
                newArray[i] = int.Parse(notasAlumno[i]);
            }

            return newArray;
        }
    }
}
