Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int negativeNumber = number * -1;
while (negativeNumber <= number)
{
    Console.Write(negativeNumber);
    Console.Write(" ");
    negativeNumber++;
}
