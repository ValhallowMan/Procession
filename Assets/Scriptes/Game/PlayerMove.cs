using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        UpDownOnStairs();
        KeyStorkes();
        PlayerLayer();
        PlayerMoving();
    }

    //------------------------------------------------------------------
    private bool canDoubleJump = true;
    private bool canUpDownOnStairs = false;
    private void PlayerLayer()
    {
        if (LayersChecker.isGround) { canDoubleJump = true; }
        if (LayersChecker.isStairs) { canUpDownOnStairs = true; } else { canUpDownOnStairs = false; }
    }
    //------------------------------------------------------------------
    bool stairsFlag = false;
    private void KeyStorkes()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { PlayerJump(); }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { PlatformDown(); }
        if (Input.GetKeyDown(KeyCode.E)) { stairsFlag = !stairsFlag; }
    }
    //------------------------------------------------------------------
    public float moveSpeed;
    private void PlayerMoving()
    {
        float moveVelocity = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVelocity * moveSpeed, rb.velocity.y);
    }
    //------------------------------------------------------------------
    public float jumpForce = 40f;
    public float doubleJumpVelocity = 10f;

    private void PlayerJump() // Идея реализовать через событие
    {
        if (LayersChecker.isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce);
        }
        if (!LayersChecker.isGround && canDoubleJump)
            {
                rb.velocity = new Vector2(0, doubleJumpVelocity);
                canDoubleJump = false;
            }
    }
    //------------------------------------------------------------------
    public void PlatformDown()
    {
            GetComponent<PlatformIgnoreLayers>().Start();
    }
    //------------------------------------------------------------------
    public float UpDownSpeed = 1.5f;
    public void UpDownOnStairs()
    {
        if (canUpDownOnStairs && stairsFlag)
        {
            canDoubleJump = true;
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.velocity = new Vector2(0, Input.GetAxis("Vertical") * UpDownSpeed);
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            stairsFlag = false;
        }
    }
}
