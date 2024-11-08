using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Character,IShootable
{
    public void Start()
    {
        Init(100);
        bulletWaitTime = 1.0f;
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
         if (Input.GetButtonDown("Fire1") && BulletWaitTime >= BulletTimer ) 
        {
            GameObject ojb = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            Banana banana = ojb.GetComponent<Banana>();
            banana.Init(10,this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null) { OnHitWith(enemy); }

        Debug.Log($"{this.name} hit with {enemy.name} draling {enemy.DamageHit} damage.");
    }

    public void OnHitWith(Enemy enemy)
    {
        takeDamage(enemy.DamageHit);
    }
}

