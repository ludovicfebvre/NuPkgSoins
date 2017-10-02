//-----------------------------------------------------------------------
// <copyright file="Dossier.cs" company="FEBVRE">
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
    /// Classe Dossier
    /// </summary>
    public class Dossier
    {
        /// <summary>
        /// Chaîne de caractères
        /// </summary>
        private string nomPatient;

        /// <summary>
        /// Chaîne de caractères
        /// </summary>
        private string prenomPatient;

        /// <summary>
        /// Objet de type DateTime
        /// </summary>
        private DateTime dateNaissancePatient;

        /// <summary>
        /// Liste d'objets de type Prestation
        /// </summary>
        private List<Prestation> mesPrestations;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Dossier.
        /// </summary>
        /// <param name="unNomPatient">Chaîne de caractères unNomPatient</param>
        /// <param name="unPrenomPatient">Chaîne de caractères unPrenomPatient</param>
        /// <param name="uneDate">Objet de type DateTimee</param>
        public Dossier(string unNomPatient, string unPrenomPatient, DateTime uneDate)
        {
            this.nomPatient = unNomPatient;
            this.prenomPatient = unPrenomPatient;
            this.dateNaissancePatient = uneDate;
            this.mesPrestations = new List<Prestation>();
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Dossier.
        /// </summary>
        /// <param name="unNomPatient">Chaîne de caractères unNomPatient</param>
        /// <param name="unPrenomPatient">Chaîne de caractères unPrenomPatient</param>
        /// <param name="uneDate">Objet de type DateTimee</param>
        /// <param name="unePrestation">Objet de type Prestation</param>
        public Dossier(string unNomPatient, string unPrenomPatient, DateTime uneDate, Prestation unePrestation)
        {
            this.nomPatient = unNomPatient;
            this.prenomPatient = unPrenomPatient;
            this.dateNaissancePatient = uneDate;
            this.mesPrestations = new List<Prestation>();
            this.mesPrestations.Add(unePrestation);
        }

        /// <summary>
        /// Ajoute une préstation à la liste de préstation
        /// </summary>
        /// <param name="unLibelle">Chaine de caractères unLibelle</param>
        /// <param name="uneDate">Objet de type DateTime</param>
        /// <param name="unIntervenant">Objet de type Intervenant</param>
        public void AjouterPrestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.mesPrestations.Add(new Prestation(unLibelle, uneDate, unIntervenant));
        }

        /// <summary>
        /// Obtient le nombre de prestatation Externe
        /// </summary>
        /// <returns>Retourne un entier</returns>
        public int GetNbPrestationsExternes()
        {
            int cpt = 0;
            foreach (Prestation unePrestation in this.mesPrestations)
            {
                if (unePrestation.GetL_Intervenant() is IntervenantExterne)
                {
                    cpt++;
                }
            }

            return cpt;
        }

        /// <summary>
        /// Obtient le nombre de prestation
        /// </summary>
        /// <returns>Retourne un entier</returns>
        public int GetNbPrestations()
        {
            return this.mesPrestations.Count;
        }
        
        /// <summary>
        /// Obtient le nombre de jours de soins
        /// </summary>
        /// <returns>Retourne une liste d'objet de type DateTime</returns>
        public int GetNbJoursSoins()
        {
            List<DateTime> mesDates = new List<DateTime>();
            foreach (Prestation unePrestation in this.mesPrestations)
            {
                if (!mesDates.Contains(unePrestation.GetDateSoin().Date))
                {
                    mesDates.Add(unePrestation.GetDateSoin());
                }
            }

            return mesDates.Count();
        }

        /// <summary>
        /// Affiche les elements d'un dossier
        /// </summary>
        /// <returns>Retourne une chaîne de caractères</returns>
        public override string ToString()
        {
            string dossier;
            dossier = "\nNombre de dossiers : 1" + "\n" + "----- Début dossier ---------------\n";
            dossier += "Nom : " + this.nomPatient + " Prénom : " + this.prenomPatient + " Date de naissance : " + this.dateNaissancePatient.Day + "/" + this.dateNaissancePatient.Month + "/" + this.dateNaissancePatient.Year + "\n";
            foreach (Prestation unePrestation in this.mesPrestations)
            {
                dossier += unePrestation.ToString();
            }

            dossier += "\n" + "Nombre de jours de soins V1 : " + this.GetNbJoursSoins() + " \n";
            dossier += "Nombre de soins externes : " + this.GetNbPrestationsExternes() + "\n";
            dossier += "----- Fin dossier ---------------\n";
            dossier += "\n";
            return dossier;
        }
    }
}
