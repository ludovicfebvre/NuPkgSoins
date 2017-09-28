

namespace TpSoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Prestation
    {
        private string libelle;
        private DateTime dateSoin;
        private Intervenant l_Intervenant;

        /// <summary>
        /// Constructeur de la classe Prestation
        /// </summary>
        /// <param name="unLibelle"></param>
        /// <param name="uneDate"></param>
        /// <param name="unIntervenant"></param>
        public Prestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.libelle = unLibelle;
            this.dateSoin = uneDate;
            this.l_Intervenant = unIntervenant;


        }

        /// <summary>
        /// Fonction qui compare 2 dates de prestations
        /// </summary>
        /// <param name="unePrestation"></param>
        /// <returns>int</returns>
        public int compareTo(Prestation unePrestation)
        {
            if (this.dateSoin.Equals(unePrestation.getDateSoin()))
            {
                return 0;
            }
            else if (this.dateSoin>unePrestation.getDateSoin()){
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Accesseur sur le DateTime datesoin
        /// </summary>
        /// <returns></returns>
        public DateTime getDateSoin()
        {
            return this.dateSoin;
        }

        public Intervenant getL_Intervenant()
        {
            return this.l_Intervenant;
        }
        
        /// <summary>
        /// Affiche les elements de la classe prestation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string prestation = libelle + " - " + dateSoin.Day + "/" + dateSoin.Month + "/";
            prestation += +dateSoin.Year + " " + dateSoin.Hour + ":" + dateSoin.Minute + ":" + dateSoin.Second + " - ";
            prestation += "Intervenant : Dr" + l_Intervenant.ToString() + "\n";
            return prestation;
        }
    }
}
