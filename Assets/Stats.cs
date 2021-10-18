using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    //stats of each character, for now, it's only health and speed;
    [SerializeField] public float maxHealth;
    [SerializeField] public float health;
    [SerializeField] public float speed;

    void Awake()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
