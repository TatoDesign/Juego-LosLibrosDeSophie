using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Transition : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        gameObject.SetActive(false);

    }


    public void Transicion()
    {
        animator.SetTrigger("Pasar");
    }
}
