using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcandle : MonoBehaviour
{
    public GameObject tExt;
    void OnMouseEnter()
    {
        tExt.SetActive(true);
    }

    void OnMouseExit()
    {
        tExt.SetActive(false);
    }
}
