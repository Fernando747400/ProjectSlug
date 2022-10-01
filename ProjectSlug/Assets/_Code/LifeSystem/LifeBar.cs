using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [Header("Dependendices")]
    [SerializeField] private Image _lifeBarImage;

    [Header("Settings")]
    [SerializeField] private float _maxLife;

    private float _currentLife;
    public float MaxLife { get => _maxLife; set => _maxLife = value; } 

    void Start()
    {
        _currentLife = _maxLife;
        //TODO healthEvent += UpdateLifeBar;
    }

    public void RecieveDamage(float damage)
    {
        _currentLife -= damage;
        Mathf.Clamp(_currentLife, 0, MaxLife);
    }

    public void Heal(float health)
    {
        _currentLife += health;
        Mathf.Clamp(_currentLife, 0, MaxLife);
    }

    private void UpdateLifeBar() // This method needs to be susbcribed to the life event. 
    {
        _lifeBarImage.fillAmount = Mathf.InverseLerp(0, _maxLife, _currentLife);
    }

}
