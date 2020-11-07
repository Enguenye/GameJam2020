using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    public Sprite Color1;
    public Sprite Color2;
    public Sprite ColorGrid;
    bool Color = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambioColor()
    {
        if(Color == true)
        {
            ColorGrid = this.GetComponent<SpriteRenderer>().sprite = Color1;
            Color = false;
        }
        else
        {
            ColorGrid = this.GetComponent<SpriteRenderer>().sprite = Color2;
            Color = false;
        }
    }
}
