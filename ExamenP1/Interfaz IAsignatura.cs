﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP1
{
    public interface Interface1
    {
        double CalcularNotaFinal();

        double CalcularNotaFinal(int N1, int N2, int N3);

        string MensajeNotaFinal(double notaFinal);
    }
}