using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Diseño_Bridge
{
    // RefinamientoAbstraccionA
    public class Berlina : Vehiculo
    {
        // Atributo propio
        private int capacidadMaletero;

        // La implementacion de los vehículos se desarrolla de forma independiente
        public Berlina(IMotor motor, int capacidadMaletero) : base(motor)
        {
            this.capacidadMaletero = capacidadMaletero;
        }

        // Implementación del método abstracto
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Berlina con un maletero con una capacidad de " +
                capacidadMaletero + " litros.");
        }
    }
}

