using System;

namespace DomashneeZadanie.Course.Task_1.Guns;

internal class Knife : Melee
{
    public override void Attack()
    {
        Console.WriteLine("Выстрел из Ножа");
        Console.WriteLine("===========================");
    }


}
