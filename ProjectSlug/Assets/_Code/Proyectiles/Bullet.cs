using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector] public float Speed;

    private Rigidbody2D _myRigidbody2D;

    private void Start()
    {
        _myRigidbody2D = this.GetComponent<Rigidbody2D>();
        _myRigidbody2D.AddForce(this.transform.forward * 1f);
    }
    private void Update()
    {
        _myRigidbody2D.velocity += (Vector2.up * Speed * Time.deltaTime);
    }
}
