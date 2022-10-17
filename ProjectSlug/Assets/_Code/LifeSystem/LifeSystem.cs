using System;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    private float _lifeCurrent;
    private float _lifeMax;

    public float LifeCurrent { get { return _lifeCurrent; } set { _lifeCurrent = value; ClampHealth(); } }
    public float LifeMax { get { return _lifeMax; }  set { _lifeMax = value; } }

    public event Action DamageEvent;
    public event Action HealthEvent;

    public void Damage(float damageValue)
    {
        _lifeCurrent -= damageValue;
        ClampHealth();
        DamageEvent?.Invoke();
    }

    public void Heal(float healValue)
    {
        _lifeCurrent += healValue;
        ClampHealth();
        HealthEvent?.Invoke();
    }
    
    private void ClampHealth()
    {
        _lifeCurrent = Math.Clamp(_lifeCurrent, 0, _lifeMax);
    }
}
