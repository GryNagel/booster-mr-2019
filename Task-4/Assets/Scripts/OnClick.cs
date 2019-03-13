using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    private bool toggleColor = false;
    public void move()
    {
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }

    public void changeColor()
    {
        if (toggleColor)
        {
            Material material = GetComponent<Renderer>().material;
            material.SetColor("_Color", Color.red);
            toggleColor = false;
        }
        else
        {
            Material material = GetComponent<Renderer>().material;
            material.SetColor("_Color", Color.blue);
            toggleColor = true; 
        }  
    }
}
