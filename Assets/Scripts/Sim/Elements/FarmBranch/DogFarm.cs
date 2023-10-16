using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFarm : Element
{
    public DogFarm(int x, int y, CelluarMatrix celluarMatrix) : base(x, y, celluarMatrix) {
       AddCardToPool(ElementType.Meat);

       Name = "Dog Farm";
       Description = "Herd Alien Dogs!";
    }

}