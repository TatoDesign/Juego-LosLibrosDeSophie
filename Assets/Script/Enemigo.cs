using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public float vidaUno;

    public void Da�o(float da�o)
    {

        vidaUno -= da�o;


        if (vidaUno <= 0)
        {
            Destroy(gameObject);
        }
    }
}
