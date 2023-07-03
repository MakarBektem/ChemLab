using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desklamp : MonoBehaviour
{
    private Light lamp;
    void Start()
    {
        lamp = GetComponent<Light>();    
    }

    private void OnMouseDown()
    {
        lamp.enabled = !lamp.enabled;

    }
}
