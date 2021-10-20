using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Start()
    {
        Shoot();
    }


    void Update()
    {
       
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, transform);
    }
}

