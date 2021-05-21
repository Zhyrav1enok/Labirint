using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Chet : MonoBehaviour
{

    public GameObject ball, spawn;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = spawn.transform.position;

    }
}
