/*
int number = 1233647623;
Console.WriteLine(Convert.ToString(number)[2]); // думал о решении с массивами, но пришлось посмотреть как)
*/
int number =123457976;

while(number > 1000)
{
    number/=10;
    Console.WriteLine(number); //
}
Console.WriteLine("третья цифра" + number%10);