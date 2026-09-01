using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healPoints;
    public bool IsBonus;

    public void Start()
    {
        
    }

    public override void Hit()
    {
        Destroy(gameObject);
        mapGenerator.player.Heal(healPoints);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
    }
}