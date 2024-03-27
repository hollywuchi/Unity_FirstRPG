using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    Rigidbody rig;

    public float Speed;
   
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Move_();
    }
    void Move_()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rig.AddForce(x * Speed,0,y * Speed);
    }
}
