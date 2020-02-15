using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int MaxHealth = 100;
    public AudioClip deathsfx;
    public int currentHealth;
    public BossSpawner bossspawn;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }
    void OnTriggerEnter2D()
    {
        Debug.Log("trigger");

        TakeDamage(10);


        Dead();
        

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void Dead()
    {
        if(currentHealth == 0)
        {
            Destroy(gameObject);
            AudioManager.Instance.PlaySFX(deathsfx, 3.0f);
            Debug.Log("Destory");
            bossspawn.numbereneimes -= 1;
            bossspawn.SpawnBoss();

        }
        



    }
}
