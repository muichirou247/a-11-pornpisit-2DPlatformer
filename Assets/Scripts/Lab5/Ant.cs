using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    private Vector2 velocity;
    private Transform[] movePoints;

    public override void Behavior()
    {
        Debug.Log("Ant");
    }
}
