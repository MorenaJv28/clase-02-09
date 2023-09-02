//// EJEMPLO DE SUM
//var Numbers = new List<int>() { 8, 2, 6, 3 };
//int sum = Numbers.Sum();

//Console.WriteLine(sum.ToString());

//Console.WriteLine("=============================");

//// SUMA DE DECIMAL

//var Num = new List<double> {8.1, 2.2, 6.1, 3.3};
//double suma = Num.Sum();

//Console.WriteLine(suma.ToString());

//Console.WriteLine("=============================");

//EMPTY LIST

//var NUM = new List<int>();
//int Suma = NUM.Sum();

//Console.WriteLine("=============================");


//NULOS 

//var N = new List<int?> {8,2,null,3 };
//int? sum = N.Sum();

//Console.WriteLine(sum.ToString());

//Console.WriteLine("=============================");

// suma con sintaxis

//var list = new List<int> {8, 2, 6, 3};
//int l = (from x in select x).Sum();

//Console.WriteLine(l);

//Console.WriteLine("=============================");

//var list = new List<int> { 8, 2, 6, 3 };
//int SUM = (from x in list where x > 4 select x).Sum();

//Console.WriteLine(SUM);

//Console.WriteLine("=============================");

//MAX

//var n = new List<double> { 1.0, 8.1, 3.3, 2.0 };
//double maxNumber = n.Max();

//Console.WriteLine(maxNumber);

//Console.WriteLine("=============================");

// MAX EN NULLS
//var N = new List<int?> {1, 8, null, 3 };
//int? maxNumber = N.Max();

//Console.WriteLine(maxNumber);

//Console.WriteLine("=============================");

//MAX CON SINTAXIS
//var list = new List<int> { 1, 8, 3, 2 };
//int SUM = (from x in list  select x).Max();

//Console.WriteLine(SUM);

//Console.WriteLine("=============================");

//var list = new List<int> { 1, 8, 3, 2 };
//int SUM = (from x in list where x < 5 select x).Max();

//Console.WriteLine(SUM);

//Console.WriteLine("=============================");

// MINIMO
//var n = new List<int> {8, 2, 6, 3 };
//int minNumber = n.Min();

//Console.WriteLine(minNumber);

//Console.WriteLine("=============================");

//var n = new List<double> {8.1, 3.3, 2.2, 6.1 };
//double minNumber = n.Min();

//Console.WriteLine(minNumber);

//Console.WriteLine("=============================");

// MIN CON SINTAXIS


//Console.WriteLine("=============================")

// COUNT

//IEnumerable <string> items = new List<string> {"a", "b", "c" };
//int count = items.Count(); 

//Console.WriteLine(count);

//Console.WriteLine("=============================")

//IEnumerable<string> items = new List<string> {};
//int count = items.Count();

//Console.WriteLine(count);

//Console.WriteLine("=============================")

//IEnumerable <int> items = new List<int> {8, 3, 2 };
//int count = (from x in items  select x).Count();

//Console.WriteLine(count);

//Console.WriteLine("=============================")

//IEnumerable<int> items = new List<int> { 8, 3, 2 };
//int count = (from x in items where x < 5 select x).Count();

//Console.WriteLine(count);

//Console.WriteLine("=============================")

// EJEMPLOS 

//var list = new List<int> { 1, 8, 3, 2 };
//double resultado = list.Average();

//var list = new List<double> { 1.0, 8.1, 3.3, 2.0 };
//double resultado = list.Average();

//var list = new List<int> { 1, 8, null, 3 };
//double resultado = list.Average();

//Func <int, int> square = x => x * x;   
//Console.WriteLine(square(5));

int[] num = {3, 4, 5, 6, 4, 5, 7 };
var numMayores = num.Where(n => n > 5).ToList();
var numPares = num.Where(n  => n % 2 == 0).ToList();
var numImpares = num.Where(n => n % 2!= 0).ToList();



foreach (int numNum in numMayores)
{
    Console.Write($"{numNum} ");
}

Console.WriteLine();

foreach (int numNum in numPares)
{
    Console.Write($"{numNum} ");
}

Console.WriteLine();

foreach (int numNum in numImpares)
{
    Console.Write($"{numNum}  ");
}

Console.WriteLine();