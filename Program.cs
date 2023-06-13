using System;

namespace Ejercicio8
{
    class Program
    {
        // static void Main(string[] args)
        // {
            // // Ejercicios 8
            
            // // En este caso, la idea va a ser armar una función que resuelva algo y luego armar un main
            // // que interactúe con una persona para pedir y mostrar datos pero que llame
            // // a esa función para resolver lo planteado. Vamos?

            // // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto
            // //  de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida
            // //   y muestre por pantalla el monto total a pagar. Usar la función.

            // float precioArticulo, cantidadVendida, montoTotal;

            // Console.WriteLine("Ingrese el Precio del Articulo: ");
            // precioArticulo = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la Cantidad vendida: ");
            // cantidadVendida = float.Parse(Console.ReadLine());

            // montoTotal = producto(precioArticulo, cantidadVendida);

            // Console.WriteLine("El monto total a pagar es de: $" + montoTotal);
        // }

        // static float producto(float a, float b){
            // r = a * b;
            // return r;
        // }


        //.....................................................................................................


        //static void Main(string[] args)
        //{
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero
            //  si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            // int num, numero, con = 0;

            // for (int x = 0; x < 20; x++)
            // {
                // Console.WriteLine("Ingrese un numero: ");
                // num = int.Parse(Console.ReadLine());
                // numero = par(num);
                // if (numero == 1)
                // {
                    // con++;
                // }
            // }
            // Console.WriteLine("la cantidad de numeros pares es: " + con);
           
            //MODO DE GUIA:
            // Console.WriteLine("Ingrese un numero: ");
            // num = int.Parse(Console.ReadLine());
            // pares = par(num);
            // Console.WriteLine("si devuelve 1 es par, si devuelve 0 es impar:   " + pares);
        // }

        // static int par(int a){
            // int par = 1;
            // int impar = 0;
            //  if (a % 2 == 0){
                // return par;
            //  }else{
                // return impar;
            //  }
        // }


        //.....................................................................................................
        

        // static void Main(string[] args)
        // {

            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número
            //  es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando
            //   se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.  
            // int num, todosLosPrimos, acu = 0, con = 0, promedio;

            // Console.WriteLine("Ingrese un numero: ");
            // num = int.Parse(Console.ReadLine());
            // while (num != 0)
            // {
                // todosLosPrimos = primo(num);
                // if (todosLosPrimos == 1)
                // {
                    // acu += num;
                    // con++;    
                // }

                // Console.WriteLine("Ingrese otro numero: ");
                // num = int.Parse(Console.ReadLine());
            // }

            // promedio = acu / con;
            // Console.WriteLine("El promedio de todos los numeros primos es: " + promedio);



            // //  MODO DE GUIA:
            // // Console.WriteLine("Ingrese un numero: ");
            // // num = int.Parse(Console.ReadLine());
            // // primos = primo(num);
            // // Console.WriteLine("si devuelve 1 es primo, si devuelve 0 no es primo:   " + primos);
        // }

        // static int primo(int a){
            // int primo = 1;
            // int noPrimo = 0;
            // int con = 0;
            // //Opcion1:
            // // for(int x = 1; x < (a+1); x++)
            // // {
                // // if(a % x == 0){
                    // // con++;
                // // }
            // // }
            // // if(con != 2){
                // // return noPrimo;
            // // }else{
                // // return primo;
            // // }

            // //Opcion2
            for(int x = 1; x <= a; x++)
            {
                if(a % x == 0){
                    con++;
                }
            }
            if(con == 2){
                return primo;
            }else{
                return noPrimo;
            }
        }


            //.....................................................................................................
    
    
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada
            //  “positivoNegativoCero” que reciba un número por valor y una variable por
            //   referencia. Que analice el número y escriba variable recibida por referencia con:
    
            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.

            int numero, estadoOrig = 9;
            
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(numero, ref estadoOrig);

            Console.WriteLine("El estado del numero: " + numero + " es: " + estadoOrig);

        }
        static void positivoNegativoCero(int a, ref int estado){
            if (a > 0){
                estado = 1;
            }else if(a == 0){
                estado = 0;
            }else{
                estado = -1;
            }

        }





    }
}






// 4. Hacer una función de tipo void (porque no va a devolver nada) llamada
//  “positivoNegativoCero” que reciba un número por valor y una variable por
//   referencia. Que analice el número y escriba variable recibida por referencia con:

// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.