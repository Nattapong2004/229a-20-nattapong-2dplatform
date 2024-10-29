using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy,IShootable
{
    

    public void Start()
    {
        Init(100);
        Debug.Log("Crocodile : "+ Health);
    }

     public float attackRange;
    public float AttackRange { get { return attackRange; } set { attackRange = value; } }

     public Player player;

    [SerializeField]
     GameObject bullet;
    public GameObject Bullet { get { return bullet; }  set { bullet = value; } }

    [SerializeField]
      Transform bulletSpawnPoint;
    public Transform BulletSpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }

    [field: SerializeField] float bulletWaitTime;
     public float BulletWaitTime { get {  return bulletWaitTime; } set { bulletWaitTime = value; } }
      float bulletTimer;
    public float BulletTimer { get {  return bulletTimer; } set { bulletTimer = value; } }

    private void Update()
    {
        bulletTimer -= Time.deltaTime;

        Behavior();

        if(bulletTimer < 0)
        {
            bulletTimer = bulletWaitTime;
        }
    }

    public override void Behavior()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if(distance < attackRange)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && BulletWaitTime > BulletTimer ) 
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
}
