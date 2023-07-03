using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showmethod : MonoBehaviour
{
    public GameObject Txt;
    void Update()
    {
        var i = 0;
        if (Input.GetKey(KeyCode.F) && i == 0)
        {
            Txt.SetActive(true);
            i = 1;
        }
        else
        {
            Txt.SetActive(false);
            i = 0;
        }
    }
}
