using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // should be const!!!!!!!!!!!!!
    [SerializeField] public static float hpMax = 100;
    [SerializeField] public static float capacityMax = 50;
    //
    public static float hpPlayer;
    public static float garbageCapacity;
    public static float garbageEaten;

}
