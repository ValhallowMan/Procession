using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOptions : MonoBehaviour
{
    public float bulletHealthDamage;
    public float bulletArmorDamage;

   public void PistolBullet()
    {
        bulletArmorDamage = 1f;
        bulletHealthDamage = 5f;
    }

    public void ShotgunBullet()
    {
        bulletArmorDamage = 1f;
        bulletHealthDamage = 15f;
    }
}
