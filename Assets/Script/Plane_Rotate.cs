using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Rotate : MonoBehaviour
{
    [Range(0,50)]
    public int speed;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    
}
