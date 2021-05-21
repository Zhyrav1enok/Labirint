using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ball : MonoBehaviour
{

    private Throwable throwable;
    private Interactable interactable;
    public SteamVR_Behaviour_Pose Pos = null; // Хранит правый контроллер - поле назначается из редактора Unity
    private SteamVR_Action_Boolean buttonGrabPinch = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
    private SteamVR_Action_Boolean buttonInteractUI = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("InteractUI");
    private SteamVR_Action_Boolean buttonGrabGrip = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabGrip");
    public SteamVR_Input_Sources m_Source = SteamVR_Input_Sources.RightHand;
    public SteamVR_Action_Boolean m_Clik = null;


    public Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //if (Input.GetMouseButton(3) button GrabPinch.GetStateDown(pos.inputSurce)*/)
        //{
        //    //rb.AddForce(0, 5f, 0);
        //    rb.velocity += transform.forward * 2f;
        //}

    }
    public void Prof() 
    {
        rb.AddForce(0, 5f, -3f, ForceMode.Impulse);
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if (Input.GetMouseButton(2) || m_Clik.GetStateDown(m_Source))
    //    {
            
    //        rb.AddForce(0, 5f, 3f, ForceMode.Impulse);
    //        //rb.velocity += transform.forward * 2f;
    //        print("No longer in contact with " + collision.transform.name);
    //    }
    //}

}

