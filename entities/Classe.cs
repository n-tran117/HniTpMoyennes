using System;
using System.Collections.Generic;
using System.Linq;
namespace TPMoyennes
{
    class Classe
    {

        public string nomClasse;
        public List<Eleve> eleves { get; }
        public List<Matiere> matieres { get; }

        public Classe(string _nomClasse)
        {
            nomClasse = _nomClasse;
            eleves = new List<Eleve>();
            matieres = new List<Matiere>();
        }

        public void ajouterEleve(string prenom, string nom)
        {
            eleves.Add(new Eleve(prenom, nom));
        }

        public void ajouterMatiere(string intitule)
        {
            matieres.Add(new Matiere(intitule));
        }

        public double Moyenne(int matiereId)
        {
            double res = 0;
            foreach (Eleve eleve in eleves)
            {
                res += eleve.Moyenne(matiereId);
            }
            return Math.Round(res / eleves.Count, 2);
        }

        public double Moyenne()
        {
            double res = 0;
            foreach (Eleve eleve in eleves)
            {
                res += eleve.Moyenne();
            }
            return Math.Round(res / eleves.Count, 2);
        }

    }
}