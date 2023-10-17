class _char
{
    public _char()
    {
    }

    public void imprimir_char()
    {

        int tamano1 = 0;
        int[] _chars = { 80, 117, 116, 111, 32, 101, 108, 32, 113, 117, 101, 32, 108, 111, 32, 108, 101, 97 };
        tamano1 = _chars.Length;

        char[] puto = new char[tamano1];

        int tamano2 = puto.Length;

        int[] como = new int[tamano2];


        for (int i = 0; i < puto.Length; i++)
        {
            puto[i] = (char)_chars[i];
        }
        for (int i = 0; i < puto.Length; i++)
        {
            como[i] = (int)puto[i];
        }
        
        string strin = new string(puto);

         Console.WriteLine(strin);
            Console.WriteLine(puto);
            Console.WriteLine(string.Join("-", como));
        
    }

    public void imprimir_2()
    {
        string nom1 = "The";
        string nom2 = "Dog";

    }
    public void imprimir_3() 
    {
        string string1 = "Today is " + DateTime.Now.ToString("d") + ".";
        Console.WriteLine(string1);
        
    }
    public void imprimir_4()
    {
        string sentence = "This sentence has five words.";
        // Extract the second word.
        int startPosition = sentence.IndexOf(" ") + 1;
        string word2 = sentence.Substring(startPosition,
                                          sentence.IndexOf(" ", startPosition) - startPosition);
        Console.WriteLine("Second word: " + word2);



        string frase = "Lo peor que una niña de 10 años fue la que me hizo la pregunta";

        int espacio1 = frase.IndexOf(" ")+1;
        int espacio2 = frase.IndexOf(" ",espacio1)+1;
        string segundaPalabra = frase.Substring(espacio2,frase.IndexOf(" ",espacio2)-espacio2);
        Console.WriteLine(segundaPalabra);
    }
    public void imprimir_5()
    {
        DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
        double temperature = 68.3;
        string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F2} degrees Fahrenheit.",
                                      dateAndTime, temperature);
        Console.WriteLine(result);
    }
    public void imprimir_6()
    {
        int p = 500;
        Console.WriteLine(string.Format("hola {0:x}",p));
    
    }public void imprimir_7()
    {
        string frase = "Lo peor que una niña de 10 años fue la que me hizo la pregunta";
        string frase1 = "pregunta";
        int pp = frase1.Length;
     //   Console.WriteLine(pp);
        string q = frase.Substring(24, 12);
        string q2 = frase.Substring(8, 4);
       string  q3= frase.Substring(36,3);
       string  q4= frase.Substring(16,5);
       string  q5= frase.Substring(43,11);
       string  q6= frase.Substring(3,5);
       string  q7= frase.Substring(54,8);

        Console.WriteLine(string.Concat(q,q2,q3,q4,q5,q6,q7));
    }
}