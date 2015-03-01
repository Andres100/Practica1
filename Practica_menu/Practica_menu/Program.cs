/*
 * Created by SharpDevelop.
 * User: MARTIN
 * Date: 01/03/2015
 * Time: 01:35 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int valor1;
			int valor2;
			int resul;
			int opc;
			
			Console.Title = "Eres cosa seria!";
			Console.WriteLine("seleccione la accion a realizar ");
			
			Console.WriteLine("1-Suma 2-Resta 3- Multiplicacion 4-Division 5-Area triangulo 6-Area de circulo 7-Area de cuadrado");
			opc= int.Parse(Console.ReadLine());
			
			switch(opc){
		case 1:
			Console.WriteLine("Dame el primer numero");
			valor1 = int.Parse(Console.ReadLine());
	    	Console.WriteLine("Dame el segundo numero");
			valor2 = int.Parse(Console.ReadLine());
            resul = valor1 + valor2;
			Console.WriteLine("{0} + {1} = {2}", valor1, valor2, resul);

		    break;
      case 2:
			Console.WriteLine("Dame el primer numero");
			valor1 = int.Parse(Console.ReadLine());
	    	Console.WriteLine("Dame el segundo numero");
			valor2 = int.Parse(Console.ReadLine());
            resul = valor1 - valor2;
			Console.WriteLine("{0} - {1} = {2}", valor1, valor2, resul);
			break;
       case 3:
			Console.WriteLine("Dame el primer numero");
			valor1 = int.Parse(Console.ReadLine());
	    	Console.WriteLine("Dame el segundo numero");
			valor2 = int.Parse(Console.ReadLine());
            resul = valor1 * valor2;
			Console.WriteLine("{0} * {1} = {2}", valor1, valor2, resul);
         break;

       case 4:
			Console.WriteLine("Dame el primer numero");
			valor1 = int.Parse(Console.ReadLine());
	    	Console.WriteLine("Dame el segundo numero");
			valor2 = int.Parse(Console.ReadLine());
            resul = valor1 / valor2;
			Console.WriteLine("{0} / {1} = {2}", valor1, valor2, resul);
          break;
         case 5:
          Console.WriteLine("Dame la base");
			valor1 = int.Parse(Console.ReadLine());
	    	Console.WriteLine("Dame la altura");
			valor2 = int.Parse(Console.ReadLine());
            resul = valor1 * valor2 /2;
			Console.WriteLine("{0} * {1} /2 = {2}", valor1, valor2, resul);
          break;
         case 6:
			double pi,area,radio;
			Console.Write("Radio: ");
			radio= double.Parse(Console.ReadLine());
			pi=Convert.ToDouble(3.1416);
			area= pi*(radio * radio);
			
			Console.WriteLine("El area del circulo es:");
			Console.WriteLine(" {0} * {1}^2 = {2}", pi, radio,area);
			break;
         case 7:
          Console.WriteLine("Dame el primer lado del cuadrado");
			valor1 = int.Parse(Console.ReadLine());
	    	Console.WriteLine("Dame el segundo lado del cuadrado");
			valor2 = int.Parse(Console.ReadLine());
            resul = valor1 * valor2;
			Console.WriteLine("{0} * {1} = {2}", valor1, valor2, resul);
          break;
          }
	
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}