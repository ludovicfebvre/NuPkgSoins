//-----------------------------------------------------------------------
// <copyright file="Intervenant.cs" company="FEBVRE">
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
/// Classe Intervenant
/// </summary>
    public class Intervenant
    {
        /// <summary>
        /// Chaine de caractères
        /// </summary>
        private string nom;

        /// <summary>
        /// Chaine de caractères
        /// </summary>
        private string prenom;

        /// <summary>
        /// List d'objets de la classe Prestation
        /// </summary>
        private List<Prestation> lesPrestations;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Intervenant.
        /// </summary>
        /// <param name="unNom">Chaine de caractères unNom</param>
        /// <param name="unPrenom">Chaine de caractères unPrenom</param>
        public Intervenant(string unNom, string unPrenom)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.lesPrestations = new List<Prestation>();
        }

        /// <summary>
        /// Accesseur sur le string nom
        /// </summary>
        /// <returns>Retroune le nom</returns>
        public string GetNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Accesseur sur le string prenom
        /// </summary>
        /// <returns>retourne le prénom</returns>
        public string GetPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// Ajoute une prestation à la liste de prestation
        /// </summary>
        /// <param name="unePrestation"> Objet de la classe Prestation</param>
        public void AjouterPrestation(Prestation unePrestation)
        {
            this.lesPrestations.Add(unePrestation);
        }

        /// <summary>
        /// Affiche les elements d'un intervenant
        /// </summary>
        /// <returns>Retourne une chaine de caractères</returns>
        public override string ToString()
        {
            return this.nom + " - " + this.prenom;
        }
    }
}
