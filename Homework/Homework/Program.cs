//2 eded extension method yazirsiz.

//

using Homework.Controllers;
using Homework.Helper.Extensions;
using Homework.Services;
//Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir.

//string text = "bahruz@gmail.com";

//Console.WriteLine(text.CheckCharinEmail('@'));

//Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.

//string password = "bahruz1";

//Console.WriteLine(password.GetPasswordLength());


//int arrayi ucun extention method yazirsiz. 
//Hemin extention method arrayin elementlerinin hasilini tapsin

//int[] array = { 1, 2, 3, 4, 5, 3 };
//Console.WriteLine(array.MultipliArrayElements());

//CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur.
//Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq.
//Reqemler ve operatorlar console-dan daxil edilmelidir. Uygun controller de olsun

Controller controller = new Controller();
controller.Calculator();