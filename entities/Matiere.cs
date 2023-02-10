using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Matiere
    {

        public readonly int matiereId = 0;
        public string matiereIntitule { get; }

        public Matiere(string intitule)
        {
            matiereIntitule = intitule;
            matiereId++;
        }

        public override string ToString()
        {
            return matiereIntitule;
        }

    }
}
