using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;

    private void Start()
    {
        myRenderer = GetComponent<Renderer>();

        originalColor = myRenderer.material.color;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EndPoint"))
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
;        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("EndPoint"))
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
            ;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("EndPoint"))
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }
}
