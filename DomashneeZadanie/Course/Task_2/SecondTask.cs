
using DomashneeZadanie.Course.Task_2.Sea_war;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DomashneeZadanie.Course.Task_2
{
    internal class SecondTask : CoursesTask
    {
        public override Task Invoke()
        {
            Release release = new Release();
            release.Game();
            return Task.CompletedTask;
        }
    }
}
