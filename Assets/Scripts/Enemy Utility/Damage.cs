using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script for the damage decreasing after each enemy you kill there for "violince is not the answer"

public class Damage : MonoBehaviour
{
    public static int damage = 10; // damage the player intially does to the enemy
    public static int kills = 0; // the # of kills (on/of the enemy) the player has intially

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage > 1) // If the damage is at "1" it cannot go any lower
        {
            damage = damage - kills; // each kill will result in less and less damage
        }

    }
}
