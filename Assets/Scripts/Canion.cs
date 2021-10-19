using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    public GameObject balaPrefab;

    void Start()
    {
        Disparo();
    }


    void Update()
    {
       
    }

    public void Disparo()
    {
        Instantiate(balaPrefab, transform);
    }
}

