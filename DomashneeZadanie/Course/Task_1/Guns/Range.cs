namespace DomashneeZadanie.Course.Task_1.Guns;

internal class Range : Gun
{
    public override void Attack()
    {
        ammo -= 1;
        durability -= 1;
    }
}
