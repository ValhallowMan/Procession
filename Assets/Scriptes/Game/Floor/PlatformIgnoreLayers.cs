using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformIgnoreLayers : MonoBehaviour
{
    public float layerIgnoreTime = 0.5f;
    public void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 10, true);
        Invoke("IgnoreLayerCollisionOff", layerIgnoreTime);
    }

    private void IgnoreLayerCollisionOff()
    {
        Physics2D.IgnoreLayerCollision(9, 10, false);
    }
}
