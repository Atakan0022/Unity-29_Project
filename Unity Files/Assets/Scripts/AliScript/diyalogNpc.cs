using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diyalogNpc : MonoBehaviour
{
    public GameObject diyalogKutusu;

    float G�r�nt�lemeZamanlay�c�s�;

    public float G�r�nt�lemeZaman� = 8.0f;


    public void DiyalogAc()
    {
        G�r�nt�lemeZamanlay�c�s� = G�r�nt�lemeZaman�;

        diyalogKutusu.SetActive(true);
    }


    void Start()
    {

        G�r�nt�lemeZamanlay�c�s� = -2.0f;

        diyalogKutusu.SetActive(false);
        
    }


    void Update()
    {
        if (G�r�nt�lemeZamanlay�c�s� >= 0)
        {
            G�r�nt�lemeZamanlay�c�s� -= Time.deltaTime;
            
            if (G�r�nt�lemeZamanlay�c�s� < 0)
            {
                diyalogKutusu.SetActive(false);
            }
        }
    }

   

}