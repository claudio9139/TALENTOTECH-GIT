using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyThirdLibrary
{
    public class MyServicioTecnico
    {
        //Carga de atributos de Clase
        #region ATTRIB

        private string nombreCliente;//no se puede incializar aca
        private string apellidoCliente;//no se puede incializar aca
        private string direccionCLiente;//no se puede incializar aca
        private string emailCliente;//no se puede incializar aca
        private string telefonoCliente;//no se puede incializar aca
        private string tipoEquipo;//no se puede incializar aca
        private string marcaEquipo;//no se puede incializar aca
        private string modeloEquipo;//no se puede incializar aca
        private int numeroParte;//no se puede incializar aca
        private int potencia;//no se puede incializar aca
        private List <string> modeloUps;// Creo una lista con modelos especificos de UPS 
        public static string nombreEmpresa;
        public static string direccionEmpresa;
        public static int contadorIteraciones;
        public static int contadorIteracionesUno;
        public static int contadorIteracionesDos;
        public static int contadorIteracionesTres;
        #endregion ATTRIB

        #region CONSTRUCTOR ESTATICO

        static MyServicioTecnico()

        {
            nombreEmpresa = "VEOLIA SERVICIOS Y GESTION ENERGIA S.A";
            direccionEmpresa = "TRONADOR 4890 CABA";
            contadorIteraciones = 0;
            contadorIteracionesUno = 0;
            contadorIteracionesDos = 0;
            contadorIteracionesTres = 0;
        }



        #endregion CONSTRUCTOR ESTATICO






        #region CONSTRUCTOR INSTANCIAS 



        //CONSTRUCTOR POR DEFECTO  
        public MyServicioTecnico()

        {

            contadorIteraciones++;
            // MyServicioTecnico.nombreEmpresa;
            //MyServicioTecnico.direccionEmpresa;
            //Console.WriteLine($"\n\n IMPRESO POR EL     por el Constructor  de instancias sin parametros()  {contadorIteraciones} ");
        }


        //CONSTRUCTOR CON UN PARAMETRO
        public MyServicioTecnico(string nombreCliente1) : this()

        {

            contadorIteracionesUno++;
            this.nombreCliente = nombreCliente1;
            //  this.apellidoCliente = "Sin Apellido";
            // MyServicioTecnico.nombreEmpresa;
            //MyServicioTecnico.direccionEmpresa;
            //Console.WriteLine($"\n\n IMPRESO POR EL     por el Constructor  de instancias con un  parametro   {this.nombreCliente}  iteracion  {contadorIteracionesUno}");
        }



        //CONSTRUCTOR CON DOS PARAMETROS 
        public MyServicioTecnico(string apellidoCliente, string email) : this("A") 

        {

            contadorIteracionesDos++;
            this.emailCliente = email;
            this.apellidoCliente = apellidoCliente;
            // MyServicioTecnico.nombreEmpresa;
            //MyServicioTecnico.direccionEmpresa;
            // Console.WriteLine($" \n\nIMPRESO POR EL     por el Constructor  de instancias con dos  parametros     {this.nombreCliente} {this.apellidoCliente}  iteracion: {contadorIteracionesDos}  ");
        }



        //CONSTRUCTOR CON TRS PARAMETROS
        public MyServicioTecnico(string marcaEquipo, string modeloEquipo, string direccion) :this("B","C")

        {

            contadorIteracionesTres++;
            this.marcaEquipo = marcaEquipo;
            this.modeloEquipo = modeloEquipo;
            this.direccionCLiente = direccion;
            // MyServicioTecnico.nombreEmpresa;
            //MyServicioTecnico.direccionEmpresa;
            //Console.WriteLine($" \n\nIMPRESO POR EL     por el Constructor  de instancias con tres  parametros     {this.nombreCliente} {this.apellidoCliente} {this.direccionCLiente}   iteracion: {contadorIteracionesTres}  ");
        }






        #endregion CONSTRUCTOR INSTANCIAS

        #region Getters
        /*
        private string nombreCliente = string.Empty;
        private string apellidoCliente = string.Empty;
        private string direccionCLiente = string.Empty;
        private string emailCliente = string.Empty;
        private string telefonoCliente = string.Empty;
        private string tipoEquipo = string.Empty;
        private string marcaEquipo = string.Empty;
        private string modeloEquipo = string.Empty;
        private int numeroParte = 0;
        private int potencia = 0;
        public static string nombreEmpresa;
        public static string direccionEmpresa;
        public static int contadorIteraciones;
        public static int contadorIteracionesUno;
        public static int contadorIteracionesDos;
        public static int contadorIteracionesTres;

        */

        //********************************************************************************************
        /*


        public string GetNombreCliente()
        {
         return this.nombreCliente;
        }

        public string GetApellidoCliente()
        {
         return this.apellidoCliente;
        }

        public string GetDireccionCliente()
        {
            return this.direccionCLiente;
        }

        public string GetEmailCliente()
        {
        return this.emailCliente;
        }


        public string TelefonoCliente()
        {
        return this.telefonoCliente;
        }


        public string TipoEquipo()
        {
         return this.tipoEquipo;
        }


        public string MarcaEquipo()
        {
         return this.marcaEquipo;
        }

        public string ModeloEquipo()

        {

            return this.modeloEquipo;

        }


        public int NumeroParte()

        {

            return this.numeroParte;

        }

        public int Potencia()

        {

            return this.potencia;

        }




        */

        //*****************************************************************************************************

        #endregion Getters




        #region Setters

        /*
        private string nombreCliente = string.Empty;
        private string apellidoCliente = string.Empty;
        private string direccionCLiente = string.Empty;
        private string emailCliente = string.Empty;
        private string telefonoCliente = string.Empty;
        private string tipoEquipo = string.Empty;
        private string marcaEquipo = string.Empty;
        private string modeloEquipo = string.Empty;
        private int numeroParte = 0;
        private int potencia = 0;
        public static string nombreEmpresa;
        public static string direccionEmpresa;
        public static int contadorIteraciones;
        public static int contadorIteracionesUno;
        public static int contadorIteracionesDos;
        public static int contadorIteracionesTres;

        */

        //********************************************************************************************

        /*


        public void SetnombreCliente(string valor)
        {
            this.nombreCliente = valor;
        }

        public void SetApellidoCliente(string valor)
        {
            this.apellidoCliente = valor;
        }

        public void SetDireccionCliente(string valor)
        {
            this.direccionCLiente = valor;
        }

        public void SetEmailCliente(string valor)
        {
            this.emailCliente = valor;
        }

        public void SetTelefonoCliente(string valor)
        {
            this.telefonoCliente = valor;
        }

        public void SetTipoequipo(string valor)
        {
            this.tipoEquipo = valor;
        }

        public void SetMarcaequipo(string valor)
        {
            this.marcaEquipo = valor;
        }

        public void SetModeloequipo(string valor)
        {
            this.modeloEquipo = valor;
        }

        public void SetNumeroParte(int valor)
        {
            this.numeroParte = valor;
        }

        public void SetPotencia(int valor)
        {
            this.potencia = valor;
        }

        //*********************************************************************************************************
        */
        #endregion Setters



        #region properties


        public string NombreCliente

        {
            get
            {
                return this.nombreCliente;
            }

            set
            {

                if (value.Length > 0)
                {
                    this.nombreCliente = value;
                }

                else
                {
                    this.nombreCliente = "Sin Nombre";
                }




            }

        }


        public string ApellidoCliente
        {
            get
            {
                return this.apellidoCliente;
            }
            
            set
            {
                this.apellidoCliente = value;
            }
        }

        public string DireccionCliente
        {
            get { return this.direccionCLiente; }
            set { this.direccionCLiente = value; }
        }


        public string EmailCliente
        {
            get { return this.emailCliente; }
            set { this.emailCliente = value; }
        }

        public string TelefonoCliente
        {
            get { return this.telefonoCliente; }
            set { this.telefonoCliente = value; }
        }
        public string TipoEquipo
        {
            get { return this.tipoEquipo; }
            set { this.tipoEquipo = value; }
        }

        public string MarcaEquipo
        {
            get { return this.marcaEquipo; }
            set { this.marcaEquipo = value; }
        }

        public string ModeloEquipo
        {
            get { return this.modeloEquipo; }
            set { this.modeloEquipo = value; }
        }
        public int NumeroParte
        {
            get { return this.numeroParte; }
            set { this.numeroParte = value; }
        }

        public int Potencia
        {
            get
            {
                int retorno = 0;
               
                if (this.potencia > 0)
                {
                    retorno= this.potencia;
                }
                return retorno;
            }
            set
            {
                this.potencia = value;
            }
        }





        public double PromedioRandom
        {
            get
            {
                double result;
                result=CalcularPromedio(this.potencia);
                return result;
            }

            set 
            {
                double result;
                result=CalcularPromedio((int)value);
                this.potencia = (int)result;
            }
        }









        #endregion properties











        #region METHODS



        public string MostrarInfo()

        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE  :{this.NombreCliente}   APELLIDO  :{this.ApellidoCliente} ");
            sb.AppendLine($"DIRECCION  :{this.DireccionCliente}   EMAIL  :{this.EmailCliente} ");
            //sb.AppendLine($"DIRECCION       {this.direccionCLiente}        EMAIL   {this.emailCliente}      ");




            return sb.ToString();
        }

        //public static double CalcularPrecioReparacion(double precioReparacion, double descuento)

        public static double CalcularPrecioReparacion(double precioReparacion, double descuento)
        {
            double precioFinal = 0;

            precioFinal = precioReparacion - (precioReparacion * descuento / 100);
            return precioFinal;
        }


        public double CalcularPrecioEquipo(MyServicioTecnico instancia, double recargo)

        {
            double precioFinal = 0;

            precioFinal = instancia.potencia + (instancia.potencia * recargo / 100);
            return precioFinal;
        }



        public double DevolverResultado(MyServicioTecnico instancia1)
        {
            double potenciaActualInstancia = this.potencia;
            double potenciaPorParametroinstancia1 = instancia1.potencia;



            return (potenciaActualInstancia * potenciaPorParametroinstancia1);
        }




        public double CalcularPromedio(int number=100)
        {
            Random random = new Random();
            int suma = 0;
            int cantidadNumeros = 10000000;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                int numeroAleatorio = random.Next(1, number); // Genera un número aleatorio entre 1 y 100
                suma += numeroAleatorio;
            }
            double promedio = (double)suma / cantidadNumeros;
            return promedio;
        }





        #endregion METHODS











    }//End MyServicioTecnico
}//End Namespace
