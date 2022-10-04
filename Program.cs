// string name = "Name";
// string surname = "Surname";
// int age = 1999999999;
// double height = 1.82;
// float weight = 78.3f;
// decimal index = 23.5M;
// char operators = '+';
// bool check = false;
// long number = 199999999999999999;
// ulong numbern = 1999999999999999999;
// Console.WriteLine("Hello "+name+ ", you are welcome.");
// Console.WriteLine(surname);
// Console.WriteLine(age);   
// Console.WriteLine(height);
// Console.WriteLine(weight);
// Console.WriteLine(index);

// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
// Console.Write(name +" enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());
// int dateBirhtday = 2022 - age;
// Console.WriteLine("Date of birhday "+ dateBirhtday);



// Valyuta Converter

// double dollar = 1.7;
// double euro = 1.6722;
// Console.Write("Write amount: ");
// double manat = Convert.ToDouble(Console.ReadLine());
// double dollarResult = manat/dollar;
// double euroResult = manat/euro;
// Console.WriteLine(manat + " manat is " + dollarResult + " dollar");
// Console.WriteLine(manat + " manat is " + euroResult + " euro");


// Calculator
char operators = '+';
Console.Write("First number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Top:
Console.Write("Write operator: ");
string myOperator = Console.ReadLine();


if (myOperator == "+")
{
    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber+secondNumber));
}else if(myOperator == "-"){
    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber-secondNumber));
}else if(myOperator == "*"){
    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber*secondNumber));
}else if(myOperator == "/"){
    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber/secondNumber));
}else{
    Console.WriteLine("Only + - * /, repeat again.");
    goto Top;
}