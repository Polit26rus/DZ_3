Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int[n];
Console.Write("Таблица кубов: ");
for(int i = 0;i < array.Length;i++){
    array[i] = (i + 1)*(i + 1)*(i + 1);
    Console.Write(array[i] + " ");
}
