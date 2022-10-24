using UnityEngine;

public class Enemy : MonoBehaviour, IGeneralTarget
{
    [SerializeField] private float LifeBar;

    private int _rutine;
    private float _chronometer;
    // private Animator animation;
    private int _direction;
    private float _speed_walk;
    private float _speed_run;
    private GameObject _target;
    public bool attacking;

    private float _visual_range;
    private float _attack_range;
    private GameObject _range;
    private GameObject _Hit;

    void Start()
    {
        // animation = GetComponent<Animator>();
        _target = GameObject.Find("Player");
    }

    void Update()
    {
        Behavours();
    }

    public void Behavours()
    {
        if (Mathf.Abs(transform.position.x - _target.transform.position.x) > _visual_range && !attacking)
        {
            // animation.SetBool("run", false);
            _chronometer += 1 * Time.deltaTime;
            if (_chronometer >= 4)
            {
                _rutine = UnityEngine.Random.Range(0, 2);
                _chronometer = 0;
                switch (_rutine)
                {
                    case 0:
                        // animation.SetBool("walk", false); 
                        break;
                    case 1:
                        _direction = UnityEngine.Random.Range(0, 2);
                        _rutine++;
                        break;
                    case 2:
                        switch (_direction)
                        {
                            case 0:
                                transform.rotation = Quaternion.Euler(0, 0, 0);
                                transform.Translate(Vector3.right * _speed_walk * Time.deltaTime);
                                break;
                            case 1:
                                transform.rotation = Quaternion.Euler(0, 180, 0);
                                transform.Translate(Vector3.right * _speed_walk * Time.deltaTime);
                                break;
                        }
                        // animation.SetBool("walk",true);
                        break;
                }
            }
            else
            {
                if (Mathf.Abs(transform.position.x - _target.transform.position.x) > _attack_range && !attacking)
                {
                    if (transform.position.x < _target.transform.position.x)
                    {
                        // animation.SetBool("walk", false);
                        // animation.SetBool("run", true);
                        transform.Translate(Vector3.right * _speed_run * Time.deltaTime);
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                        // animation.SetBool("attack", false);
                    }
                    else
                    {
                        // animation.SetBool("walk", false);
                        // animation.SetBool("run", true);
                        transform.Translate(Vector3.right * _speed_run * Time.deltaTime);
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                        // animation.SetBool("attack", false);
                    }
                }
                else
                {
                    if (!attacking)
                    {
                        if (transform.position.x < _target.transform.position.x)
                        {
                            transform.rotation = Quaternion.Euler(0, 0, 0);
                        }
                        else
                        {
                            transform.rotation = Quaternion.Euler(0, 180, 0);
                        }
                        // animation.SetBool("walk", false);
                        // animation.SetBool("run", false);
                    }
                }
            }
        }
    }


    private void Final_Animation()
    {
        // animation.SetBool("attack", false);
        attacking = false;
        _range.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void ColliderWeaponTrue() => _Hit.GetComponent<BoxCollider2D>().enabled = true;

    public void ColliderWeaponFalse() => _Hit.GetComponent<BoxCollider2D>().enabled = false;

    public void Dead()
    {
        // Here is the dead animation //
    }

     void IGeneralTarget.TakeDamage(float damage)
    {
        LifeBar -= (damage * 2);
        if (LifeBar <= 0)
        {
            Dead();
        }
    }
}
