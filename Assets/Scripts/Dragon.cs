using UnityEngine;
class Dragon : Person
{


    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"I, the mighty dragon, have lost: {damageValue} hit points from a hunter`s shot!");
    }
}
