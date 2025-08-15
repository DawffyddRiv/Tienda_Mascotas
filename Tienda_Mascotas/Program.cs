namespace Tienda_Mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            //Inserto datos
            //Animales
            Animales animal_1 = new Animales("A-01");//{NOMBRE_ANIMAL="Gato"} ó
            animal_1.NOMBRE_ANIMAL = "Perro";
            Animales animal_2 = new Animales("A-02") { NOMBRE_ANIMAL = "Gato" };
            Animales animal_3= new Animales("A-03") { NOMBRE_ANIMAL = "Pez" };
            //Empleados
            Empleados emple1 = new Empleados("E-01") { NOMBRE_EMPLEADO = "Fernanda" };
            Empleados emple2 = new Empleados("E-02") { NOMBRE_EMPLEADO = "Rodrigo" };
            //Productos
            Productos produ1 = new Productos("P-01") { NOMBRE_PRODUCTO = "Arena Scoope", PRECIO = 490,ID_ANIMAL="A-02" };
            Productos produ2 = new Productos("P-02") { NOMBRE_PRODUCTO = "Croquetas kirkland", PRECIO = 800, ID_ANIMAL = "A-02" };
            Productos produ3 = new Productos("P-03") { NOMBRE_PRODUCTO = "Croquetas Royal", PRECIO = 1200, ID_ANIMAL = "A-01" };
            Productos produ4 = new Productos("P-04") { NOMBRE_PRODUCTO = "Collar Perro", PRECIO = 120, ID_ANIMAL = "A-01" };
            Productos produ5 = new Productos("P-05") { NOMBRE_PRODUCTO = "Hojuelas Peces", PRECIO = 200, ID_ANIMAL = "A-03" };
            Productos produ6 = new Productos("P-06") { NOMBRE_PRODUCTO = "Acuario Peces", PRECIO = 1360, ID_ANIMAL = "A-03" };
            //Ventas
            Ventas vent1 = new Ventas("V-01", /*"P-05",*/ "E-01") { FECHAVENTA = "02/05/2024" };
            Ventas vent2 = new Ventas("V-02", /*"P-02",*/ "E-02") { FECHAVENTA = "12/05/2024" };
            Ventas vent3 = new Ventas("V-03", /*"P-04",*/ "E-01") { FECHAVENTA = "25/05/2024" };
            Ventas vent4 = new Ventas("V-04", /*"P-01",*/ "E-01") { FECHAVENTA = "07/05/2024" };
            Ventas vent5 = new Ventas("V-05", /*"P-02",*/ "E-01") { FECHAVENTA = "06/05/2024" };
            Ventas vent6 = new Ventas("V-06", /*"P-03",*/ "E-02") { FECHAVENTA = "09/05/2024" };
            Ventas vent7 = new Ventas("V-07", /*"P-06",*/ "E-02") { FECHAVENTA = "14/05/2024" };
            Ventas vent8 = new Ventas("V-08", /*"P-03",*/ "E-02") { FECHAVENTA = "17/05/2024" };
            Ventas vent9 = new Ventas("V-09", /*"P-02",*/ "E-02") { FECHAVENTA = "26/05/2024" };
            Ventas vent10 = new Ventas("V-10", /*"P-01",*/ "E-01") { FECHAVENTA = "29/05/2024" };
            //OrdenVenta
            ordenVenta ord1 = new ordenVenta("V-01", "P-05") { CANTIDADPRODUCTO = 2 };
            ordenVenta ord2 = new ordenVenta("V-01", "P-02") { CANTIDADPRODUCTO = 5 };
            ordenVenta ord3 = new ordenVenta("V-02", "P-04") { CANTIDADPRODUCTO = 4 };
            ordenVenta ord4 = new ordenVenta("V-02", "P-01") { CANTIDADPRODUCTO = 8 };
            ordenVenta ord5 = new ordenVenta("V-03", "P-02") { CANTIDADPRODUCTO = 3 };
            ordenVenta ord6 = new ordenVenta("V-03", "P-03") { CANTIDADPRODUCTO = 1 };
            ordenVenta ord7 = new ordenVenta("V-04", "P-06") { CANTIDADPRODUCTO = 9 };
            ordenVenta ord8 = new ordenVenta("V-04", "P-03") { CANTIDADPRODUCTO = 6 };
            ordenVenta ord9 = new ordenVenta("V-05", "P-01") { CANTIDADPRODUCTO = 7 };

            //Agrego objetos-datos a listas-tablas evitando agregar uno por uno listAnimales.add(animal_1); 
            //
            List<Animales> listAnimales = new List<Animales>() { animal_1, animal_2, animal_3 };
            List<Empleados> listEmpleados = new List<Empleados>() { emple1, emple2 };
            List<Productos> listProductos = new List<Productos>() { produ1, produ2, produ3, produ4, produ5, produ6 };
            List<Ventas> listVentas = new List<Ventas>() { vent1, vent2, vent3, vent4, vent5, vent6, vent7, vent8, vent8, vent9, vent10 };
            List<ordenVenta> listOrdenVenta = new List<ordenVenta> { ord1, ord2, ord3, ord4, ord5, ord6, ord7, ord8, ord9 };


            /*
            Console.WriteLine($"Clave de animal {animal_1.IDANIMAL} y su tipo es {animal_1.NOMBRE_ANIMAL}");
            
            
            Productos prod1 = new Productos("P-001") { NOMBRE_PRODUCTO = "Croquetas perro", PRECIO = 200, ID_ANIMAL = "A-001" };
            Console.WriteLine($"ID producto {prod1.ID_PRODUCTO} , Nombre: {prod1.NOMBRE_PRODUCTO} ,Precio: {prod1.PRECIO} ,ClaveAnimal: {prod1.ID_ANIMAL} ");
            */
           
            
        }

    }
    public class Animales
    {
        private string id_Animal;
        private string nombre_animal;

        public Animales(string id_Animal)
        {
            this.id_Animal = id_Animal;
        }

        public string IDANIMAL
        {
            get { return this.id_Animal; }
            /* set { this.id_Animal = value; }*/

        }
        public string NOMBRE_ANIMAL
        {
            get { return this.nombre_animal; }
            set { this.nombre_animal = value; }
        }
    }

    public class Empleados
    {
        private string idEmpleado;
        private string nombreEmpleado;
        public Empleados(string idempleado)
        {
            this.idEmpleado = idempleado;
        }

        public string ID_EMPLEADO
        {
            get { return this.idEmpleado; }
            /*set { this.idEmpleado = value; }*/
        }
        public string NOMBRE_EMPLEADO
        {
            get { return this.nombreEmpleado; }
            set { this.nombreEmpleado = value; }
        }

    }
    public class Productos
    {
        private string idProducto;
        private string nombreProducto;
        private double precio;
        private string id_Animal;

        public Productos(string idProducto)
        {
            this.idProducto = idProducto;
        }
        public string ID_PRODUCTO
        {
            get { return this.idProducto; }
        }
        public string NOMBRE_PRODUCTO
        {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value; }
        }
        public double PRECIO
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public string ID_ANIMAL
        {
            get { return this.id_Animal; }
            set { this.id_Animal = value; }
        }
    }
    public class Ventas
    {
        private string idVentas;
        //private string idProducto;
        private string idVendedor;
        private string fechaVenta;

        public Ventas(string idVenta, string idVenddor)
        {
            this.idVentas = idVenta;
            //this.idProducto = idProduct;
            this.idVendedor = idVenddor;
        }
        public string FECHAVENTA
        {
            get { return this.fechaVenta; }
            set { this.fechaVenta = value; }
        }

    }
    public class ordenVenta
    {
        private string idVenta;
        private string idProducto;
        private int cantidadProducto;
        public ordenVenta(string idVenta, string idProducto)
        {
            this.idVenta = idVenta;
            this.idProducto = idProducto;           
        }

        public int CANTIDADPRODUCTO
        {
            get { return this.cantidadProducto; }
            set { this.cantidadProducto = value; }
        }
    }


}

