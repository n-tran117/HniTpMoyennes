using System;
using System.Collections.Generic;
using System.Linq;
namespace TPMoyennes
{
    class Classe{

        public string nomClasse;
        public List<Eleve> eleves {get;}
        public List<Matiere> matieres {get;}

        public Classe(string _nomClasse){
            nomClasse=_nomClasse;
            eleves = new List<Eleve>();
            matieres = new List<Matiere>();
        }

        public void ajouterEleve(string prenom, string nom){
            eleves.Add(new Eleve(prenom, nom));
        }

        public void ajouterMatiere(string intitule){
            matieres.Add(new Matiere(intitule));
        }

        public float Moyenne(int matiereId){
            float moyenne = 0;
            foreach(Eleve eleve in eleves){
                moyenne += eleve.Moyenne(matiereId);
            }
            return moyenne/eleves.Count;
        }

        public float Moyenne(){
            float moyenne = 0;
            foreach(Eleve eleve in eleves){
                moyenne += eleve.Moyenne();
            }
            return moyenne/eleves.Count;
        }

    }
}