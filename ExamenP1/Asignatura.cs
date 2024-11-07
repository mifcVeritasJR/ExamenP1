using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExamenP1
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return (N1 + N2 + N3) / 3.0;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60)
                return "Reprobado";
            else if (notaFinal < 80)
                return "Bueno";
            else if (notaFinal < 90)
                return "Muy Bueno";
            else
                return "Sobresaliente";
        }

        public void Imprimir()
        {
            double notaFinal1 = CalcularNotaFinal();
            double notaFinal2 = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine($"Nombre del Alumno: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del Docente: {NombreDocente}");
            Console.WriteLine($"Nota Final (Metodo 1): {notaFinal1} - {MensajeNotaFinal(notaFinal1)}");
            Console.WriteLine($"Nota Final (Metodo 2): {notaFinal2} - {MensajeNotaFinal(notaFinal2)}");
        }
    }
}