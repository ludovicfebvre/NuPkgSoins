/// <summary>
/// File Header
/// </summary>
namespace TpSoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/// <summary>
/// Classe Intervenant
/// </summary>
    public class Intervenant
    {
        private string nom;
        private string prenom;
        private List<Prestation> lesPrestations;

        /// <summary>
        /// Constructeur de la classe Intervenant
        /// </summary>
        /// <param name="unNom"></param>
        /// <param name="unPrenom"></param>
        public Intervenant(string unNom, string unPrenom)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            lesPrestations = new List<Prestation>();
        }

        /// <summary>
        /// Accesseur sur le string nom
        /// </summary>
        /// <returns></returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Accesseur sur le string prenom
        /// </summary>
        /// <returns></returns>
        public string getPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// Ajoute une prestation à la liste de prestation
        /// </summary>
        /// <param name="unePrestation"></param>
        public void ajouterPrestation(Prestation unePrestation)
        {
            lesPrestations.Add(unePrestation);
        }

        /// <summary>
        /// Affiche les elements d'un intervenant
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nom + " - " + prenom ;
        }
    }
}
