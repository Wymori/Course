using System.Runtime.CompilerServices;

namespace DomashneeZadanie.Course.Task_1.Guns;

public class Gun
{
    public Gun()
    {
        durability = 100;
    }
    public int ammo;
    public int dist;
    public int damage;
    public int full_ammo;
    public int full_durability;
    public int durability;

    public bool CanShoot()
    {
        if (ammo <= 0)
        {
            Console.WriteLine("Недостаточно патронов");
        }
        return ammo > 0;
    }

    public void Reload()
    {
        Console.WriteLine("Перезарядка");
        ammo = full_ammo;
    }
    public virtual void Attack()
    {
        Console.WriteLine("Произошла атака");
    }
    public bool CanAttack()
    {
        if (durability <= 0)
        {
            Console.WriteLine("Оружие сломалось");
        }
        return durability > 0;
    }

    public void ChangeWeapon()
    {
        Console.WriteLine("Перезарядка");
        durability = full_durability;
    }
}
