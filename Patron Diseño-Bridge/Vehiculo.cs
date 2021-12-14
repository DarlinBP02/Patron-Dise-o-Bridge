using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Diseño_Bridge
{
    // Abstracción
    public abstract class Vehiculo
    {
        private IMotor motor;

        public Vehiculo(IMotor motor)
        {
            this.motor = motor;
        }

        // Encapsulamos la funcionalidad de la interfaz IMotor
        public void Acelerar(double combustible)
        {
            motor.InyectarCombustible(combustible);
            motor.ConsumirCombustible();
        }

        public void Frenar()
        {
            Console.WriteLine("El vehículo está frenando.");
        }

        // Método abstracto
        public abstract void MostrarCaracteristicas();
    }
}
