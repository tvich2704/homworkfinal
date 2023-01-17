string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2","computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
Console.WriteLine($"[{string.Join(", ", array1)}]->[{string.Join(", ", answer(array1))}]");
Console.WriteLine($"[{string.Join(", ", array2)}]->[{string.Join(", ", answer(array2))}]");
Console.WriteLine($"[{string.Join(", ", array3)}]->[{string.Join(", ", answer(array3))}]");


//для проверки с клавиатуры по желанию
// Console.Write("Введите с клавиатуры элементы массива через пробел:");
// string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"[{string.Join(", ", str)}]->[{string.Join(", ", answer(str))}]");


