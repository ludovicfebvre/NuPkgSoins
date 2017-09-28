//-----------------------------------------------------------------------
// <copyright file="Prestation.cs" company="FEBVRE">
// All rights reserved.
// </copyright>
// <author>Ludovic FEBVRE</author>
//-----------------------------------------------------------------------
namespace TpSoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Classe Prestation
    /// </summary>
    public class Prestation
    {
        /// <summary>
        /// Chaine de caractère
        /// </summary>
        private string libelle;

        /// <summary>
        /// Objet de type DateTime
        /// </summary>
        private DateTime dateSoin;

        /// <summary>
        /// Objet de type Intervenant
        /// </summary>
        private Intervenant unIntervenant;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Prestation.
        /// </summary>
        /// <param name="unLibelle">Chaine de caractères unLibelle</param>
        /// <param name="uneDate">Objet de type DateTime</param>
        /// <param name="unIntervenant">Objet de type Intervenant</param>
        public Prestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.libelle = unLibelle;
            this.dateSoin = uneDate;
            this.unIntervenant = unIntervenant;
        }

        /// <summary>
        /// Compare les dates
        /// </summary>
        /// <param name="unePrestation">Objet de type Prestation</param>
        /// <returns>Retourne un entier compris entre -1 et 1.</returns>
        public int CompareTo(Prestation unePrestation)
        {
            if (this.dateSoin.Equals(unePrestation.GetDateSoin()))
            {
                return 0;
            }
            else if (this.dateSoin > unePrestation.GetDateSoin())
            {
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
        /// <returns>Retourne dateSoin</returns>
        public DateTime GetDateSoin()
        {
            return this.dateSoin;
        }

        /// <summary>
        /// Accesseur sur unIntervenant
        /// </summary>
        /// <returns>Retourne unIntervenant</returns>
        public Intervenant GetL_Intervenant()
        {
            return this.unIntervenant;
        }
        
        /// <summary>
        /// Affiche les elements de la classe prestation
        /// </summary>
        /// <returns>Retourne une chaines de caractères</returns>
        public override string ToString()
        {
            string prestation = this.libelle + " - " + this.dateSoin.Day + "/" + this.dateSoin.Month + "/";
            prestation += this.dateSoin.Year + " " + this.dateSoin.Hour + ":" + this.dateSoin.Minute + ":" + this.dateSoin.Second + " - ";
            prestation += "Intervenant : Dr" + this.unIntervenant.ToString() + "\n";
            return prestation;
        }
    }
}
