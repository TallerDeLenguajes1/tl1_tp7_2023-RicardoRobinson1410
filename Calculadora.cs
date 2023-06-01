public class Calculadora{
    private double dato=0;
    public double Dato { get => dato; set => dato = value; }

    public void Sumar(double termino){
        Dato+=termino;
    }
    public void Restar(double termino){
        Dato-=termino;
    }

    public void Multiplicar(double termino){
        Dato*=termino;
    }
    public void Dividir(double termino){
        Dato/=termino;
    }

    public void Limpiar(){
        Dato=0;
    }
    public double resultado{get=>dato;}
}