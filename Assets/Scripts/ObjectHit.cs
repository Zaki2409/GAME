using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
        
    {
         Debug.Log("wall ahead , please drive carefully");
        

        if (collision.gameObject.tag == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.red;
        }
       
    }
        
    }

