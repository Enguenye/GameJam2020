using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure : MonoBehaviour
{
    public GameObject Player;
    private CambiarColor cambiarColor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Placa1")
        {
            cambiarColor = FindObjectOfType<CambiarColor>();
            cambiarColor.CambioColor();
        }
        
    }
}
