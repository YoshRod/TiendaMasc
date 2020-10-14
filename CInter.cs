using System;
namespace TiendaMas
{
  public abstract class CInter
  {
    public static CLista listaPerros = new CLista();
    public static CLista listaGatos = new CLista();
    public static CLista listaAves = new CLista();

    public static void MenuInicial()
    {

      bool salir = false;
      CUsuario usuario;

      while (salir != true)
      {

        Console.WriteLine("=====================");
        Console.WriteLine("Tienda de Mascotas");
        Console.WriteLine("1.- Administrador");
        Console.WriteLine("2.- Usuario");
        Console.WriteLine("3.- Salir");
        int opcion = CTool.EvaluaNumeroInt();
        if (opcion > 0 && opcion < 4)
        {
          if (opcion != 3)
          {
            //creamos el tipo de usuario
            usuario = new CUsuario(opcion);
            if (usuario.Activo != false)
            {
              MenuUsuarios(usuario);
            }
          }
          else
          {
            System.Console.WriteLine("Saliendo de la tienda . . . .");
            salir = true;
          }
        }

        Console.Clear();
      }

    }

    private static void MenuUsuarios(CUsuario usuario)
    {
      if (usuario.Activo == true)
      {
        switch (usuario.Rol)
        {
          case 1:
            Console.WriteLine("==================================");
            Console.WriteLine("Administrador");
            Console.WriteLine("==================================");
            //menu para el admin
            MenuAdm();
            break;
          case 2:
            //menu para el usuariuo comun
            break;

        }
      }
    }

    private static void MenuAdm()
    {
      bool salir = false;
      int opcion = 0;
      while (salir == false)
      {
        Console.WriteLine("1- Agregar Mascota");
        Console.WriteLine("2- Buscar Mascota");
        Console.WriteLine("3- Editar Mascota");
        Console.WriteLine("4- Eliminar Mascota");
        Console.WriteLine("5- Salir");
        opcion = CTool.EvaluaNumeroInt();
        if (opcion < 6 && opcion > 0)
        {
          switch (opcion)
          {
            case 1:
              Console.WriteLine("==================================");
              Console.WriteLine("Administrador - Agregar Mascota");
              Console.WriteLine("==================================");

              CAnimal mascota = CreaMascota();
              if (mascota != null)
              {


                switch (mascota.Tipo)
                {
                  case 1:
                    listaPerros.Adicionar(mascota);
                    Console.WriteLine($"Mascota agregada a la lista perro");
                    break;
                  case 2:
                    listaGatos.Adicionar(mascota);
                    Console.WriteLine($"Mascota agregada a la lista Gato");
                    break;
                  case 3:
                    listaAves.Adicionar(mascota);
                    Console.WriteLine($"Mascota agregada a la Ave");
                    break;
                }
                Console.ReadKey();
              }
              else { Console.WriteLine("Ningun registro agregado"); }
              break;
            case 2:
              Console.WriteLine("==================================");
              Console.WriteLine("Administrador - Buscar Mascota");
              Console.WriteLine("==================================");

              int tipo;
              do
              {
                tipo = TipoMascota();
              } while (tipo < 0 && tipo > 5);
              if (tipo != 4)
              {
                switch (tipo)
                {
                  case 1:
                    if (listaPerros.EstaVacia() != true)
                    {
                      Console.WriteLine("Id a buscar");
                      int id=CTool.EvaluaNumeroInt();
                      CAnimal encontrado=listaPerros.MuestraAnimal(id);
                      if(encontrado!=null)encontrado.MostarDatos();
                      else Console.WriteLine("No se encontro coincidencia");
                      Console.ReadKey();
                    }
                    else Console.WriteLine("Aun no hay registros");
                    break;
                  case 2:
                    if (listaGatos.EstaVacia() != true)
                    {
                      Console.WriteLine("Id a buscar");
                      int id=CTool.EvaluaNumeroInt();
                      CAnimal encontrado=listaGatos.MuestraAnimal(id);
                      if(encontrado!=null)encontrado.MostarDatos();
                      else Console.WriteLine("No se encontro coincidencia");
                      Console.ReadKey();
                    }
                    else Console.WriteLine("Aun no hay registros");
                    break;
                  case 3:
                    if (listaAves.EstaVacia() != true)
                    {
                      Console.WriteLine("Id a buscar");
                      int id=CTool.EvaluaNumeroInt();
                      CAnimal encontrado=listaAves.MuestraAnimal(id);
                      if(encontrado!=null)encontrado.MostarDatos();
                      else Console.WriteLine("No se encontro coincidencia");
                      Console.ReadKey();
                    }
                    else Console.WriteLine("Aun no hay registros");
                    break;
                }
              }


              break;
            case 3:
            Console.WriteLine("==================================");
              Console.WriteLine("Administrador - Editar Mascota");
              Console.WriteLine("==================================");
              break;
            case 4:
              Console.WriteLine("4- Eliminar Mascota");
              break;
            case 5:
              Console.WriteLine("5- Salir");
              salir = true;

              break;
          }
        }
      }

    }

    public static int TipoMascota(){
      int tipo;
      Console.WriteLine("Tipo de mascota a buscar");
                Console.WriteLine("1- Perro 2-Gato 3-Ave (4-Salir)");
                tipo = CTool.EvaluaNumeroInt();
                return tipo;
    }

    private static CAnimal CreaMascota()
    {
      CAnimal mascota = new CAnimal();

      //Pedimos los datos para la creacion de la mascota
      int tipo;
      do
      {
        tipo=TipoMascota();
      } while (tipo < 5 && tipo > 0);
      
      //salimos en caso de 4
      if (tipo == 4) return mascota = null;

      switch (tipo)
      {
        case 1:
          mascota = new CPerro();
          break;
        case 2:
          mascota = new CGato();
          break;
        case 3:
          mascota = new CAve();
          break;

      }


      //creamos la mascota con los datos
      mascota.ObtenerDatos();


      //retornamos la mascota
      return mascota;
    }

  }
}