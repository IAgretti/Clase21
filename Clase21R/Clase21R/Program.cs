namespace Clase21R
{
    internal class Program
    {
        struct fechaNac
        {
            public int dia;
            public int mes;
            public int anio;
        }
      struct Persona
        {
            public string nombre;
            public char inicial;
            public int edad;
            public fechaNac fN;
            public double nota;
        }
        static void Main(string[] args)
        {
            Persona p;
            p.nombre = "Pedro";
            p.inicial = 'P';
            p.edad = 20;
            p.nota = 7.5;
            p.fN.anio = 2010;
            p.fN.mes = 6;
            p.fN.dia = 2;

            Console.WriteLine($"{p.nombre} nació en {p.fN.anio}.");
            Console.WriteLine($"El día {p.fN.dia} del mes {p.fN.mes}.");

            //Array de estructura

            Persona[] per = new Persona[100];
            per[0].nombre = "Pedro";
            per[0].inicial = 'P';
            per[0].edad = 20;
            per[0].nota = 7.5;

            Console.WriteLine("La edad de {0} es {1}.", per[0].nombre, per[0].edad);
            per[1].nombre = "María";
            Console.WriteLine("La edad de {0} es {1}", per[1].nombre, per[1].edad);

            Console.ReadKey();
        }
    }
}