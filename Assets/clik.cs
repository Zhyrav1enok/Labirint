using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clik : MonoBehaviour
{
    public GameObject Obj;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other )
    {
        print("я зашел");
        if (other.CompareTag("hand"))
        {
            print("я уже тут");
            anim.Play("pink1");

            Obj.GetComponent<Animator>().SetTrigger("Open");
        
        }
    }
}

