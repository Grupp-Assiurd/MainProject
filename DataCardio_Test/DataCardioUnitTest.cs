using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Test
{
    [TestClass]
    public class DataCardioUnitTest
    {
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
        [DataRow("uomo", 70, 70, 19, 50, 1428.5)]
        [DataRow("donna", 80, 60, 60, 30, 2306.28)]
        [DataRow("uomo", 90, 80, 40, 60, 6444.72)]
        [DataRow("donna", 65, 50, 14, 100, 2929.55)]
        [DataRow("uomo", 75, 40, 10, 77, 708)]
        [DataRow("donna", 85, 64, 17, 200, 15005.33)]

        public void CalorieBruciate_Test(string genere, int freq, float peso, int anni, double tempo, double risultatoEffettivo)
        {
            double risultatoAspettato = DataCardio.CalorieBruciate(genere, freq, peso, anni, tempo);
            Assert.AreEqual(risultatoAspettato, risultatoEffettivo);
        }

        [DataTestMethod]
        [DataRow(10, "189 147")]
        [DataRow(20, "180 140")]
        [DataRow(30, "171 133")]
        [DataRow(40, "162 126")]
        [DataRow(50, "153 119")]
        [DataRow(60, "144 112")]
        [DataRow(70, "135 105")]

        public void freqMaxMin(int eta, string risultatoAspettato)
        {
            string risposta = DataCardio.btmMaxMin(eta);
            Assert.AreEqual(risultatoAspettato, risposta);
        }

    }
}
