namespace TiendaMas
{
    public class CNodo
    {
        public int Id { get; set; }

        public CAnimal Mascota { get; set; }//almacenamos un objeto de tipo mascota
        internal CNodo siguiente=null;
        public CNodo Siguiente{get=>siguiente; set=>siguiente=value;}
    }
}
