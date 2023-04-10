public class Persona
{
    public int Dni{get; set;}
    public string Apellido{get; set;}
    public string Nombre{get; set;}
    public DateTime FechaNacimiento{get; set;}
    public string Email{get; set;}

    public Persona(int dni,string ape, string nombre, DateTime fnac, string email){
        Dni = dni;
        Apellido = ape;
        Nombre = nombre;
        FechaNacimiento = fnac;
        Email = email;
    }

    public bool PuedeVotar(){
        bool votar = false;
        int años = ObtenerEdad();
        if(años>17){
            votar = true;
        }
        return votar;
    }

    public int ObtenerEdad(){
        int años = 0;
        DateTime Hoy = DateTime.Today;
        int añoHoy = Hoy.Year;
        int año = FechaNacimiento.Year;
        años = añoHoy-año;
        return años;
    }
}
 