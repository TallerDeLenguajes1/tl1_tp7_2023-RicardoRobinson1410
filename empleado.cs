
public enum cargos
    {
        Auxiliar=1,
        Administrativo=2,
        Ingeniero=3,
        Especialista=4,
        Investigador=5
    }
public class Empleado
{
    public string? Nombre;
    public string? Apellido;
    public DateTime fechaNac;
    public char EstadoCivil;
    public char Genero;
    public DateTime fechaIngreso;
    public double SueldoBasico;
    public cargos CargoqueOcupa;
    public int antiguedad;
    public int edad;
    public int edadRecibirse;
    public int CalcularAntiguedad(DateTime fechaIngreso){
        DateTime fechahoy=DateTime.Now.Date;
        int aniohoy=fechahoy.Year;
        int anioIngreso=fechaIngreso.Year;
        int resultado=aniohoy-anioIngreso;
        return(resultado);
    }

    public int CalcularEdad(DateTime fechaNac){
        DateTime fechahoy=DateTime.Now.Date;
        int aniohoy=fechahoy.Year;
        int anioNac=fechaNac.Year;
        int resultado=aniohoy-anioNac;
        return(resultado);
    }
    public int CantAniosJubilarse(DateTime edad, char genero){
        int anios=edad.Year;
        DateTime fechahoy=DateTime.Now.Date;
        int aniohoy=fechahoy.Year;
        int aniosedad=aniohoy-anios;
        if(genero=='F'){
            if(aniosedad>60){
                return 0;
            }else{
                int faltamujer=60-aniosedad;
                return(faltamujer);
            }
        }else{
            if(aniosedad>65){
                return 0;
            }else{
                int faltavaron=65-aniosedad;
                return(faltavaron);
            }
        }
    }
    public double CalcularSalario(double SueldoBasico, int edad, int antiguedad, cargos cargo, char ecivil){
        double adicional=0;
        if(antiguedad<=20){
            adicional+=(SueldoBasico*antiguedad/100);
        }else{
            adicional+=(SueldoBasico*20/100)+SueldoBasico*(antiguedad-20)*25/100;
        }
        if(cargo==cargos.Ingeniero){
            adicional+=adicional/2;
        }
        if(ecivil=='C'){
            adicional+=15000;
        }
        return(SueldoBasico+adicional);
        }

}