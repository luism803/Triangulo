/*Crear un programa que pida la base de un triangulo y lo dibuje
	la base ha de ser mayor igual que 3 e impar.*/

using System;

class Triangulo{

    static void Main(){

        int  nbase=0;	
        string cadenaIntroducida = "", espacio="  ", asterico="* ";
        bool correcto = false;		//SUPONEMOS QUE EL TRY NO SE VA A FINALIZAR
        
        do{

			try{

				Console.Write("Introduce la base: ");
				cadenaIntroducida = Console.ReadLine();
				nbase = Convert.ToInt32(cadenaIntroducida);
				
				if(nbase <3)
					throw new Exception("La base no puede ser menor que 3.");	
				
				if(nbase % 2 == 0)
					throw new Exception("La base no puede ser par.");				
					
				correcto = true;		//HEMOS LLEGADO AL FINAL DEL TRY
			}
			catch(FormatException){		//HEMOS INTRODUCIDO UN STRING QUE NO SE PUEDE TRANSFORMAR A ENTERO

				Console.WriteLine(cadenaIntroducida+" no es un número válido.");
				Console.WriteLine();
			}		
			catch(Exception e){		//SI HEMOS LLEGADO HASTA ESTE CATH ES PORQUE ES UN EXCEPTION PERSONALIZADO
				
				Console.WriteLine(e.Message);
				Console.WriteLine();
			}
		}while(!correcto);		//SI EL PROGRAMA NO HA LLEGADO AL FINAL DEL TRY
        
		//DIBUJAR LA PIRÁMIDE
        for(int altura=0; altura<(nbase/2)+1;altura++){		//DIBUJAR UN ALTURA QUE SERÁ IGUAL A (LA BASE INTRODUCIDA / 2)+1  EJEMPLO: BASE = 7 => 7/2+1 = 4 (1-3-5-7)

            for(int i=0; i<(nbase/2)-altura;i++){		//DIBUJAREMOS LOS ESPACIOS

                Console.Write(espacio);
            }
            for(int i=0;i<(altura*2)+1;i++){		//DIBUJAMOS LOS ASTERISCOS

                Console.Write(asterico);
            }
            Console.WriteLine();		//PASAMOS A LA SIGUIENTE ALTURA
        }
    }
}
