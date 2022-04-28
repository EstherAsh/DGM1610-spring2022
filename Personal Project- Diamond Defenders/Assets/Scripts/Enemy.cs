using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Health stats")]
    public int currHP;
    public int maxHP;

    public float enemySpeed;

    [Header("EnemyShoot")]
    public GameObject enemyProjectile;
    public int enemyDamage;
    public float shotDelay;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();

    }

    void Fire()
    {
        if(shotDelay <= 0)
        {
            Instantiate(enemyProjectile,new Vector3(transform.position.x,transform.position.y, 2),Quaternion.identity);
            shotDelay = Random.Range(1,3);
            //^added slight randomization to make it feel ''alive''
        }
        else
        {
            shotDelay -=Time.deltaTime;
            //every time minus shot delay
        }
    }

    public void TakeDamage(int damage)
    {
        currHP -= damage;
        
        if (currHP <=0 )
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
