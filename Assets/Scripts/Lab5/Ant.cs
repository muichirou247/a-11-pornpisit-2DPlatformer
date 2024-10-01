using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Init(15);   
        Debug.Log($"ant = {Health}");

        Behavior();
        }

        private void FixedUpdate()
        {

        Behavior();

        }
        

    public override void Behavior()
{
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            Flip();
        }

        if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
        }

           }
        public void Flip()
        {
        velocity.x *= -1;

        Vector2 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;
        }

}

