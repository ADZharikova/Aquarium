using System;

namespace Aquarium
{
    internal class Fish
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int MaxAge { get; private set; }

        public Fish(string name, int age, int maxAge)
        {
            Name = name;
            Age = age;
            MaxAge = maxAge;
        }
        public void AddYaer()
        {
            ++Age;
        }
        public bool CheckAge()
        {
            return Age <= MaxAge;
        }
    }
}
