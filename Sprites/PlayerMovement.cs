using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float Vertical;
    float Horizontal;
    public Rigidbody2D rb;
    public GameObject[] sides;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Horizontal, Vertical);
    }
}
