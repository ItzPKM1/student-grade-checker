using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    public class GestionEtudiants
    {

        //attributs
        private Etudiant[] etudiant;
        private int nombreEtudiants;


        //constructor

        public GestionEtudiants(int size)
        {
            etudiant = new Etudiant[size];
            nombreEtudiants = 0;
        }


        
    }
}
