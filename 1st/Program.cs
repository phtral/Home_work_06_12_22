//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//1е решение:
int AtoDegreB(int a, int b)
{
int result = a;
 while( b > 1 )
  {
 result = result * a;
 b--;
  }
 return result;
}
Console.WriteLine(AtoDegreB(2,4));

//2е решение:
int AtoDegreB2(int a2, int b2){
int result2 = 0;
 for(result2 = a2; b2 > 1; b2--)
 {
    result2 = result2 * a2;
 }
 return result2;
}
Console.WriteLine(AtoDegreB2(3,5));