using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Dependencies")]

    [Header("Settings")]
    [SerializeField] private float _playerSpeed;

    private Vector2 _moveValue;
    private Rigidbody2D _playerRigidBody;

    private void Awake()
    {
        _playerRigidBody = this.GetComponent<Rigidbody2D>();
    }

    //InputRead 
    void OnMove(InputValue value)
    {
        _moveValue = value.Get<Vector2>();
    }

    private void Update()
    {
        //ReadInput();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void ReadInput()
    {
        //Leer el teclado 
    }

    private void MoveCharacter()
    {
        _playerRigidBody.velocity = (10f * _moveValue * _playerSpeed * Time.deltaTime);
    }
}
