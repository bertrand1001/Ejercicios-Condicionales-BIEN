using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Condicionales_BIEN

{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Pedir dos números y decir si son iguales o no.
            Console.WriteLine("Introduce two numbers:");
            int num1 = Int32.Parse(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2 )
            {
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                Console.WriteLine("These two numbers are NOT equal.");
            }

            // Introduce un número e indica si es par o impar.
            Console.WriteLine("Introduce one numbers:");
            int num3 = Int32.Parse(Console.ReadLine());

            if ((num3 % 2) == 0)
            {
                Console.WriteLine("It's an even number");
            }
            else
            {
                Console.WriteLine("It's an odd number");
            }


            // Pedir un número del 1-7 y decir que día de la semana es.
            Console.WriteLine("Write a number between 1-7:");
            int num4 = Int32.Parse(Console.ReadLine());

            if (num4 == 1)
            {
                Console.WriteLine("It's monday.");
            }
            else if (num4 == 2)
            {
                Console.WriteLine("It's tuesday");
            }
            else if (num4 == 3)
            {
                Console.WriteLine("It's wednesday");
            }
            else if (num4 == 4)
            {
                Console.WriteLine("It's thursday");
            }
            else if (num4 == 5)
            {
                Console.WriteLine("It's friday");
            }
            else if (num4 == 6)
            {
                Console.WriteLine("It's saturday");
            }
            else if (num4 == 7)
            {
                Console.WriteLine("It's sunday");
            }
            else
            {
                Console.WriteLine("A week has no more days!");
            }


            // Pedir un número del 1-12 y decir que día de la mes es.
            Console.WriteLine("Write a number between 1-12:");
            int num5 = Int32.Parse(Console.ReadLine());

            switch (num5)
            {
                case 1:
                    Console.WriteLine("It's January");
                    break;
                case 2:
                    Console.WriteLine("It's February");
                    break;
                case 3:
                    Console.WriteLine("It's Mars");
                    break;
                case 4:
                    Console.WriteLine("It's April");
                    break;
                case 5:
                    Console.WriteLine("It's May");
                    break;
                case 6:
                    Console.WriteLine("It's June");
                    break;
                case 7:
                    Console.WriteLine("It's July");
                    break;
                case 8:
                    Console.WriteLine("It's August");
                    break;
                case 9:
                    Console.WriteLine("It's September");
                    break;
                case 10:
                    Console.WriteLine("It's October");
                    break;
                case 11:
                    Console.WriteLine("It's November");
                    break;
                case 12:
                    Console.WriteLine("It's December");
                    break;
                default:
                    Console.WriteLine("A year has no " + num5 + " months.");
                    break;
            }


            // Pedir un número del nota y decir a que equivale.
            Console.WriteLine("Write your grade:");
            double num6 = Double.Parse(Console.ReadLine());

            if (num6 >= 0 && num6 < 5)
            {
                Console.WriteLine("Fail");
            }
            else if (num6 >= 5 && num6 < 6)
            {
                Console.WriteLine("Pass");
            }
            else if (num6 >= 6 && num6 < 7)
            {
                Console.WriteLine("Good");
            }
            else if (num6 >= 7 && num6 < 9)
            {
                Console.WriteLine("Very good");
            }
            else if (num6 >= 9 && num6 <= 10)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Grades are scaled from 0-10");
            }


            //Pedir por teclado el peso, altura y reporta el IMC (p/a2)
            Console.WriteLine("Indicate your weigth (kg):");
            Double weigth = Double.Parse(Console.ReadLine());
            Console.WriteLine("Indicate your height (m)");
            Double height = Double.Parse(Console.ReadLine());
            Double IMC;
            IMC = (weigth / Math.Pow(height,2));
            string status = "";
            if (IMC < 16){
                status = "Extreme thinness";
            } else if (IMC >= 16 && IMC < 17){
                status = "Moderate thinness";
            }
            else if (IMC >= 17 && IMC < 18.5)
            {
                status = "Acceptable thinness";
            }
            else if (IMC >= 18.5 && IMC < 24.5)
            {
                status = "Normal";
            }
            else if (IMC >= 25 && IMC < 30)
            {
                status = "Overweight";
            }
            else if (IMC >= 30 && IMC < 35)
            {
                status = "Type I Obesity";
            }
            else if (IMC >= 35 && IMC < 40)
            {
                status = "Type II Obesity";
            }
            else if (IMC > 40)
            {
                status = "Type III Obesity";
            }
            Console.WriteLine("Your IMC is " + IMC + "\nwhich means that you are " + status + " IMC group");



            //Escribe un programa que pida al usuario 3 números.Si el resultado de la suma de los dos primeros es igual al tercer número, mostrarlo en pantalla, sino mostrar que el tercero no es la suma de los dos anteriores.
            Console.WriteLine("Write three numbers:");
            double num7 = Double.Parse(Console.ReadLine()), num8 = Double.Parse(Console.ReadLine()), num9 = Double.Parse(Console.ReadLine());
            if ((num7+num8) == num9)
            {
                Console.WriteLine(num9 + " is the sum of " + num7 + "+" + num8);
            } else {
                Console.WriteLine(num9 + " is not the sum of " + num7 + " + " + num8);
            }


            //Escribe un programa que convierta los segundos a horas, minutos y segundos.
            Console.WriteLine("Introduce an amount of seconds:");
            int secs = Int32.Parse(Console.ReadLine());
            int hours, minutes, seconds;
            hours = (secs / 3600);
            minutes = (secs / 60) % 60;
            seconds = secs - (hours * 3600 + minutes * 60);
            Console.WriteLine(secs + " seconds are " + hours + " h " + minutes + " min " + seconds + " s ");


            //Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.
            Console.WriteLine("Write three numbers:");
            double num10 = Double.Parse(Console.ReadLine()), num11 = Double.Parse(Console.ReadLine()), num12 = Double.Parse(Console.ReadLine());
            double pri, sec, ter;
            pri= (Math.Abs(num10 - num11));
            sec = (Math.Abs(num11 - num12));
            ter = (Math.Abs(num10 - num12));


            if (pri == 20 && sec != 20 && ter != 20)
            {
                Console.WriteLine("The difference between " + num10 + " and " + num11 + " is 20");
            }
            else if (pri != 20 && sec == 20 && ter != 20)
            {
                Console.WriteLine("The difference between " + num11 + " and " + num12 + " is 20");
            }
            else if (pri != 20 && sec != 20 && ter == 20)
            {
                Console.WriteLine("The difference between " + num10 + " and " + num12 + " is 20");
            }
            else if (pri == 20 && sec == 20 && ter != 20)
            {               Console.WriteLine("The difference between " + num10 + "-" + num11 + " and " + num11 + "-" + num12 + " is 20");
            }
            else if (pri == 20 && sec != 20 && ter == 20)
            {
                Console.WriteLine("The difference between " + num10 + "-" + num11 + " and " + num10 + "-" + num12 + " is 20");
            }
            else if (pri != 20 && sec == 20 && ter == 20)
            {
                Console.WriteLine("The difference between " + num11 + "-" + num12 + " and " + num10 + "-" + num12 + " is 20");
            }           else if (pri == 20 && sec == 20 && ter == 20)
            {               Console.WriteLine("The difference between " + num10 + " , " + num11 + " and " + num12 + " is 20");
            }          else
            {                Console.WriteLine("Neither difference equals 20");
            }


            //Escribe un programa que pida dos valores del usuario y
            Console.WriteLine("Introduce two values:");
            double num13 = Double.Parse(Console.ReadLine()), num14 = Double.Parse(Console.ReadLine());
            //Si los dos valores son iguales muestre 0
            if (num13 == num14)
            {
                Console.WriteLine("0");
            }
            //Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            if ((num13 % 6) == (num14 % 6))
            {
                if (num13 < num14)
                {
                    Console.WriteLine(num13);
                }
                else 
                {
                    Console.WriteLine(num14);
                }
            }
            //Si no que muestre el más grande de los dos
            else
            {
                if (num13 > num14)
                {
                    Console.WriteLine(num13);
                }
                else
                {
                    Console.WriteLine(num14);
                }
            }



            //Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.
            Console.WriteLine("Introduce two values between 25 and 75:");
            int num15 = Int32.Parse(Console.ReadLine()), num16 = Int32.Parse(Console.ReadLine());

            if (!((num15 >= 25 && num15 <= 75) && (num16 >= 25 && num16 <= 75)))
            {
                Console.WriteLine("Introduced numbers are not within the range (25-75)");
                Environment.Exit(1);
            }

            int num152 = (num15 % 10), num151 = ((num15 - num152) / 10);
            int num162 = (num16 % 10), num161 = ((num16 - num162) / 10);

            if (num151 == num161)
            {
                Console.WriteLine("Both numbers contain " + num151);
            }
            else if (num152 == num161)
            {
                Console.WriteLine("Both numbers contain " + num152);
            }
            else if (num151 == num162)
            {
                Console.WriteLine("Both numbers contain " + num151);
            }
            else if (num152 == num162)
            {
                Console.WriteLine("Both numbers contain " + num152);
            }

            //Vamos a escribir varios programas que saludan al usuario al iniciar.El usuario tiene asociadas 3 variables, una que indica si ha pagado la entrada, una que indica si es cliente VIP y la otro el saldo que tiene(positivo para saldo de más, negativo para deuda).Haz los siguientes programas:
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine(name + ", did you pay the ticket? y/n");
            string ticket = Console.ReadLine();
            if (ticket != "y" && ticket != "n")
            {
                Console.WriteLine("Restrict your answer to 'y' or 'n'");
                ticket = Console.ReadLine();
            }

            Console.WriteLine(name + ", are you enrolled as a VIP? y/n");
            string vip = Console.ReadLine();
            if (vip != "y" && vip != "n")
            {
                Console.WriteLine("Restrict your answer to 'y' or 'n'");
                vip = Console.ReadLine();
            }

            Console.WriteLine(name + ", how is the balance in your account? +/0/-");
            string balance = Console.ReadLine();
            if (balance != "+" && balance != "0" && balance != "-")
            {
                Console.WriteLine("Restrict your answer to '+', '0' or '-'");
                balance = Console.ReadLine();
            }

            //Comprobar si se ha pagado la entrada.Si se ha pagado, mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".
            if (ticket == "y")
            {
                Console.WriteLine("Wellcome, " + name);
            }
            else
            {
                Console.WriteLine("You need to pay the ticket, " + name);
            }

            //A todos se les dice "Bienvenido", pero si es cliente VIP después de "Bienvenido" también se le dice "Que pase un buen día"
            if (vip != "y")
            {
                Console.WriteLine("Wellcome, " + name);
            }
            else
            {
                Console.WriteLine("Wellcome and have a good day, " + name);
            }

            //Si no tiene deudas, le damos la bienvenida.En caso contrario no hacemos nada.
            if (balance != "-")
            {
                Console.WriteLine("Wellcome, " + name);
            }

            //Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0
            if (vip == "y" && balance == "+")
            {
                Console.WriteLine("Wellcome, " + name);
            }

            //Usando operador ?: : Comprobar si se ha pagado la entrada.Si se ha pagado, darle a la variable mensaje el valor "Bienvenido", si no darle el valor "Tienes que pagar la entrada".Mostrar el mensaje en pantalla
            ticket = (ticket == "y") ? "Wellcome" : "You need to pay the ticket";
            Console.WriteLine(ticket);


            //Resultado de carrera.Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó.Después:
            //Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            Console.WriteLine("In which position did you end the race? (insert a number)");
            int num17 = Int32.Parse(Console.ReadLine());
            if (num17 == 1)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("What counts is taking part");
            }

            //Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            Console.WriteLine("In which position did you end the race? (insert a number)");
            int num18 = Int32.Parse(Console.ReadLine());
            if (num18 == 1)
            {
                Console.WriteLine("Golden medal");
            }
            else if (num18 == 2)
            {
                Console.WriteLine("Silver medal");
            }
            else if (num18 == 3)
            {
                Console.WriteLine("Bronze medal");
            }
            else
            {
                Console.WriteLine("What counts is taking part");
            }
            //Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            Console.WriteLine("In which position did you end the race? (insert a number)");
            int num19 = Int32.Parse(Console.ReadLine());
            switch (num19)
            {
                case 1:
                    Console.WriteLine("Golden medal");
                    break;
                case 2:
                    Console.WriteLine("Silver medal");
                    break;
                case 3:
                    Console.WriteLine("Bronze medal");
                    break;
                default:
                    Console.WriteLine("What counts is taking part");
                    break;
            }
            //Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".Hazlo usando un if/else y usando switch
            Console.WriteLine("In which position did you end the race? (insert a number)");
            int num20 = Int32.Parse(Console.ReadLine());
            if (num20 == 1 || num20 == 2 || num20 == 3)
            {
                Console.WriteLine("Get on the podium!");
            }
            else
            {
                Console.WriteLine("The race is over");
            }

            Console.WriteLine("In which position did you end the race? (insert a number)");
            int num21 = Int32.Parse(Console.ReadLine());
            switch (num21)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Get on the podium!");
                    break;
                default:
                    Console.WriteLine("The race is over");
                    break;
            }

            //Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", si no mostramos "Eres demasiado mayor para usar el tobogán"
            Console.WriteLine("What's your age? (insert a number)");
            int num22 = Int32.Parse(Console.ReadLine());
            if (num22 <= 8 && num22 >= 0)
            {
                Console.WriteLine("You can use the slide");
            }
            else if (num22 < 0)
            {
                Console.WriteLine("Are you sure you entered the correct age?");
            }
            else
            {
                Console.WriteLine("You are too old to use the slide");
            }

            //Comprobar un string que tenga el valor del día de la semana(lunes, martes, ...). Mostrar en pantalla el día que dice que es si es entre lunes y viernes(Por ejemplo "Hoy es lunes") y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.
            Console.WriteLine("Which day of the week is today? (Monday,Tuesday...)");
            string str1 = Console.ReadLine();
            if (str1 == "Monday" || str1 == "Tuesday" || str1 == "Wednesday" || str1 == "Thursday" || str1 == "Friday")
            {
                Console.WriteLine("Today is a laborable day");
            }
            else if (str1 == "Saturday" || str1 == "Sunday")
            {
                Console.WriteLine("We are on the weekend!");
            }
            else
            {
                Console.WriteLine("Are you sure you entered the correct day?\n Check the orthography");
            }

            //A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7".Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor.Hacerlo con if else y otra vez pero con ?:
            Console.WriteLine("Enter an integer:");
            int num23 = Int32.Parse(Console.ReadLine());
            if (num23 == 0) 
            {
                Console.WriteLine("El valor absoluto de " + num23 + " es " + 0);
            }
            else if (num23 < 0)
            {
                Console.WriteLine("El valor absoluto de " + num23 + " es " + (-num23));
            }
            else
            {
                Console.WriteLine("El valor absoluto de " + num23 + " es " + num23);
            }
            //Easier if Math.Abs function is used
            //Console.WriteLine("El valor absoluto de " + num23 + " es " + Math.Abs(num23));


            //Decir el número de helados que queremos comprar.Cada helado vale 2 euros.Si compramos más de 10 helados, nos regalan uno gratis. Mostrar en pantalla el número de helados que nos dan y cuánto hemos pagado por ellos.
            Console.WriteLine("How many icecream balls do you want? (insert a number)");
            int num24 = Int32.Parse(Console.ReadLine());
            if (num24 > 0 && num24 <= 10)
            {
                Console.WriteLine("You ordered " + num24 + " icecream ball(s)\nYou need to pay " + (num24 * 2));
            }
            else if (num24 <= 0)
            {
                Console.WriteLine("We cannot give you such amount");
            }
            else
            {
                Console.WriteLine("You ordered " + num24 + " icecream ball(s)\nWe are giving you one extra ball for free; a total of " + (num24 + 1) + "\nYou need to pay " + (num24 * 2));
            }

            //Tenemos dos números, un numerador y un dividendo.Si el dividendo no es cero, mostramos el resultado de dividir el numerador por el dividendo.Si el dividendo es cero, mostramos el mensaje "No se puede dividir por cero"
            Console.WriteLine("Enter a number that's going to be considered as numerator:");
            double numerator = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number that's going to be considered as dividend:");
            double dividend = Double.Parse(Console.ReadLine());
            if (dividend != 0)
            {
                Console.WriteLine("The result of the division is " + (numerator/dividend));
            }
            else if (dividend == 0)
            {
                Console.WriteLine("It cannot be divided by zero");
            }


            //A partir de un número entero, decir si es par o impar.Utilizar if else y también hacerlo con ?
            Console.WriteLine("Is it odd or even? (insert a number)");
            int num25 = Int32.Parse(Console.ReadLine());
            if ((num25 % 2) == 0)
            {
                Console.WriteLine("It's an even number");
            }
            else if ((num25 % 2) != 0)
            {
                Console.WriteLine("It's an odd number");
            }

            //Un año es bisiesto si se puede dividir por 4.Pero un año que se pueda dividir por 100 NO es bisiesto a no ser que se pueda dividir por 400.A partir de un año, mostrar en pantalla si es bisiesto o no.
            Console.WriteLine("Is this a leap year? (insert a number)");
            int num26 = Int32.Parse(Console.ReadLine());
            if ((num26 % 4 == 0 && num26 % 100 != 0) || num26 % 400 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is NOT a leap year");
            }

            //Con if else if: Mostrar en pantalla un menú con varias opciones. Dependiendo de lo que el usuario elija, mostrar en pantalla la selección.Hacerlo tanto con if else como con switch.
            Console.WriteLine("Elige una opción del menú:\n1 - Atún con pan\n2 - Pan con atún\n3 - Pa amb tomaquet");
            Console.WriteLine("Elige un número de la lista");
            int num27 = Int32.Parse(Console.ReadLine());
            if (num27 == 1)
            {
                Console.WriteLine("Has elegido atún con pan para comer");
            }
            else if (num27 == 2)
            {
                Console.WriteLine("Has elegido pan con atún para comer");
            }
            else if (num27 == 3)
            {
                Console.WriteLine("Has elegido pa amb tomaquet para comer");
            }
            else
            {
                Console.WriteLine("No tenemos esa opción en el restaurante");
            }

            Console.WriteLine("Elige una opción del menú:\n1 - Atún con pan\n2 - Pan con atún\n3 - Pa amb tomaquet");
            Console.WriteLine("Elige un número de la lista");
            int num28 = Int32.Parse(Console.ReadLine());
            switch (num28)
            {
                case 1:
                    Console.WriteLine("Has elegido atún con pan para comer");
                    break;
                case 2:
                    Console.WriteLine("Has elegido pan con atún para comer");
                    break;
                case 3:
                    Console.WriteLine("Has elegido pa amb tomaquet para comer");
                    break;
                default:
                    Console.WriteLine("No tenemos esa opción en el restaurante");
                    break;
            }

            //Mostrar el mayor de dos valores
            Console.WriteLine("Type two numbers:");
            int num29 = Int32.Parse(Console.ReadLine());
            int num30 = Int32.Parse(Console.ReadLine());
            if (num29 != num30)
            {
                if (num29 > num30)
                {
                    Console.WriteLine(num29);
                }
                else
                {
                    Console.WriteLine(num30);
                }
            }
            else 
            {
                Console.WriteLine("The given numbers are equal");
            }

            //Mostrar el menor de dos valores
            Console.WriteLine("Type two numbers:");
            int num31 = Int32.Parse(Console.ReadLine());
            int num32 = Int32.Parse(Console.ReadLine());
            if (num31 != num32)
            {
                if (num31 < num32)
                {
                    Console.WriteLine(num31);
                }
                else
                {
                    Console.WriteLine(num32);
                }
            }
            else
            {
                Console.WriteLine("The given numbers are equal");
            }

            //Mostrar el mayor de tres valores
            Console.WriteLine("Type three different numbers:");
            int num33 = Int32.Parse(Console.ReadLine());
            int num34 = Int32.Parse(Console.ReadLine());
            int num35 = Int32.Parse(Console.ReadLine());
            if (num33 != num34 || num33 != num35)
            {
                if (num33 > num34 && num33 > num35)
                {
                    Console.WriteLine(num33);
                }
                else if (num34 > num33 && num34 > num35)
                {
                    Console.WriteLine(num34);
                }
                else if (num35 > num33 && num35 > num34)
                {
                    Console.WriteLine(num35);
                }
            }
            else
            {
                Console.WriteLine("Some of given numbers are equal");
            }

            //Mostrar el menor de tres valores
            Console.WriteLine("Type three different numbers:");
            int num36 = Int32.Parse(Console.ReadLine());
            int num37 = Int32.Parse(Console.ReadLine());
            int num38 = Int32.Parse(Console.ReadLine());
            if (num36 != num37 || num36 != num38)
            {
                if (num36 < num34 && num36 < num35)
                {
                    Console.WriteLine(num36);
                }
                else if (num37 < num36 && num37 < num38)
                {
                    Console.WriteLine(num37);
                }
                else if (num38 < num36 && num38 < num37)
                {
                    Console.WriteLine(num38);
                }
            }
            else
            {
                Console.WriteLine("Some of given numbers are equal");
            }

            //Un programa que te pregunta la temperatura que hace donde estás y te sugiere que hacer dependiendo de ella.Las recomendaciones son:
            //Si en hace más de 40 grados, vete a otro sitio
            //Entre 30 y 40 grados, enciende el aire acondicionado
            //Entre 30 y 20 grados, no hagas nada
            //Entre 10 y 20 grados, enciende la calefacción
            //Si hace menos de 10 grados, vete a otro sitio
            Console.WriteLine("What's the temperature (ºC) out there? (insert a number)");
            double temperature = Double.Parse(Console.ReadLine());
            if (temperature > 40)
            {
                Console.WriteLine("Get out of here, it's too hot!");
            }
            else if (temperature <= 40 && temperature > 30)
            {
                Console.WriteLine("Turn on the air");
            }
            else if (temperature <= 30 && temperature > 20)
            {
                Console.WriteLine("Chill");
            }
            else if (temperature <= 20 && temperature > 10)
            {
                Console.WriteLine("Turn on the heating");
            }
            else if (temperature <= 10)
            {
                Console.WriteLine("Get out of here, it's too cold!");
            }
        }
    }
}


