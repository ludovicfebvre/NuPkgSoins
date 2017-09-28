//-----------------------------------------------------------------------
// <copyright file="IntervenantExterne.cs" company="FEBVRE">
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
    /// Classe IntervenantExterne
    /// Classe Heritière de la classe Intervenant
    /// </summary>
    public class IntervenantExterne : Intervenant
    {
        /// <summary>
        /// Chaine de caractères
        /// </summary>
        private string specialite;

        /// <summary>
        /// Chaine de caractères
        /// </summary>
        private string adresse;

        /// <summary>
        /// Chaine de caractères
        /// </summary>
        private string tel;

        /// <summary>
        /// Initialise une nouvelle instance de la classe IntervenantExterne.
        /// </summary>
        /// <param name="unNom">Chaine de caractère unNom</param>
        /// <param name="unPrenom">Chaine de caractère unPrenom</param>
        /// <param name="uneSpecialite">Chaine de caractère uneSpecialite</param>
        /// <param name="uneAdresse">Chaine de caractère uneAdresse</param>
        /// <param name="unTel">Chaine de caractère unTel</param>
        public IntervenantExterne(string unNom, string unPrenom, string uneSpecialite, string uneAdresse, string unTel) : base(unNom, unPrenom)
        {
            this.specialite = uneSpecialite;
            this.adresse = uneAdresse;
            this.tel = unTel;
        }

        /// <summary>
        /// Accesseur sur le string specialite
        /// </summary>
        /// <returns>Retourne Chaine de caractères</returns>
        public string GetSpecialite()
        {
            return this.specialite;
        }

        /// <summary>
        /// Accesseur sur le string adresse
        /// </summary>
        /// <returns>Retourne Chaine de caractères</returns>
        public string GetAdresse()
        {
            return this.adresse;
        }

        /// <summary>
        /// Accesseur sur le string tel
        /// </summary>
        /// <returns>Retourne chaine de caractères</returns>
        public string GetTel()
        {
            return this.tel;
        }

        /// <summary>
        /// Affiche les elements de la classe Intervenant Externe
        /// </summary>
        /// <returns>Retourne chaine de caractères</returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité " + this.specialite + "\n               " + this.adresse + " - " + this.tel;
        }
    }
}
