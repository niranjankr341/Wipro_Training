int[] numbers = { 10, 20, 5, 30, 25 };
var result = from n in numbers
             where n > 15
             orderby n
             select n;
foreach(var x in result) Console.WriteLine(x);
