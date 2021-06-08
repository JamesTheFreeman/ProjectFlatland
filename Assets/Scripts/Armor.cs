using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "new Armor", menuName = "Items/Armor")]
public class Armor : Item
{
    public int attack;
    public int defense;

    public void setAttack(int newAttack)
    {
        attack = newAttack;
    }

    public void setDefense(int newDefense)
    {
        defense = newDefense;
    }

}
