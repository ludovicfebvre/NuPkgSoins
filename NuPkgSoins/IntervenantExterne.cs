
namespace TpSoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Constructeur de la classe Intervenant Externe
        /// </summary>
        /// <param name="unNom"></param>
        /// <param name="unPrenom"></param>
        /// <param name="uneSpecialite"></param>
        /// <param name="uneAdresse"></param>
        /// <param name="unTel"></param>
        public IntervenantExterne(string unNom, string unPrenom, string uneSpecialite, string uneAdresse, string unTel) : base(unNom, unPrenom)
        {
            this.specialite = uneSpecialite;
            this.adresse = uneAdresse;
            this.tel = unTel;
        }

        /// <summary>
        /// Accesseur sur le string specialite
        /// </summary>
        /// <returns></returns>
        public string getSpecialite()
        {
            return this.specialite;
        }

        /// <summary>
        /// Accesseur sur le string adresse
        /// </summary>
        /// <returns></returns>
        public string getAdresse()
        {
            return this.adresse;
        }

        /// <summary>
        /// Accesseur sur le string tel
        /// </summary>
        /// <returns></returns>
        public string getTel()
        {
            return this.tel;
        }

        /// <summary>
        /// Affiche les elements de la classe Intervenant Externe
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité " + specialite + "\n               " + adresse + " - " + tel;
        }
    }
}
