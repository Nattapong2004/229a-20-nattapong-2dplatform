using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character,IShootable
{
    public void Start()
    {
        Init(100);
        bulletWaitTime = 0.0f;
        bulletTimer = 1.0f;
    }

    private void Update()
    {
        Shoot();
    }
    [SerializeField]

    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }

    [SerializeField]
    Transform bulletSpawnPoint;
    public Transform BulletSpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }

    [field: SerializeField] float bulletWaitTime;
    public float BulletWaitTime { get { return bulletWaitTime; } set { bulletWaitTime = value; } }
    float bulletTimer;
    public float BulletTimer { get { return bulletTimer; } set { bulletTimer = value; } }

    public void Shoot()
    {
        if (bulletTimer < 0)
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
}

