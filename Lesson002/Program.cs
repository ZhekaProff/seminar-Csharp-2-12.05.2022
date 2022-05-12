// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите кординаты точки: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if ( x > 0 && y > 0)
{
    Console.WriteLine("точка находится в первой четверти");
}
if ( x > 0 && y < 0)
{
    Console.WriteLine("точка находится в четвертой четверти");
}
if ( x < 0 && y < 0)
{
    Console.WriteLine("точка находится в третьей четверти");
}
if ( x < 0 && y > 0)
{
    Console.WriteLine("точка находится во второй четверти");
}