namespace DomashneeZadanie.Course.Task_1.Guns;

internal class Kalash : Range
{
    public Kalash()
    {
        Console.WriteLine("Введите объём магазина");
        full_ammo = Convert.ToInt32(Console.ReadLine());
    }

    public override void Attack()
    {
        if (CanShoot())
        {
            base.Attack();
            Console.WriteLine("Выстрел из AK");
            Console.WriteLine(ammo);
        }

        Console.WriteLine("===========================");
    }
}
