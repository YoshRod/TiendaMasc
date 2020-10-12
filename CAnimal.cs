using System;

namespace TiendaMas
{
  public class CAnimal
  {

    public int Id { get; set; }
    public int Tipo { get; set; } //1-Perro, 2-Gato, 3-Ave etc.

    public string Raza { get; set; }

    public int Tamaño { get; set; } //1-pequeño, 2-mediano, 3-grande

    public double PrecioCompra { get; set; }

    public double PrecioVenta { get; set; }

    private double ganancia = .16;

    /// <summary>
    /// Pide los datos con los que se crea la mascota.
    /// </summary>
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
      System.Console.Write($"{tipo}: raza? ");
      string raza = Console.ReadLine();

      do
      {
        System.Console.WriteLine($"{tipo} {raza}: tamaño? ");
        Console.WriteLine("1-Pequeño 2-Mediano 3-Grande");
        tamaño = CTool.EvaluaNumeroInt();
        if (tamaño < 4 && tamaño > 0) conti1 = true;
      }
      while (conti1 != true);

      string tama = "";
      switch (tamaño)
      {
        case 1:
          tama = "Pequeño";
          break;
        case 2:
          tama = "Mediano";
          break;
        case 3:
          tama = "Grande";
          break;
      }
      System.Console.WriteLine($"{tipo} {raza} {tama} ");
      Console.Write("Precio compra: $");
      double precioCom = CTool.EvaluaNumeroDou();

      Raza = raza;
      Tamaño = tamaño;
      PrecioCompra = precioCom;
      CalculaPrecioVenta();
      System.Console.WriteLine($"Precio Venta: ${PrecioVenta}");
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
