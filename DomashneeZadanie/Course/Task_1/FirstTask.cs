
using DomashneeZadanie.Course.Task_1.Guns;

namespace DomashneeZadanie.Course.Task_1
{
    internal class FirstTask : CoursesTask
    {
        public override Task Invoke()
        {
            Gun gun2 = new Knife();

            bool coundition = true;

            Person person = new Person();
            person.Reload();
            person.Attack();
            person.ChangeWeapon(gun2);
            person.Attack();

            while (coundition)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        person.Reload();
                        break;
                    case "2":
                        person.Attack();
                        break;
                    case "3":
                        person.ChangeWeapon(gun2);
                        break;
                    case "4":
                        person.ChangeWeapon(new Kalash());
                        break;

                }

            }
            return Task.CompletedTask;
        }
    }
}
