using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    [SerializeField] Bullet bullet;

    
    public override void Shoot()
    {
        if(Time.time - lastTimeShoot > rateOfFire)
        {
            Debug.Log("Bullet created");
            Bullet tmpBullet = Instantiate(bullet, tipOfTheWeapon.position, tipOfTheWeapon.rotation);
            tmpBullet.Setup(damage);
            lastTimeShoot = Time.time;
        }
        
    }
}
