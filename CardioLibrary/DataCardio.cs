using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string BattitiRiposo(int battito)
        {
            if (battito < 60)
                return "Soffri di bradicardia";
            else if (battito >= 60 && battito <= 100)
                return "Hai un battito normale";
            else
                return "soffri di tachicardia";
        }

        public static double CorsaCamminata(double peso, double km, string corsaCamminata)
        {
            double spesaEnergetica = 0;
            if (corsaCamminata.ToLower() == "corsa")
                spesaEnergetica = 0.9 * km * peso;
            else if (corsaCamminata.ToLower() == "camminata")
                spesaEnergetica = 0.50 * km * peso;


            return Math.Round(spesaEnergetica, 2);
        }

        public static double CalorieBruciate(string genere, int f, float p, int a, double t)
        {
            double calcoloTempo = t * 4.184;
            double c;
            if (genere.ToLower() == "uomo")
            {
                c = ((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969) * calcoloTempo;
            }
            else if (genere.ToLower() == "donna")
            {
                c = ((a * 0.074) + (p * 0.126) + (f * 0.4472) - 29.4022) * calcoloTempo;
            }
            else
            {
                throw new Exception("Errore: genere non valido");
            }
            return Math.Round(c, 2);

        }
        public static string btmMaxMin(int eta)
        {
            int freqMax = 220 - eta;
            double freqMinAll = (freqMax * 70) / 100;
            double freqMaxAll = (freqMax * 90) / 100;
            return ($"{freqMaxAll} {freqMinAll}");
        }

    }
}
