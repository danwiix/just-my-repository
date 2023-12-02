int i = 1; // Заменить на 0
int nums = 0;
while (i > 0) // Заменить на i < 101
{
    i = Convert.ToInt32(Console.ReadLine());
    nums = nums + 1;
}
if (i <= 0) // Заменить на i >= 101
    Console.WriteLine(nums);

