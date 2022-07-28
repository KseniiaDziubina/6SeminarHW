Console.Write("Введите коэффицент k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицент b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицент k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицент b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 2);
y = Math.Round(y, 2);
 
Console.WriteLine($"Пересечение прямых в точке с координатами ({x}; {y})");