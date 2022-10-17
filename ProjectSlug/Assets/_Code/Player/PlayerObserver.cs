using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObserver : MonoBehaviour
{
    public static PlayerObserver Instance { get; private set; }

    [SerializeField] private LifeSystem _lifeSystem;
    //[SerializeField] private GunSystem _gunSystem; TODO Shika

    private void Awake()
    {
        Instance = this;
    }

    private void SubscribeToEvents()
    {
        //_gunSystem.OnFireEvent += _lifeSystem.Damage; TODO shika
    }


}
