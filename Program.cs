using System; 

class URI {

    static void Main(string[] args) { 

         string entrada = Console.ReadLine();
         string[] valores = entrada.Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
            int d = int.Parse(valores[3]);

            if (b > c && d > a && c+d > a+b && a % 2 == 0 && c > 0 && d > 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }



        
    }

}