using System;
using System.Collections.Generic;


namespace EngineeringCore.Algorithms.Sorting
{
    //Create extenstion methods for List types.duck typing and fluent 
    //the first parameter this extends the  IList implementations 
    public static class Bubblesort
    {
        
        public static void BubblesortAscending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            bool swapped;
            do
            {
                swapped = false;
                
                for (int i =0; i < (collection.Count -1); i++)
                {
                    if( comparer.Compare(collection[i], collection[i+1]) > 0 )
                    {
                        var temp = collection[i];
                        collection[i] = collection[i + 1];
                        collection[i + 1] = temp;
                        swapped = true;                        
                    }
                }

            }while( swapped == true )  ;
        }

        public static void BubblesortDescending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            if( comparer.Compare)
                 
        } 
    }
}
