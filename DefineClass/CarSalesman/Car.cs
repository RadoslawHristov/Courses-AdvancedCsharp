using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
        : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string color)
         : this(model, engine, weight)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine,  string color)
        :this(model,engine)
        {
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"{Model}:");
            sv.AppendLine($"  {Engine.Model}:");
            sv.AppendLine($"    Power: {Engine.Power}");
            if (Engine.Displacement != 0)
            {
                sv.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            else
            {
                sv.AppendLine("    Displacement: n/a");
            }
            if (Engine.Efficiency != null)
            {
                sv.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }
            else
            {
                sv.AppendLine("    Efficiency: n/a");
            }

            if (Weight != 0)
            {
                sv.AppendLine($"  Weight: {Weight}");
            }
            else
            {
                sv.AppendLine("  Weight: n/a");
            }
            if (Color != null)
            {
                sv.AppendLine($"  Color: {Color}");
            }
            else
            {
                sv.AppendLine("  Color: n/a");
            }

            return sv.ToString().TrimEnd();
        }
    }
}
