using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    //les attributs
    public class Etudiant
    {
        private int id;
        private string prenom;
        private string nom;
        private double note1;
        private double note2;
        private double note3;
        private double noteFinal;

        public Etudiant()
        {
            id = 0;
            prenom = "";
            nom = "";
            note1 = 0;
            note2 = 0;
            note3 = 0;
            noteFinal = 0;

        }

        public int getId()
        {
            return id;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public string getNom()
        {
            return nom;
        }

        public double getNote1()
        {
            return note1;
        }
        public double getNote2() 
        {
            return note2;
        }
        public double getNote3() 
        {
            return note3;
        }

      

        //Setters
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetFirstName(string firstName)
        {
            this.prenom = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.nom = lastName;
        }

        public void SetNote1(double note1)
        {
            if (note1 >= 0 && note1 <= 100)
            {
                this.note1 = note1;
            }
        }

        public void SetNote2(double note2)
        {
            if (note2 >= 0 && note2 <= 100)
            {
                this.note2 = note2;
            }
        }

        public void SetNote3(double note3)
        {
            if (note3 >= 0 && note3 <= 100)
            {
                this.note3 = note3;
            }
        }

        //calcul note final
        public void CalculNoteFinal()
        {
            noteFinal = (note1 + note2 + note3) / 3.0;

        }

        // Override à toString
        public override string ToString()
        {
            return "id: " + id + " Prenom: " + prenom + " Note 1: " + note1 + " Note 2: " + note2 +
                   " Note 3: " + note3 +
                   " Note final: " + noteFinal;
        }
    }
}
