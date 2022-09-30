/*Crear un programa que pida la base de un triangulo y lo dibuje*/

using System;

class Triangulo{

    static void Main(){

        int  nbase;
        string espacio="  ", asterico="* ";
        
        Console.Write("Introduce la base: ");
        nbase = Convert.ToInt32(Console.ReadLine());

        for(int altura=0; altura<(nbase/2)+1;altura++){

            for(int i=0; i<(nbase/2)-altura;i++){

                Console.Write(espacio);
            }

            for(int i=0;i<(altura*2)+1;i++){

                Console.Write(asterico);
            }
            Console.WriteLine();
        }

    }
}
