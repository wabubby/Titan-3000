using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFarm : Element
{
    public DogFarm(int x, int y, CelluarMatrix celluarMatrix) : base(x, y, celluarMatrix) {
        AddCardToPool(ElementType.DogMeat);
       Name = "Dog Farm";
       Description = "Optimized for maximum war crimes";
    }

}