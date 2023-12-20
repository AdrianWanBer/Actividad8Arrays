namespace Actividad8Arrays
{
    class program
    {
        public static void Main(String[] args) 
        {
            string[] palabras = { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos" };

            int busqueda = Array.IndexOf(palabras, "Adiós");
            if (busqueda == -1 )
            {
                Console.WriteLine("No esta en la lista");
            }
            else
            {
                Console.WriteLine("La palabra adios existe");
            }

            int[] numeros = { 1, 5, 7, 8, 4, 3, 9 };


            var numerosMayores = numeros.Where(numeros => numeros > 3);
            foreach ( var numero in numerosMayores)
            {
                Console.WriteLine(numero) ;
            }
            
        }
    }
}