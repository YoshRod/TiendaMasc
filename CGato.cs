using System;

namespace TiendaMas
{
  public class CGato : CAnimal
  {
    public static int id;

    public CGato()
    {
      Tipo = 2;
      IncrementaId();
    }

    private void IncrementaId()
    {
      id = id + 1;
      Id = id;
    }

    public override void MostarDatos()
    {
      string tipo = "";
      string tamaño = "";

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
      Console.WriteLine($"Precio ${PrecioVenta}");
    }
  }
}
