using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KarakterDiyalogAcma : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
        

    }
  
    // karakter ve diyalog kuraca��m�z gameObject �arp���nca diyalog a��lcak.
    void OnCollisionEnter2D(Collision2D d)
     {
        diyalogNpc karakter = d.collider.GetComponent<diyalogNpc>();

        if (karakter != null)
        {
            karakter.DiyalogAc();
            // Buraya Dede korkutla konu�up de�i�ecek olan statlar eklenecek. Her g�rev i�in farkl� oluca��ndan bu k�s�m bo�.
        }
             
       

    }  

}
