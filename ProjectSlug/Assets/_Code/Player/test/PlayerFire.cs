using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [Header("Dependecies")]
    [SerializeField] private GameObject _bulletPrefab;

    [Header("Settings")]
    [SerializeField] private float _bulletSpeed;

  void OnFire()
    {
        GameObject bullet = Instantiate(_bulletPrefab, this.transform.position + this.transform.forward * 2, Quaternion.identity, this.transform);
        bullet.transform.parent = null;
        bullet.GetComponent<Bullet>().Speed = _bulletSpeed;
    }
}
