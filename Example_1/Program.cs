// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа (q - завершить ввод): ");
string input = Console.ReadLine();
int count = 0;
while (input != "q")
{
    int number = Convert.ToInt32(input);
    if (number > 0)
    {
        count += 1;
    }
    input = Console.ReadLine();
}
Console.WriteLine($"Количество чисел больше 0 = {count}");