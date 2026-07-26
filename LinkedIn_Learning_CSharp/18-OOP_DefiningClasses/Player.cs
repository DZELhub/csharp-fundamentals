using System;

namespace Defining
{
    public class Player
    {
        string _name;
        int _level;
        int _health;
        bool _isAlive;

        public Player (string name, int level, int health, bool isAlive)
        {
            _name = name;
            _level = level;
            _health = health;
            _isAlive = isAlive;
        }

        public bool IsAlive()
        {   
           return _isAlive = _health > 0;
        }

        public string GetDescription()
        {
            return
                $"""
                {new string('=', 5)} PLAYER {new string('=', 5)}
                
                {"Name",-8}: {_name}
                {"Level", -8}: {_level}
                {"Health", -8}: {_health} 
                {"Is Alive", -8}: {IsAlive()}
                """;
        }
    }
}