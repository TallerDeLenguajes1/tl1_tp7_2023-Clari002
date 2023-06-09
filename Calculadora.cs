namespace EspacioCalculadora;

public class Calculadora
{
    private double valor;

//constructor
    public Calculadora()
    {
        valor = 0;
    }
//propiedad
    public double Resultado { get => valor;}

//metodos
    public void Suma(double sumando)
    {
        if (valor == 0)
        {
            valor = Resultado;
        }else{
        valor+= sumando;

        }
    }

    public void Restar(double restando)
    {
        if (valor == 0)
        {
            valor = restando;
        }else{
            valor-=restando;
        }
      
    }
    
    public void Multiplicar(double mult)
    {
        if (valor == 0)
        {
            valor = mult;
        }else{
        valor = valor * mult;

        }
    }

    public void Dividir(double divi)
    {
        if(valor == 0)
        {
            valor = divi;
        }else{
        valor = valor / divi;

        }
    }

    public void Limpiar()
    {
        valor = 0;
    }
}