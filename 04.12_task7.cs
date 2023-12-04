Console.WriteLine("Введите число:");

int num = Convert.ToInt32(Console.ReadLine());

int num_length = 0;

while(num > 0)
{
    num_length++;
    num = (int)(num / 10);
}
Console.WriteLine(num_length);