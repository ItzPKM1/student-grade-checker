using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    public static class FindMinMax
    {
        // pré-condition : le tableau n'est pas vide
        //post-condition: cela retourne min et max
        //complexité : O(n)
        public static double[] findMinMax(Etudiant[] students, int count)
        {
            //faire quelque chose pour handler le cas ou le tableau est vide
            if (count == 0)
            {
                throw new ArgumentException("Le tableau d'étudiants est vide.");
            }
            
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                double grade = students[i].getNoteFinal();

                if (grade < minValue)
                {
                    minValue = grade;
                }
            

                if (grade > maxValue)
                {
                    maxValue = grade;
                }
            }
        return new double[] { minValue, maxValue }; 
        }
    }
}

    
