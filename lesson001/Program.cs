// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число: ");
int count = int.Parse(Console.ReadLine());
if ( count % 7 == 0 && count % 23 == 0)
{
    Console.WriteLine("Число: "+count+" кратно 7 и 23");
}
else
{
    Console.WriteLine("Число: "+count+" не кратно 7 и 23");
}