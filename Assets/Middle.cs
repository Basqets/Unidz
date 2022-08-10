using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GetMax("1 2 34 4 5 6 7 8 2 1017 321 87"));    //1
        Debug.Log(CounterMethod(10, 3));                        //2
        Debug.Log(EvenSum(new int[] { 1, 2, 3, 3 }));           //3

        Warrior warrior1 = new Warrior("Steve", 1000, 10, 600);
        Warrior warrior2 = new Warrior("Mike", 800, 260, 360);

        Arena arena = new Arena(warrior1, warrior2);
        arena.Fight();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetMax(string numbers)
    {
        string[] numbs = numbers.Split(new char[] { ' ' });
        int max = int.Parse(numbs[0]);

        foreach (string number in numbs)
        {
            if (int.Parse(number) > max)
            {
                max = int.Parse(number);
            }
        }
        return max;
    }

    string CounterMethod(int n, int x)
    {
        string numbs = "";
        for (int i = 0; i <= n; i++)
        {
            if (i % x == 0)
            {
                numbs += i.ToString() + " ";
            }
        }
        return numbs;
    }

    int EvenSum(int[] numbers)
    {
        int sum = 0;
        foreach(int number in numbers)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }
        if(sum == 0) {
            return -1;
        }
        return sum;
    }
}

public class Warrior
{
    private string _name;
    private float _hp;
    private float _minDamage;
    private float _maxDamage;

    public Warrior(string name, float hp, float minDamage, float maxDamage)
    {
        _name = name;
        _hp = hp;   
        _minDamage = minDamage;
        _maxDamage = maxDamage;
    }
    public void Attack(Warrior enemy)
    {
        float damage = Random.Range(_minDamage, _maxDamage);
        enemy._hp -= damage;
        Debug.Log($"Warrior {_name} attack opponent {enemy._name}. Damaged {damage}. {enemy._name} HP left: {enemy._hp}");
        if (enemy._hp <= 0)
        {
            Debug.Log($"Warrior {_name} beat the opppent {enemy._name}, Warrior {_name} HP left {_hp}");
        }
    }

    public void Hello()
    {
        Debug.Log($"Warrior: {_name}, Hp: {_hp} greeting opponent");
    }

    public bool Alive()
    {
        if (_hp > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Arena
{
    private Warrior _firstWarrior;
    private Warrior _secondWarrior;

    public Arena(Warrior firstWarrior, Warrior secondWarrior)
    {
        _firstWarrior = firstWarrior;
        _secondWarrior = secondWarrior;
    }
    public void Fight()
    {
        _firstWarrior.Hello();
        _secondWarrior.Hello();

        while (_firstWarrior.Alive() && _secondWarrior.Alive())
        {
            _firstWarrior.Attack(_secondWarrior);
            if (_secondWarrior.Alive())
            {
                _secondWarrior.Attack(_firstWarrior);
            }
        }
    }
}
