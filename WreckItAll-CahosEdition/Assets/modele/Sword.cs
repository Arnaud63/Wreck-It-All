using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : IWeapon
{
    private int _dmg;
    public int dmg{
        get
        {
            return _dmg;
        }
    }

    public Sword(int damage)
    {
        _dmg = damage;
    }

}
