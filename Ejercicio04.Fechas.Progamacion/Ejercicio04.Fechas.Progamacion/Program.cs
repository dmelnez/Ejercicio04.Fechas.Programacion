using Microsoft.VisualBasic;

namespace Ejercicio04.Fechas.Programacion
{


    class Program
    {


        public static void Main(string[] args)
        {



            Console.WriteLine("FECHA DE NACIMIENTO");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());


             int a =   DateTime.Today.CompareTo(fechaNacimiento);



          
            if (fechaNacimiento.Day > DateTime.Today.Day)
            {


                if (fechaNacimiento.Month > DateTime.Today.Month)
                {

                   int anios = fechaNacimiento.Year - DateTime.Today.Year +1;
     



                    Console.WriteLine(anios);

                }



            }


            else
            {

                int anios = fechaNacimiento.Year - DateTime.Today.Year;
                Console.WriteLine(anios);

            }






            /**
            if (a > 0) { 
            
            
            int edad = DateTime.Today.Year - fechaNacimiento.Year -1;
            Console.WriteLine("EDAD: " + edad);


            }

            else if (a == 0) {


                int edad = DateTime.Today.Year - fechaNacimiento.Year ;

                Console.WriteLine("EDAD: " + edad);

            }

            else
            {
                int edad = DateTime.Today.Year - fechaNacimiento.Year + 1;
                Console.WriteLine("EDAD: " + edad);



            }
            **/



        }


    }

}
