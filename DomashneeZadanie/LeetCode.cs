using System.Security.Cryptography.X509Certificates;

namespace DomashneeZadanie;

public class LeetCode
{
    /* Даны 2 массива в каждом лежит число разбитое на сотни, десяти и тп и написано задом наперёд, надо найти сумму этих чисел и вывести в таком же формате*/
    List<int> l1 = new List<int>() { 123 };
    List<int> l2 = new List<int>();
    int number1 = 21, number2 = 21;
    public int numbers()
    {
        string chislo_str = Console.ReadLine();
        int chislo_int = Convert.ToInt32(chislo_str);
        number1 = chislo_int;
        l1.Add(number1);
        return 0;
    }
    public void print() => Console.WriteLine(number1);

}

