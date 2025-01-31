using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    void Update()
    {
        float Rotate_index = 60 * Time.deltaTime;
        transform.Rotate(Rotate_index, Rotate_index, Rotate_index);
    }
}
