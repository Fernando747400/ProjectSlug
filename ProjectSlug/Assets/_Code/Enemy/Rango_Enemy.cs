using UnityEngine;

public class Rango_Enemy : MonoBehaviour
{
    // public Animator ani;
    public Enemy enemy;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            // animation.SetBool("walk", false);
            // animation.SetBool("run", false);
            // animation.SetBool("attack", true);
            enemy.attacking = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}