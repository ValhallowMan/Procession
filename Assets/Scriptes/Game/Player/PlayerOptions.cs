using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOptions : MonoBehaviour
{
    public static float startHealthPoint = 1f;
    public static float startArmorPoint = 1f;
    public float healthPoint;
    public float armorPoint;
    public void Start()
    {
        healthPoint = startHealthPoint;
        armorPoint = startArmorPoint;
    }
}
