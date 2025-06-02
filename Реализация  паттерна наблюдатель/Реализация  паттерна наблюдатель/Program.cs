using System;

namespace TemperatureProgram
{
    public delegate void Thermometer(int C);

    class Temperature
    {
        public event Thermometer OnTemperature;

        public void Launch(int C)
        {
            Console.WriteLine("Gave degrees");

            OnTemperature?.Invoke(C);
        }
    }

    class AirConditioner
    {
        public void RunAirConditioner(int C)
        {
            Console.WriteLine("Set the temperature to decrease");
        }
    }

    class WarningSystem : AirConditioner
    {
        public void RunWarningSystem(int C)
        {
            for (int i = 0; i < 10; i++)
            {
                C += 10;

                if (C <= 50)
                {
                    Console.WriteLine("\r\nWarned the system about low temperature");
                }
                else
                {
                    Console.WriteLine("Warned the system about high temperature");
                    RunAirConditioner(C);
                }
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            AirConditioner airConditioner = new AirConditioner();
            WarningSystem warningSystem = new WarningSystem();

            temperature.OnTemperature += airConditioner.RunAirConditioner;
            temperature.OnTemperature += warningSystem.RunWarningSystem;



            temperature.Launch(0);



        }
    }
}
