int [] x = new int[2];
int [] y = new int[2];
int [] z = new int[2];
int xyz;

for(int i = 0;i < x.Length ;i++)
{
Console.WriteLine($"Введите {i + 1}-ые координаты для x,у и z: ");
x[i] = Convert.ToInt32(Console.ReadLine());
y[i] = Convert.ToInt32(Console.ReadLine());
z[i] = Convert.ToInt32(Console.ReadLine());
}

xyz = (x[1] - x[0])*(x[1] - x[0]) + (y[1] - y[0])*(y[1] - y[0]) + (z[1] - z[0])*(z[1] - z[0]);
Console.WriteLine("Расстояние между точками равно: " + Math.Round(Math.Sqrt(xyz)));

