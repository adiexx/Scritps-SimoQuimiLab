using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class a : MonoBehaviour
{

public float vol = 1;
public GameObject aa;
private Renderer volume;





   void Awake(){

    aa.GetComponent<Renderer>().material = volume;
    volume.material.SetFloat("_volume", vol);
        
   }

   private void OnCollisionEnter(Collision collision)
   {
    switch (collision.gameObject.tag)
    {
        case "pia":
         Destroy(collision.gameObject);
          break;

        case "game" : 
          break;
    
    }

   }
}

