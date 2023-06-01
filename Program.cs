// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un termino");
double termino;
int elegir;
string? e;
string? x;
x=Console.ReadLine();
bool anda1=double.TryParse(x,out termino);
bool anda2;
Calculadora res=new Calculadora();
double num;
string? n;
bool anda3;
if(anda1){
    while(termino!=0){
        Console.WriteLine("1.Sumar");
        Console.WriteLine("2.Restar");
        Console.WriteLine("3.Multiplicar");
        Console.WriteLine("4.Dividir");
        Console.WriteLine("5.Limpiar");
        e=Console.ReadLine();
        anda2=int.TryParse(e,out elegir);
        if(anda2){
            Console.WriteLine("Ingrese el numero con el que desea operar");
            n=Console.ReadLine();
            anda3=double.TryParse(n, out num);
            if(anda3){
                switch (elegir)
                {
                    case 1:
                        res.Sumar(num);
                    break;
                    case 2:
                        res.Restar(num);
                    break;
                    case 3:
                        res.Multiplicar(num);
                    break;
                    case 4:
                        res.Dividir(num);
                    break;
                    case 5:
                        res.Limpiar();
                    break;
                }
            Console.WriteLine("RESULTADO:"+res.resultado);
            }
            
        }
    }
}
