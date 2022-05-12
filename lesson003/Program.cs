// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число");
int count = int.Parse(Console.ReadLine()); 
int count2 = count;
int index = 0;
while ( count > 0)
{
    int digit = count % 10; 
    index = index *10 + digit;
    count = count / 10;  
}
if ( index == count2)
{
    Console.WriteLine("Это палиндром");    
}
else
{
    Console.WriteLine("Это не палиндром");
}