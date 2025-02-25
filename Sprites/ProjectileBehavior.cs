using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4.5f;

    // Update is called once per frame
    void Update()
    {
        //transform.position += -transform.right * Time.deltaTime * Speed;
    }

    public GameObject hitEffect; //PUT ANIMATION FOR WHEN PROJECTILE HITS WALL

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //THESE 2 LINES ARE TO INSTANTIATE THE EFFECT AND THEN DELETE IT AFTER 5 SECONDS
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);

        Destroy(gameObject);
    }
}
