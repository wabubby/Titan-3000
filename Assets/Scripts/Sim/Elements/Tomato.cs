using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : Element
{
    public Tomato(int x, int y, CelluarMatrix celluarMatrix) : base(x, y, celluarMatrix) {
        DailyGain = new Resources(0, 250, 0);
       Name = "Tomato";
       Description = "The staple food of all people on Titan";
    }
}
