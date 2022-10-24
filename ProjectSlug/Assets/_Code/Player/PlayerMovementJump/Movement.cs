using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Movement Variables")]
    private Rigidbody2D _rb;
    private Vector2 moveVector2;
    public float jumpDistance;
    public float moveSpeed;

    [Header("Gound Check")]
    [SerializeField] bool isGrounded;
    public Transform groundSpot;
    public LayerMask groundLayer;

    private float normalGravity;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        normalGravity = _rb.gravityScale;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector2=context.ReadValue<Vector2>();   
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed&&isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpDistance);
        }
    }
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundSpot.position, 0.1f, groundLayer);
    }

    private void FixedUpdate()
    {
        _rb.velocity=new Vector2(moveVector2.x * moveSpeed, _rb.velocity.y);
    }

}
