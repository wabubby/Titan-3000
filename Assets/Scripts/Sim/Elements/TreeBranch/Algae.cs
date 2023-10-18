using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algae : Element
{
    public Algae(int x, int y, CelluarMatrix celluarMatrix) : base(x, y, celluarMatrix) {
        DailyGain = new Resources(1f, 0, 0);
        DieNextTurn = true;
        Name = "Algae";
        Description = "most basic oxygen producer and used to make farms.";
    }

}
