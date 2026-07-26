namespace Defining
{
    public class Character
    {
        string _name;
        string _className;
        int _strength;
        int _health;
        int _damage;

        public Character (string name, string className, int strength, int health, int damage)
        {
            _name = name;
            _className = className;
            _strength = strength;
            _health = health;
            _damage = damage;
        }

        public int AttackPower ()
        {
            Random random = new Random();
            int octahedralDice = random.Next(1,9);
            int strBonus = (_strength - 10) / 2;
            return _damage = strBonus + octahedralDice;
        }

        public string GetDescription()
        {
            return
            $"""
            {new string('=', 5)} CHARACTER {new string('=', 5)}

            {"Name",-10}: {_name}
            {"Class", -10}: {_className}
            {"Strength", -10}: {_strength}
            {"Health", -10}: {_health}
            {"Damage", -10}: {AttackPower()}
            """;
        }
    }
}