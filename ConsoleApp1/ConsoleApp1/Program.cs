using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");

            var random = new Random();
            var persona = new Persona
            {
                Id = random.Next(),
                Nombre = "José",
                Apellido = "Mendoza",
                Trabajo = new Trabajo
                {
                    Id = random.Next(),
                    Nombre = "Programador",
                    Cargo = "Programador Junior",
                    Sueldo = 1500,
                },
                Portatil = new Portatil
                {
                    Id = random.Next(),
                    Marca = "DELL",
                    Procesador = "Intel Core i7",
                    Precio = 1200,
                },
                Ubicacion = new Ubicacion
                {
                    Id= random.Next(),
                    Ciudad = "Quito",
                    Direccion = "José Tamayo &, Quito 170143",
                }
            };

            Console.WriteLine(persona.Saludar());
            Console.WriteLine(persona.Trabajar());
            Console.WriteLine(persona.Ubicar());

            Console.ReadKey();
        }
    }
}