//En una clase tienes tres exámenes, con un valor de 5 puntos máximo en cada uno.
//La nota final es la mejor nota de los dos primeros exámenes más la nota del tercer 
//examen. Crea un programa que con tres notas calcula el resultado de nota final con 
//los siguientes rangos:
//10 es matrícula
//9 y hasta 10 es sobresaliente
//7 y hasta 9 es notable
//6 y hasta 7 es bien
//5 y hasta 6 es suficiente
//0 hasta 4 es suspenso
/*
Console.WriteLine("Write grade first exam:");
double num39 = Double.Parse(Console.ReadLine());
Console.WriteLine("Write grade second exam:");
double num40 = Double.Parse(Console.ReadLine()), nota1;
if (num39 > num40)
{
    nota1 = num39;
}
else
{
    nota1 = num40;
}
Console.WriteLine("We will just consider the best grade. In this case: " + nota1);
Console.WriteLine();
Console.WriteLine("Write grade third exam:");
double num41 = Double.Parse(Console.ReadLine());
double notaFinal = (nota1 + num41);
Console.Write("Your final grade is " + notaFinal);

if (notaFinal >= 0 && notaFinal < 5)?            {?                Console.Write(", Fail");?            }?            else if (notaFinal >= 5 && notaFinal < 6)?            {?                Console.Write(", Pass");?            }?            else if (notaFinal >= 6 && notaFinal < 7)?            {?                Console.Write(", Good");?            }?            else if (notaFinal >= 7 && notaFinal < 9)?            {?                Console.Write(", Very good");?            }?            else if (notaFinal >= 9 && notaFinal < 10)?            {?                Console.Write(", Excellent");?            }?            else if (notaFinal == 10)?            {?                Console.Write(", Cum laude!");?            }?            else?            {?                Console.WriteLine("Grades are scaled from 0-10");?            }

//Escribe un programa que dice si los dígitos de un número de 
//tres cifras son todos impares, todos pares o son mezclados.
//Tu programa debe pedir un número al usuario, y mostrar el número, 
//seguido del mensaje "Todas las cifras son pares", "Todas las cifras " +
//"son impares" o "El número tiene cifras pares e impares".
Console.WriteLine("Write a number of three digits:");
int number = Int32.Parse(Console.ReadLine());
bool firstNum = ((number / 100) % 2) == 0;
bool secondNum = (((number % 100) / 10) % 2) == 0;
bool thirdNum = (((number % 10)) % 2) == 0;
if (firstNum == true && secondNum == true && thirdNum == true)
{
    Console.WriteLine(number + ": all the digits are even.");
}
else if (firstNum == false && secondNum == false && thirdNum == false)
{
    Console.WriteLine(number + ": all the digits are odd.");
}
else
{
    Console.WriteLine(number + ": contains even and odd digits.");
}
*/

