using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Gun", menuName ="Gun")]
public class Guns : ScriptableObject
{
    public new string name;
    //public Sprite artwork; (pendiente de uso)
    public float bulletamount;
    public float bulletspread;
    public float lifecost;
    public float damage;
    
}
