using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb2D;
    private Vector2 velocity;
    private Animator anim;

  
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetBool("isRunning", false);

        float h = Input.GetAxisRaw("Horizontal");

        float v = Input.GetAxisRaw("Vertical");

        //Debug.Log(h);
        //Debug.Log(v);

        velocity = new Vector2(h, v).normalized * speed;

        Debug.Log("velocity: " + velocity);
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + velocity *  Time.fixedDeltaTime);

    }
}
