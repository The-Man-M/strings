namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamano1= 0;
            int[] _chars = {80,117,116,111,32, 101,108,32,113,117,101,32,108,111,32,108,101,97 };
         tamano1 = _chars.Length;
            
            char[] puto = new char[tamano1];
           int tamano2 = puto.Length;   
            int[] como = new int[tamano2];

            for (int i = 0;i<puto.Length;i++)
            {
              puto[i]=(char)_chars[i];
            }
            for (int i = 0; i<puto.Length;i++)
            {
                como[i] = (int)puto[i];
            }
                Console.WriteLine(puto);
            Console.WriteLine(string.Join("-",como));
            

        }
    }
}