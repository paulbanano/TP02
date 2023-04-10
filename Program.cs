namespace Tp02;
class Program
{
    static List<Persona> listaPersonas = new List<Persona>();
    static void Main(string[] args)
    {
       int elccPers = 0, votantes = 0, edadTotal = 0, edadPromedio = 0;
       bool votar = false;
       
       while(elccPers!=5){
        menu();
        elccPers = ingresarInt("Ingrese que quiere hacer");
        if(elccPers == 1){ 
            int dni = ingresarInt("Ingrese su Dni");
            string ape = ingresarString("Ingrese su apellido");
            string nom = ingresarString("Ingresa su nombre");
            DateTime fnac = ingresarDateTime("Ingrese su fecha de nacimiento");
            string email = ingresarString("Ingrese su email");
            Persona p = new Persona(dni, ape, nom, fnac, email); 
            listaPersonas.Add(p);   
            elccPers = ingresarInt("Ingrese que quiere hacer");
        }else if(elccPers == 2){
            Console.WriteLine("Estadisticas del censo:");
            Console.WriteLine("La cantidad de personas: "+listaPersonas.Count);
            foreach (Persona p in listaPersonas){
                if(p.PuedeVotar() == true){
                    votantes++;
                }
            }
            Console.WriteLine("La cantidad de personas habilitadas para votar son: "+votantes);
            foreach(Persona p in listaPersonas){
                edadTotal += p.ObtenerEdad();
            }
            edadPromedio = edadTotal/listaPersonas.Count;
            Console.WriteLine("Promedio de edad: "+edadPromedio);
             elccPers = ingresarInt("Ingrese que quiere hacer");
        }else if(elccPers == 3){
            int BuscDni = ingresarInt("Ingrese el dni de la persona a buscar");
            bool tiene = false;
            foreach(Persona per in listaPersonas){
                if(per.Dni == BuscDni){
                 Console.WriteLine(per);
                 tiene = true;
                }
            }
            if(tiene == false){
                Console.WriteLine("No se encuentra el dni");
            }
            elccPers = ingresarInt("Ingrese que quiere hacer");
        }else if(elccPers == 4)
        {   
            string mail = "";
            int BuscDni = ingresarInt("Ingrese el dni de la persona a buscar");
            bool tiene = false;
            foreach(Persona per in listaPersonas){
                if(per.Dni == BuscDni){
                 Console.WriteLine(per);
                 tiene = true;
                 mail = ingresarString("Ingrese su nuevo Mail");
                 per.Email = mail;
                }
            }
            if(tiene == false){
                Console.WriteLine("No se encuentra el dni");
            }
        }
       }
    }
    static void menu(){
        Console.WriteLine("1-Cargar Nueva Persona "+Environment.NewLine+ "2-Obtener Estadísticas del Censo"+Environment.NewLine+"3-Buscar Persona"+Environment.NewLine+"4-Modificar Mail de una Persona."+Environment.NewLine+"Salir");      
    }

    static int ingresarInt(string msj){
        Console.WriteLine(msj);
        int n = int.Parse(Console.ReadLine());
        return n;
    }
    static string ingresarString(string msj){
        Console.WriteLine(msj);
        string n = Console.ReadLine();
        return n;
    }
    
    static DateTime ingresarDateTime(string msj){
        Console.WriteLine(msj);
        DateTime n = DateTime.Parse(Console.ReadLine());
        return n;
    }
}
