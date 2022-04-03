using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class TouchController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    private bool moveleft, moveRight;
   
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        moveleft = false;
        moveRight = false;
    }

    public void MoveLeft()
    {
        moveleft = true;
    }
    public void MoveRight()
    {
        moveRight = true;
    }
    // Update is called once per frame
    void Update()
    {
       if (moveleft)
        {
            rb.velocity = new Vector2(-moveSpeed, 0f);
        }
        if (moveRight)
        {
            rb.velocity = new Vector2(moveSpeed, 0f);
        }
    }
    
    public void StopMoving()
    {
        moveleft=false;
        moveRight=false;
        rb.velocity = Vector3.zero;
    }
   
}
