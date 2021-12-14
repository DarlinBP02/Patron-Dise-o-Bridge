using System;

namespace Patron_Diseño_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor motorDiesel = new Diesel();
            Vehiculo berlina = new Berlina(motorDiesel, 4);
            IMotor motorgasolina = new Gasolina();
            Vehiculo monovolumen = new Monovolumen(motorgasolina, 2);

            berlina.MostrarCaracteristicas();
            berlina.Acelerar(2.4d);

            monovolumen.MostrarCaracteristicas();
            monovolumen.Acelerar(4.2d);


        }
    }
}