//Para convertir de grados centígrados a grados fahrenheit multiplicamos por 9, le dividimos 5 y a ese resultado le añadimos 32.Para convertir de fahrenheit a centígrados le restamos 32, multiplicamos por 5 y dividimos entre 9.Pide un valor y pregunta al usuario si quiere convertirlo a centígrados(si escribe C) o si quiere convertirlo a fahrenheit(si escribe F) y muestra el valor en pantalla. 

//El usuario tiene dos hijos.Pregúntale la edad del mayor y los años de diferencia entre el mayor y el menor. Muestra en pantalla si el menor es mayor de edad o no.

//Crea un programa para ver si los comerciales reciben un extra.Si venden más de 500 euros, les damos un extra de el 5 % de lo que han vendido. El usuario introduce su nombre y el precio de las ventas.Muestra en pantalla las su nombre, seguido de las ventas y en el caso de que las ventas superen 500 euros el 5 % de las ventas como extra.

//Escribe un programa que pida dos números al usuario.Después muestra un mensaje que dice cómo se relacionan entre los dos. Por ejemplo si escribe 5 y 7 , muestra "5 es menor que 7".

//Escribe un programa que pida un número y muestre ese número al cuadrado y al cubo(multiplicado por sí mismo dos y tres veces). Si el número es menor que 1, no calcules el cubo ni el cuadrado.

//Pedir al usuario que introduzca S o N. Si introduce cualquier otro valor, repetirle las instrucciones hasta que lo haga.