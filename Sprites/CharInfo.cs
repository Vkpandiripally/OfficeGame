using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharInfo : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    
    public GameObject health5;
    public GameObject health4;
    public GameObject health3;
    public GameObject health2;
    public GameObject health1;
    public GameObject health0;
    
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    private void FixedUpdate()
    {
        if (currentHealth >= 100 && currentHealth >= 81)
        {
            health5.SetActive(true);
            health4.SetActive(false);
            health3.SetActive(false);
            health2.SetActive(false);
            health1.SetActive(false);
            health0.SetActive(false);
        }
        if (currentHealth <= 80 && currentHealth >= 61)
        {
            health5.SetActive(false);
            health4.SetActive(true);
            health3.SetActive(false);
            health2.SetActive(false);
            health1.SetActive(false);
            health0.SetActive(false);
        }
        if (currentHealth <= 60 && currentHealth >= 41)
        {
            health5.SetActive(false);
            health4.SetActive(false);
            health3.SetActive(true);
            health2.SetActive(false);
            health1.SetActive(false);
            health0.SetActive(false);            
        }
        if (currentHealth <= 40 && currentHealth >= 21)
        {
            health5.SetActive(false);
            health4.SetActive(false);
            health3.SetActive(false);
            health2.SetActive(true);
            health1.SetActive(false);
            health0.SetActive(false);            
        }
        if (currentHealth <= 20 && currentHealth > 0)
        {
            health5.SetActive(false);
            health4.SetActive(false);
            health3.SetActive(false);
            health2.SetActive(false);
            health1.SetActive(true);
            health0.SetActive(false);            
        }
        if (currentHealth <= 0)
        {
            health5.SetActive(false);
            health4.SetActive(false);
            health3.SetActive(false);
            health2.SetActive(false);
            health1.SetActive(false);
            health0.SetActive(true);            
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //int a = 0;
        //add something here that deletes the character whenever it runs out of health
        Destroy(gameObject);

    }
}
