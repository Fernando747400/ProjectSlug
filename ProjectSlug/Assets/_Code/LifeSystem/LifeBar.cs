using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Image LifeBarSprite;

    public float maxLife;

    public float actualLife;


    void Start()
    {
        actualLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        //LifeBarSprite.fillAmount = actualLife / maxLife;        

      
       

        Debug.Log(actualLife);
    }


    public void Damage(float damage)
    {
        actualLife -= damage;
        if (actualLife <= 0) actualLife = 0;
    }

    public void Health(float health)
    {
        actualLife += health;
        if (actualLife >= maxLife) actualLife = maxLife;
    }

}
