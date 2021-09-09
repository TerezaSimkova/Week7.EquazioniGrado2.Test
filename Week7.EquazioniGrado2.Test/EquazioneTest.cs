using System;
using Week7.EquazioniGrado2.Core;
using Xunit;

namespace Week7.EquazioniGrado2.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //prende in input tre double e mi restituisce una array

            //Arrange: predispozione del test
            Equation equazione = new Equation();

            //ACT:chiamata alla funzinalita da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 2);

            //ASSERT: verifica risultato
            Assert.True(risultato.Length == 2); //due risultati x1 e x2,si aspetta bool
            Assert.Equal(1, risultato[0]); //alternativa: Assert.True(risultato[0]==1);
            Assert.Equal(2, risultato[1]);
        }

        [Fact]

        public void Test2()
        {
            Equation equazione = new Equation();
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);

            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]);
            Assert.Equal(3, risultato[1]);
        }

        [Fact]

        public void Test3()
        {
            Equation equazione = new Equation();
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, 2, 1);

            Assert.True(risultato.Length == 1);
            Assert.Equal(-1, risultato[0]);
        }

        [Fact]

        public void Test4()
        {
            Equation equazione = new Equation();
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 10);

            Assert.Null(risultato);
        }
    }
}
