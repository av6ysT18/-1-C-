Console.WriteLine("Ведите число от 1 до 7 обозначающие дни недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 | number == 7)
{
 Console.WriteLine("Ура, выходной!");
}
else
{
  Console.WriteLine("Все еще рабочая неделя");  
}
