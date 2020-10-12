using System;

namespace TiendaMas
{
  public class CLista
  {
    private CNodo trabajo;

    private CNodo trabajo2;

    private CNodo ancla;

    private int id; //Nos servira ara saber el numero de registros ingresados a la lista.

    public CLista()
    {
      ancla = new CNodo();
      ancla.Siguiente = null;
    }

    /// <summary>
    /// Muestra el id de todos los registros atuales.
    /// </summary>
    public void Transversa()
    {
      trabajo = ancla;

      System.Console.Write("[Ancla]");
      while (trabajo.Siguiente != null)
      {
        trabajo = trabajo.Siguiente;
        Console.Write($" -> [Id:{trabajo.Id}]");
      }
      System.Console.WriteLine("");
    }

     
    /// <summary>
    /// Adiciona un nodo al final de la lista
    /// </summary>
    /// <param name="mascota">Animal que contendra el nodo a adicionar.</param>
    public void Adicionar(CAnimal mascota)
    {
      trabajo = ancla;

      while (trabajo.Siguiente != null)
      {
        trabajo = trabajo.Siguiente;
      }

      CNodo nuevo = new CNodo();
      nuevo.Id = IncrementaId();
      trabajo.Siguiente = nuevo;
    }

    /// <summary>
    /// Permite incrementar el Id.
    /// </summary>
    /// <returns>Retorna el id incrementado en 1</returns>
    private int IncrementaId()
    {
      return id = id + 1;
    }

    /// <summary>
    /// Vacia el contenido de la lista( posterior no se puede recuperar la informacion).
    /// </summary>
    public void VaciarLista()
    {
      ancla.siguiente = null;
    }

    /// <summary>
    /// Notifica si la lista esta vacia (True) o no (false)
    /// </summary>
    /// <returns>True en caso de que este vacia</returns>
    public bool EstaVacia()
    {
      bool vacia = true;
      if (ancla.Siguiente != null) vacia = false;
      return vacia;
    }

    /// <summary>
    /// Busca el nodo que contiene el id ingresado.
    /// </summary>
    /// <param name="id">Id a buscar e la lista.</param>
    /// <returns>Retorna el nodo que contiene el id ingresado.</returns>
    public CNodo Buscar(int id)
    {
      trabajo = ancla;
      while (trabajo.Siguiente != null)
      {
        trabajo = trabajo.Siguiente;
        if (trabajo.Id == id) return trabajo;
      }
      return null;
    }

    /// <summary>
    /// Busca el indice en el cual se encuantre actualmente el id ingresado, de no encontrarse retorna -1.
    /// </summary>
    /// <param name="id">Id del cual se requiere su indice</param>
    /// <returns></returns>
    public int BuscaIndice(int idBuscar)
    {
      trabajo = ancla;
      int indice = -1;

      while (trabajo.Siguiente != null)
      {
        trabajo = trabajo.Siguiente;
        indice++;
        Console.WriteLine("id ->" + trabajo.Id + " indice->" + indice);
        if (trabajo.Id == idBuscar) return indice;
      }
      return -1;
    }

    /// <summary>
    /// Busca y retorna el nodo anterior al nodo que contiene el id ingresado, el ultimo de no encontrarlo.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public CNodo BuscarAnterior(int id)
    {
      trabajo2 = ancla;
      while (trabajo2.Siguiente != null && trabajo2.Siguiente.Id != id)
      {
        trabajo2 = trabajo2.siguiente;
      }

      return trabajo2;
    }

    /// <summary>
    /// Borra un nodo de la lista encaso de existir el dato ingresado.
    /// </summary>
    /// <param name="id">Dato del nodo a eliminar.</param>
    public void Borrar(int id)
    {
      trabajo = ancla;
      CNodo encontrado = Buscar(id);
      if (encontrado != null)
      {
        CNodo anterior = BuscarAnterior(id);

        anterior.Siguiente = encontrado.Siguiente;
        encontrado.Siguiente = null;
      }
    }

    /// <summary>
    /// Inserta un nodo delante del nodo que contiene el dato ingresado ("Afecta el orden por id de la lista").
    /// </summary>
    /// <param name="posicion"></param>
    public void Insertar(int posicion, CAnimal mascota)
    {
      CNodo encontrado = Buscar(posicion);
      if (encontrado != null)
      {
        CNodo nuevo = new CNodo();
        nuevo.Id = IncrementaId();
        nuevo.Mascota = mascota;
        nuevo.Siguiente = encontrado.Siguiente;
        encontrado.Siguiente = nuevo;
      }
    }

    /// <summary>
    /// Inserta un nodo al inicio de la lista (afecta el orden por id).
    /// </summary>
    public void InsertarInicio(CAnimal mascota)
    {
      trabajo = ancla;
      CNodo nuevo = new CNodo();
      nuevo.Id = IncrementaId();
      nuevo.Mascota = mascota;
      nuevo.Siguiente = trabajo.siguiente;
      trabajo.siguiente = nuevo;
    }

    /// <summary>
    /// Obtiene el nodo que contiene el indice ingresado.
    /// </summary>
    /// <param name="indice">Valor del indice a buscar.</param>
    /// <returns></returns>
    public CNodo ObtenerPorIndice(int indice)
    {
      if (indice > CantidadNododos()) return null;
      if (indice < 0) return null;

      trabajo = ancla;
      int indi = -1;
      while (trabajo != null)
      {
        trabajo = trabajo.Siguiente;
        indi++;
        if (indi == indice) return trabajo;
      }
      return trabajo;
    }

    public int CantidadNododos()
    {
      int cantidad = 0;
      trabajo2 = ancla;

      while (trabajo2 != null)
      {
        trabajo2 = trabajo2.Siguiente;
        cantidad++;
      }

      return cantidad;
    }

     //FIXME: Consulta que es esto.
        public int this[int indice]
        {
            get
            {
                trabajo = ObtenerPorIndice(indice);
                return trabajo.Id;
            }
            set
            {
                trabajo = ObtenerPorIndice(indice);
                if (trabajo != null)
                {
                    trabajo.Id = value;
                }
            }
        }

      //FIXME: No esta funcionando.
      public void MuestraAnimal(int id)
    {
      trabajo = ancla;

      while (trabajo.Siguiente != null)
      {
        trabajo = trabajo.Siguiente;
        if(id==trabajo.Id){
        Console.Write($" -> [Id:{trabajo.Id}]");
        CAnimal mas=trabajo.Mascota;
        System.Console.WriteLine(mas.Id);
        }
      }
      System.Console.WriteLine("");
    }

  }
}
