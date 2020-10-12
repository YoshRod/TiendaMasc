using System;
namespace TiendaMas
{
  public class CUsuario
  {
    public int Rol { get; set; }
    private bool activo = false;
    public bool Activo { get => activo; set => activo = value; }
    private int pass = 123;
    private string us = "adm";

    public CUsuario(int rol)
    {
      if (rol == 1) AccesoUsuario();
      else
      {
        this.Rol = 2;
        this.Activo = true;
      }
    }

    private void AccesoUsuario()
    {
      Console.Write("Usuario: ");
      string usuario = Console.ReadLine();
      usuario = usuario.ToLower();
      Console.Write("Contraseña: ");
      int contra = CTool.EvaluaNumeroInt();
      if (usuario == us && contra == pass)
      {
        Activo = true;
        Rol = 1;
      }
    }
  }
}