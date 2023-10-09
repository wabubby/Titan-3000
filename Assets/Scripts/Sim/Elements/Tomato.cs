using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : Element
{
    public Tomato(int x, int y, CelluarMatrix celluarMatrix) : base(x, y, celluarMatrix) {
       Name = "Tomato";
       Description = "The staple food of all people on Titan";
    }
}