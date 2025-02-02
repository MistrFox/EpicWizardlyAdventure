using System;
using Unity.Netcode;
using UnityEngine;

public class NetworkTransformTest : NetworkBehaviour
{

    public float speed = 100;
    private Transform obj;

    void Start()
    {
      obj = GetComponent<Transform>();
    }
   void Update()
   {

      if (IsOwner)
      {      
         obj = GetComponent<Transform>();    
         float h = Input.GetAxis("Horizontal");
         float v = Input.GetAxis("Vertical");

         Vector3 tempVect = new Vector3(h, v, 0);
         tempVect = tempVect.normalized * speed * Time.deltaTime;

         obj.transform.position += tempVect;
      }

   }
}