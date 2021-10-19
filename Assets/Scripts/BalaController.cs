using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float speedBala =10f;
    public Vector3 direction = Vector3.right;
    public float damageBala = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedBala * Time.deltaTime * direction);
    }
}
