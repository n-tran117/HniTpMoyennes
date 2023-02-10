using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Eleve
    {

        public string nom { get; set; }
        public string prenom { get; set; }
        public List<Note> notesList;

        public Eleve(string _prenom, string _nom)
        {
            nom = _nom;
            prenom = _prenom;
            notesList = new List<Note>();
        }

        public void ajouterNote(Note note)
        {
            notesList.Add(note);
        }

        public double Moyenne(int matiereId)
        {
            double res = 0;
            int nbNote = 0;
            foreach (Note note in notesList)
            {
                if (note.matiere == matiereId)
                {
                    res += note.note;
                    nbNote++;
                }
            }

            return Math.Round(res / nbNote, 2);
        }

        public double Moyenne()
        {
            double res = 0;
            foreach (Note note in notesList)
            {
                res += note.note;
            }
            return Math.Round(res / notesList.Count, 2);
        }

    }
}
