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
            if (eleves.Count < 30)
            {
                eleves.Add(new Eleve(prenom, nom));
            }
            else
            {
                Console.Write("Cette classe a déjà 30 élèves assigné.\n" +
                "Il y en a déjà trop dans cette classe !!!");
            }

        }

        public void ajouterMatiere(string intitule)
        {
            if (matieres.Count < 10)
            {
                matieres.Add(new Matiere(intitule));
            }
            else
            {
                Console.Write("Cette classe a déjà 10 matiere assigné.\n" +
                "Les élèves ne sont pas assez intelligents pour en apprendre plus !!!");
            }

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
            for (int matiere = 0; matiere < matieres.Count; matiere++)
            {
                res += Moyenne(matiere);
            }
            return Math.Round(res / matieres.Count, 2);
        }

    }
}