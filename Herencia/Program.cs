using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    //metodos o funciones de operacion
    //*los metodos que se ponen a continuación
    // tipo de acceso tipo de dato nombre
    class operacion
    {
        //declaración de variables que usa la clase
        //tipo de acceso    tipo de dato    nombre de dato
        protected int valor1;
        protected int valor2;
        protected int resultado;


        //atributos de la clase operacion
        //metodos o funcion de operacion
        /*los metodos que se ponen a continuación 
         * son lal funciones de obtener el valos
         * de la caja de texto y guardarlo en la 
         * memoria dentro de la
         * variable indicada*/
        //constructor de dato valor 1
        public int Valor1
        {
            get { return valor1; } //vamos por el valor de la caja de texto
            set { valor1 = value; }//lo guardamos en memoria
        }
        public int Valor2
        {
            get { return valor2; } //vamos por el valor de la caja de texto
            set { valor1 = value; }//lo guardamos en memoria
        }
        public int Resultado
        {
            get { return resultado; } //vamos por el valor de la caja de texto
            set { resultado = value; }//lo guardamos en memoria
        }
    }
    //creamos nuestra clase hijo que usará los
    //metodos de crear dato
    class Suma : operacion
    {
        //las clases hijas también pueden tener sus propios atributos y métodos 
        //pueden tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : operacion
    {
        //las clases hijas también pueden tener sus propios atributos y métodos 
        //pueden tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
        class Multiplicar : operacion
        {
            //las clases hijas también pueden tener sus propios atributos y métodos 
            //pueden tener variables de uso solamente para la clase hijo
            //declarar variables de esta clase
            //atributos de esta clase
            //metodos de clase
            public int operar(int v1, int v2)
            {
                valor1 = v1;
                valor2 = v2;
                return resultado = valor1 * valor2;
            }
        }
    }
    static class Program
    {
        /*calse principal o clase papá que guardará los métodos de lectura
        de valores y almacenando de valores en variables*/ 
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
