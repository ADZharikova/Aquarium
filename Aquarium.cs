using System;
using System.Collections.Generic;

namespace Aquarium
{
    internal class Aquarium
    {
        private List<Fish> _fishList = new List<Fish>();
        private int _i = 2;
        private int _j = 0;
        private int _index = -1;
        private bool _isLAlive;

        public void AddYaer()
        {
            if (_fishList.Count != 0)
            {
                foreach (var fish in _fishList)
                {
                    fish.AddYaer();
                }
            }
        }

        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (_fishList.Count != 0)
            {
                foreach (var fish in _fishList)
                {
                    Console.SetCursorPosition(60, _i);
                    Console.WriteLine($"{_i - 1}. Имя: {fish.Name}, возраст: {fish.Age} из {fish.MaxAge}");
                    ++_i;
                }
            }
            else
            {
                Console.SetCursorPosition(60, _i);
                Console.WriteLine("В аквауриуме пока нет рыб.");
            }
            _i = 2;
            Console.ResetColor();
        }

        public void AddFish(string name, int age, int maxAge)
        {
            if (_fishList.Count < 10)
            {
                foreach (var fish in _fishList)
                {
                    if (fish.Name.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("Такое имя уже занято.");
                        _j++;
                    }
                }
                if (_j == 0)
                {
                    _fishList.Add(new Fish(name, age, maxAge));
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("В аквауриме больше нет мест.");
                Console.ResetColor();
            }
            _j = 0;
        }

        public void CheckAge()
        {
                for (int i = 0; i < _fishList.Count; i++)
                {
                    _isLAlive = _fishList[i - _j].CheckAge();

                    if (!_isLAlive)
                    {
                        _fishList.RemoveAt(i-_j);
                        ++_j;
                    }
                }
            _j = 0;
        }

        public void RemoveFish(string name)
        {
            foreach (var fish in _fishList)
            {
                if (fish.Name.ToLower() == name.ToLower())
                {
                    _index = _fishList.IndexOf(fish);
                }
            }

            if (_index != 0)
            {
                _fishList.RemoveAt(_index);
            }
            else
            {
                Console.WriteLine("Такой рыбы нет.");
            }

            _index = -1;
        }
    }
}
