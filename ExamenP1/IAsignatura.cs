using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP1
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();

        double CalcularNotaFinal(int N1, int N2, int N3);

        string MensajeNotaFinal(double notaFinal);

        void Imprimir();
    }
}