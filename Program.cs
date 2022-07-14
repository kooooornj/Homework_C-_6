/* Zadacha 41
int CreateMassiv( int N)
{
int[] array = new int[N];
for (int i = 0; i<N; i++)
{
   Console.WriteLine("Введите число");
   array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i<N; i++)
{
    if(array[i]>0)
    {
        count++;
    }
}
return count;
}
Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
int result = CreateMassiv(a);
Console.WriteLine("");
Console.WriteLine("Кол-во элементов > 0  = " + result);
*/
/* Zadacha 43 */
void TochkaPeres()
{
    Console.Write("Введите коэфициент k1 ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэфициент k2 ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэфициент b1 ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэфициент b2 ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double x = (b1 - b2)/(k2-k1);
    double y = (k2*(b1-b2))/(k2-k1);
    Console.WriteLine("Координаты точки пересечения двух прямых: {0} ; {1}" , x, y );
}
TochkaPeres();