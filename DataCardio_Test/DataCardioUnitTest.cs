using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Test
{
    [TestClass]
    public class DataCardioUnitTest
    {
        [DataTestMethod]
        [DataRow(10, "Frequenza massima :189, Frequenza minima :147")]
        [DataRow(20, "Frequenza massima :180, Frequenza minima :140")]
        [DataRow(30, "Frequenza massima :171, Frequenza minima :133")]
        [DataRow(40, "Frequenza massima :162, Frequenza minima :126")]
        [DataRow(50, "Frequenza massima :153, Frequenza minima :119")]
        [DataRow(60, "Frequenza massima :144, Frequenza minima :112")]
        [DataRow(70, "Frequenza massima :135, Frequenza minima :105")]

        public void freqMaxMin(int eta, string risultatoAspettato)
        {
            string risposta = DataCardio.btmMaxMin(eta);
            Assert.AreEqual(risultatoAspettato, risposta);
        }
        [DataTestMethod]
        [DataRow(10, "Soffri di bradicardia")]
        [DataRow(35, "Soffri di bradicardia")]
        [DataRow(40, "Soffri di bradicardia")]
        [DataRow(60, "Hai un battito normale")]
        [DataRow(79, "Hai un battito normale")]
        [DataRow(100, "Hai un battito normale")]
        [DataRow(110, "soffri di tachicardia")]
        [DataRow(150, "soffri di tachicardia")]

        public void BattitiRiposo(int batitti, string risultatoAspettato)
        {
            string risposta = DataCardio.BattitiRiposo(batitti);
            Assert.AreEqual(risposta, risultatoAspettato);
        }
        [DataTestMethod]
        [DataRow(true, 70, 70, 19, 50, 1428.5)]
        [DataRow(false, 80, 60, 60, 30, 2306.28)]
        [DataRow(true, 90, 80, 40, 60, 6444.72)]
        [DataRow(false, 65, 50, 14, 100, 2929.55)]
        [DataRow(true, 75, 40, 10, 77, 708)]
        [DataRow(false, 85, 64, 17, 200, 15005.33)]

        public void CalorieBruciate_Test(bool isUomo, int freq, float peso, int anni, double tempo, double risultatoEffettivo)
        {
            double risultatoAspettato = DataCardio.CalorieBruciate(isUomo, freq, peso, anni, tempo);
            Assert.AreEqual(risultatoAspettato, risultatoEffettivo);
        }
        [DataTestMethod]
        [DataRow(60.5, 12, "corsa", 653.4)]
        [DataRow(55.7, 7, "CORSA", 350.91)]
        [DataRow(82.4, 17, "camminata", 700.4)]
        [DataRow(90.5, 4, "CAMMINATA", 181)]

        public void CorsaCamminata(double peso, double km, string corsaCamminata, double risulatoAspettato)
        {
            double risposta = DataCardio.CorsaCamminata(peso, km, corsaCamminata);
            Assert.AreEqual(risposta, risulatoAspettato);
        }   
        [DataTestMethod]
        [DataRow(78, true)]
        [DataRow(68, true)]
        [DataRow(61, true)]
        [DataRow(94, true)]
        [DataRow(62, true)]
        [DataRow(78, true)]
        [DataRow(66, true)]
        [DataRow(58, false)]
        [DataRow(88, true)]
        [DataRow(100, true)]
        public void BattitiRiposo(int battiti, bool risultato)
        {
            bool risposta = DataCardio.BattitiRiposoFile(battiti);
            Assert.AreEqual(risultato, risposta);
        }
        [DataTestMethod]
        [DataRow(69.81)]
        public void MediaGiornaliera(double risultato)
        {
            double risposta = DataCardio.LetturafileMediaGiornaliera();
            Assert.AreEqual(risultato, risposta);
        }
        [DataTestMethod]
        [DataRow(0.358)]
        public void Variabilit�Battito(double risultato)
        {
            double risposta = DataCardio.Variabilit�();
            Assert.AreEqual(risultato, risposta);
        }
    }
}
