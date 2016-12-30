using System;

namespace PersonDirectory
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            if (pers != null)
                pers.Age = age;
        }
    }
}
