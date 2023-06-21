// Задача №1

// System.Console.WriteLine("Напишите число, которое желаете проверить ->");
// string? number = Console.ReadLine();

// void CheckNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Данное число: {number} -> палиндром.");
//   }
//   else Console.WriteLine($"Данное число: {number} -> не палиндром.");
// }

// if (number!.Length == 5){
// CheckNumber(number);
// }
// else Console.WriteLine($"Напишите правильное число");

// Задача №2

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string symbol, string pointName)
// {
//     Console.Write($"Введите координату {symbol} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double solution(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2)
// {
// return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (solution(x1, x2, y1, y2, z1, z2), 2 );
// System.Console.WriteLine($"Расстроение между двумя точками -> {segmentLength} ");

// Задача №3

// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
// int counter = 0;
// int length = cube.Length;
// while (counter <  length){
//  cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//  counter++;
// }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);
