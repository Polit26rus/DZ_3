Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int p = 0;

while(n < 10000 | n > 99999){
    Console.Write("Ошибка!Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int clone_n = n;
for(int i = 0;i < 5;i++){
    p = p + (n % 10)*Convert.ToInt32(Math.Pow(10,4-i));
    n = n / 10;
}

if(clone_n == p){
    Console.WriteLine("Да,является.");
    }
else Console.WriteLine("Нет,не является.");
