using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;
    public InputAction playerControl;
    

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable()
    {
        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }
    // Update is called once per frame
    void Update()
    {
       
        moveDirection=playerControl.ReadValue<Vector2>();   
    }

    private void FixedUpdate()
    {
        rb.velocity=new Vector2(moveDirection.x*moveSpeed, moveDirection.y*moveSpeed);
    }
}
