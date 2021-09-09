using System;

namespace Week7.EquazioniGrado2.Core
{
    public class Equation
    {
        public double[] RisolviEquazioneDiSecondoGrado(double a, double b, double c)
        {
            //Calcolo del delta

            double delta = Math.Pow(b, 2) - (4 * a * c); //Pow prende b e poi devo mettere 2 alla seconda
            double[] risultato; //dicchiarato

            if (delta == 0)
            {
                risultato = new double[1];
                risultato[0] = -b / (2 * a);
                return risultato;
            }
            if (delta > 0)
            {
                risultato = new double[2];
                risultato[0] = (-b - Math.Sqrt(delta)) / (2 * a);
                risultato[1] = (-b + Math.Sqrt(delta)) / (2 * a);
                return risultato;
            }
            return null;//terzo caso se e null delta<0 - equazione impossibile
        }

    }
}
