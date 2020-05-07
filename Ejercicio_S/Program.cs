using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ejercicio_S
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //cargar persona (leer el archivo serializado)
            //almacenar listar de personas

            // clase persona (nombre, apellido, edad)
            // menu (crear persona, mostrar personas)
            //metodo cargar
            // metodo serializar (guardar la lista de personas en un archivo)

            //Metodo crear persona


            Persona CrearP(string N, string A, int E)
            {
                Persona px = new Persona(N, A, E);
                return px;
            }
            

            string m1 = ("Bienvenido que opcion desea realizar?");
            string m2 = ("1) Crear Persona");
            string m3 = ("2) Guardar Personas");
            string m4 = ("3) Cargar Personas");
            string m5 = ("4) Cerrar Programa");

            Console.WriteLine(m1);
            List<Persona> personas = new List<Persona>();
            IFormatter formatter = new BinaryFormatter();
            while (true)
            {
                Console.WriteLine("\n" + m2 + "\n" + m3+"\n" + m4+"\n" + m5+"\n");
                string str = Console.ReadLine();
                

                if (str == "1")
                {
                    Console.WriteLine("Ingrese el Nombre, Apellido y edad de la persona");
                    string Nom = Console.ReadLine();
                    string Ape = Console.ReadLine();
                    string Eda = Console.ReadLine();

                    personas.Add(CrearP(Nom,Ape,Int32.Parse(Eda)));
                    
                }
              
                if (str == "2")
                {
                    
                    foreach (Persona x in personas)
                    {
                        
                        Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, x);
                        stream.Close();
                    }
                    
                }
                if (str == "3")
                {
                   
                    foreach (Persona X in personas)
                    {
                        
                        Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Persona persona = (Persona)formatter.Deserialize(stream);

                        stream.Close();

                        Console.WriteLine(persona.Show());
                    }
                }
                if (str=="4")
                {
                    break;
                }



            }


            
            




            
        }
    }
}
