﻿namespace Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Pumping gas in the vehicle");
        }
    }
}
