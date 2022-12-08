//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//1е решение

int Summ(int n)
{
 int sum = 0;
 while (n > 9) 
 {  
 sum = sum + n % 10;
 n = n / 10;
 }
sum = sum + n;
return sum;
}
Console.WriteLine(Summ(9012));

//2е решение

int Summ2(int n2)
{
  int sum2 = 0;
  for(sum2 = sum2 + n2 % 10; n2 > 9;  n2 = n2 / 10)  
  sum2 = sum2 + n2;
  return sum2;
}
Console.WriteLine(Summ(23521));

