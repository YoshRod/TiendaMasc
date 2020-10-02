using System;

namespace TiendaMas
{
    public class CAnimal
    {
        public int Tipo { get; set; } //1-Perro, 2-Gato, 3-Ave etc.

        public string Raza { get; set; }

        public int Tamaño { get; set; } //1-pequeño, 2-mediano, 3-grande

        public double PrecioCompra { get; set; }

        public double PrecioVenta { get; set; }

        private double ganancia = .16;

        public void ObtenerDatos()
        {
            bool conti1 = false;
            string tipo = "";
            int tamaño;
            switch (Tipo)
            {
                case 1:
                    tipo = "Perro";
                    break;
                case 2:
                    tipo = "Gato";
                    break;
                case 3:
                    tipo = "Ave";
                    break;
            }
            System.Console.WriteLine($"Que raza es el {tipo} ?");
            string raza = Console.ReadLine();

            do
            {
                Console.WriteLine("Tamaño: 1-Pequeño 2-Mediano 3-Grande");
                tamaño = CTool.EvaluaNumeroInt();
                if (tamaño < 4 && tamaño > 0) conti1 = true;
            }
            while (conti1 != true);

            Console.WriteLine("Precio compra");
            double precioCom = CTool.EvaluaNumeroDou();

            Raza = raza;
            Tamaño = tamaño;
            PrecioCompra = precioCom;
            CalculaPrecioVenta();
        }

        public virtual void MostarDatos()
        {
            string tamaño = "";
            string tipo = "";
            switch (Tipo)
            {
                case 1:
                    tipo = "Perro";
                    break;
                case 2:
                    tipo = "Gato";
                    break;
                case 3:
                    tipo = "Ave";
                    break;
            }
            Console.WriteLine($"{tipo} Raza: {Raza}");

            switch (Tamaño)
            {
                case 1:
                    tamaño = "Pequeño";
                    break;
                case 2:
                    tamaño = "Mediano";
                    break;
                case 3:
                    tamaño = "Grande";
                    break;
            }
            Console.WriteLine($"Tamaño: {tamaño}");
            Console.WriteLine($"Precio compra ${PrecioCompra}");
            Console.WriteLine($"Precio venta ${PrecioVenta}");
        }

        private void CalculaPrecioVenta()
        {
            PrecioVenta = (PrecioCompra * ganancia) + PrecioCompra;
        }
    }
}
