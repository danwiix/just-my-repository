Console.WriteLine("Введите ваш возраст");
int age = Convert.ToInt32(Console.ReadLine());


if (age >= 18)
    Console.WriteLine("Вы совершеннолетний.");
else
{
    Console.WriteLine("Вы несовершеннолетний.");
}