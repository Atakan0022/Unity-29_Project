using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanBar� : MonoBehaviour
{
    //Can bar�n�n hareket etmesi i�in slider olu�turuyoruz.
    public Slider canBar�;
    public Health oyuncuCan�;

    public void CanDegeriniGetir(int can)
    {
        canBar�.value = can;
    }



    private void Start()
    {
        oyuncuCan� = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        canBar� = GetComponent<Slider>();

        //Can bar�m�zdaki de�erleri karakterin de�erlerine ayarl�yoruz.
        canBar�.maxValue = oyuncuCan�.maxHealth;
        canBar�.value = oyuncuCan�.maxHealth;
    }

    
}
