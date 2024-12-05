namespace UtilsLibrary
{
    public class Utils
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }

        public static bool FindNumber(int[] array, int number) {
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] == number) { return true; }
            }
            return false;
        }
    }

}
