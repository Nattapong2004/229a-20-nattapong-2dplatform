using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable 
{
    GameObject Bullet { get; set; }

     Transform BulletSpawnPoint {  get; set; }

      float BulletWaitTime {  get; set; }

      float BulletTimer {  get; set; }

    void Shoot();
}

