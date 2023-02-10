using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Eleve{

        public string nom {get; set;}
        public string prenom {get; set;}
        public List<Note> notesList;

        public Eleve(string _prenom, string _nom){
            nom=_nom;
            prenom=_prenom;
            notesList = new List<Note>();
        }

        public void ajouterNote(Note note){
            notesList.Add(note);
        }

        public float Moyenne(int matiereId){
            float moyenne = 0;
            int nbNote = 0;
            foreach(Note note in notesList){
                if(note.matiere == matiereId){
                    moyenne += note.note;
                    nbNote ++;
                }
            }
            return moyenne/nbNote;
        }

        public float Moyenne(){
            float moyenne = 0;
            foreach(Note note in notesList){
                moyenne += note.note;
            }
            return moyenne/notesList.Count;
        }

    }
}
