using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMeat : Element
{
    public DogMeat(int x, int y, CelluarMatrix celluarMatrix) : base(x, y, celluarMatrix) {
        DailyGain = new Resources(0,40,0);
        DieNextTurn = true;
       Name = "Dog Meat";
       Description = "Poor Fido didn't stand a chance";
    }
}

