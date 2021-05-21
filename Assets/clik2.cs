using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clik2 : MonoBehaviour
{
    public GameObject Obj;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        print("я зашел");
        if (other.CompareTag("hand"))
        {
            print("я уже тут");
            anim.Play("pink2");

            Obj.GetComponent<Animator>().SetTrigger("Open2");

        }
    }
}
