using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DurdurmaMenu : MonoBehaviour
{

    [SerializeField] GameObject durMenusu;

    // Butona bas�nca oyunun timeScale'� 0 olucak ve oyun durucak ayn� zamanda durdurma paneli ekrana gelicek.
    public void Dur()
    {
        durMenusu.SetActive(true);
        Time.timeScale = 0f;

    }

  

    
}