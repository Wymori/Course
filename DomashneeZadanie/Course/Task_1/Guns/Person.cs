namespace DomashneeZadanie.Course.Task_1.Guns;

public class Person

{

    public Gun Weapon = new Kalash();

    public void Reload() => Weapon.Reload();

    public void Attack() => Weapon.Attack();

    public void ChangeWeapon(Gun weapon)
    {
        Weapon = weapon;
        Console.WriteLine("Оружие изменино");
    }
}
