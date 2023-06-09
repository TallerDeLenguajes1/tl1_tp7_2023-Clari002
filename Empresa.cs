using System;
namespace Empresa;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    //atributos
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public char EstadoCivil {get; set;}
    public char Genero {get; set;}
    public DateTime FechaIngreso {get; set;}
    public double SueldoBasico{get; set;}
    public Cargos Cargo{get; set;}

    //propiedad para calcular la antiguedad
    public int Antiguedad
    {
        get
        {
            TimeSpan antiguedad = DateTime.Now - FechaIngreso;
            return (int)antiguedad.TotalDays/365;
        }
    }
    //propiedad para calcular a edad
    public int Edad
    {
        get
        {
            TimeSpan edad = DateTime.Now - FechaNacimiento;
            return (int)edad.TotalDays/365;
        }
    }
    //propiedad para calcular la cantidad de años faltantes para jubilarse
    public int AniosParaJubilarse
    {
        get
        {
            int edadJubilacion = (Genero == 'M')? 65:60;
            return edadJubilacion - Edad;
        }
    }

    public double Salario
    {
        get
        {
            double adicional = CalcularAdicional();//llamo al metodo
            return SueldoBasico + adicional;
        }
    }

    //metodo para calcular el adicional del salrio
    private double CalcularAdicional()
    {
        int antiguedad = Antiguedad;
        double adicional = 0;

        if (antiguedad <= 20)
        {
            adicional = SueldoBasico * (0.01 * antiguedad);
        }else{
            adicional = SueldoBasico * 0.25;
        }

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        if (EstadoCivil == 'C')
        {
            adicional += 15000;
        }

        return adicional;
    }

}