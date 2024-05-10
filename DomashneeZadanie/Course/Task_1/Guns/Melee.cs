namespace DomashneeZadanie.Course.Task_1.Guns;

internal class Melee : Gun
{
    public override void Attack()
    {
        durability -= 1;
    }
}
