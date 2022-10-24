namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de un objeto del tipo Ave
            Ave paloma;
            //Inicializacion con valores por defecto
            paloma = new Ave();
            //Luego de inicializar puedo hacer cosas con el 
            Console.WriteLine(paloma.EmitirSonido());
            //Inicializacion de un objeto microondas del tipo electrodomestico con parametros
            Electrodomestico microondas = new Electrodomestico(9999, "Microondas");
            Console.WriteLine($"Electrodomestico en oferta! {microondas.GetNombre()} " +
                $"por el modico valor de: {microondas.GetValor()}$!");
            //Inicializacion de una nueva persona sin ningun valor por defecto ni parametro
            Persona enrique = new Persona();
            //Utilizar un set para asignar edad
            enrique.SetEdad(31);
            //Utilizar un get para traer la edad
            Console.WriteLine(enrique.GetEdad());


        }
    }

    public class Ave
    {
        //Atributos/propiedades de aves
        //Acceso publico (A todas las clases)
        public bool pico;
        //Acceso privado, solo a esta clase
        private bool plumas;
        //Acceso protegido, solo a esta clase y a las heredadas
        protected string sonido;
        //Privado por defecto
        int alas;

        int patas;

        int hambre;

        int energia;

        //Metodos, acciones que pueden realizar las aves
        public string EmitirSonido()
        {
            return sonido;
        }

        public void Comer(int comida)
        {
            hambre -= comida;
        }

        private void Volar()
        {
            energia--;
        }
        //Metodo para la creacion de instancias de aves vacias (sin valores)
        public Ave()
        {
            //Valores por defecto
            pico = true;

            plumas = true;

            sonido = "Prrrrrr";

            alas = 2;

            patas = 2;

            hambre = 5;

            energia = 6;

        }
        //Metodo para la creacion de instancias de aves con parametro (Donde las aves se crean cono los datos que mando)
        public Ave(bool pico, bool plumas, string sonido, int alas, int patas, int hambre, int energia)
        {
            //Fijarse donde hace "scope", o bien, a quien hace referencia cada variable
            this.pico = pico;
            this.plumas = plumas;
            this.sonido = sonido;
            this.alas = alas;
            this.patas = patas;
            this.hambre = hambre;
            this.energia = energia;
        }
    }

    public class Persona
    {
        //Propiedades o atributos
        private int id;
        private int edad;
        private string nombre;
        //Constructores
        public Persona()
        {

        }
        //Getters y setters
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }



}