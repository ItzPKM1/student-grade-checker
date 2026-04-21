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
        private Dictionary<int, Etudiant> tableauHash;


        //constructor

        public GestionEtudiants(int size)
        {
            etudiant = new Etudiant[size];
            nombreEtudiants = 0;
            tableauHash = new Dictionary<int, Etudiant>();
        }

        public void ajouterEtudiant(Etudiant e)
        {
            //
        }
        
        public void afficherEtudiants()
        {
            for (int i = 0; i < nombreEtudiants; i++)
            {
                Console.WriteLine(etudiant[i].ToString());
            }
        }
        public Etudiant LinearSearchID(int id)
        {
            for (int i = 0; i < nombreEtudiants; i++)
            {
                if (etudiant[i].getId() == id)
                {
                    return etudiant[i];
                }
            }
            return null;
        }

        //comme tutorialspoint.com
        public void QuickSortByID()
        {
            QuickSort(0, nombreEtudiants - 1);
        }
        public void Swap(int num1, int num2)
        {
            Etudiant temp = etudiant[num1];
            etudiant[num1] = etudiant[num2];
            etudiant[num2] = temp;
        }
        private int Partition(int left, int right, int pivot)
        {
            int leftPointer = left - 1;
            int rightPointer = right;

            while (true)
            {
                while (etudiant[++leftPointer].getId() < pivot) { }
                while (rightPointer > 0 && etudiant[--rightPointer].getId() > pivot) { }

                if (leftPointer >= rightPointer)
                {
                    break;
                }
                else
                {
                    Swap(leftPointer, rightPointer);
                }
            }
            Swap(leftPointer, right);
            return leftPointer;
        }
        public void QuickSort(int left, int right)
        {
            if (right - left <= 0)
            {
                return;
            }
            else
            {
                int pivot = etudiant[right].getId();
                int partitionPoint = Partition(left, right, pivot);
                QuickSort(left, partitionPoint - 1);
                QuickSort(partitionPoint + 1, right);
            }
        }

        public int getNombreEtudiants()
        {
            return nombreEtudiants;
        }

        public Etudiant getEtudiantById(int id)
        {
            if (tableauHash.ContainsKey(id))
            {
                return tableauHash[id];
            }
            else
            {
                return null;
            }
        }
    }
}
