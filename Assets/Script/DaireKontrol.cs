using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaireKontrol : MonoBehaviour
{
    [SerializeField] float donmeHizi = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        DonmeHareketi();
    }

    private void DonmeHareketi()
    {
        transform.Rotate(0f, 0f, donmeHizi);
    }
}
