using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayersChecker : MonoBehaviour
{
    public static bool isGround, isStairs;
    public Transform GroundCheck, CheckLadder;
    public float checkdRadius = 0.5f;
    public LayerMask Ground, LadderMask;
    private void Update()
    {
        isGround = Physics2D.OverlapCircle(GroundCheck.position, checkdRadius, Ground);
        isStairs = Physics2D.OverlapCircle(CheckLadder.position, checkdRadius, LadderMask);
    }
}
