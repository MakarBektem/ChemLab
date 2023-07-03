using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class burning : MonoBehaviour
{
    public GameObject myfire;

        private void OnMouseUp()
    {
        myfire.SetActive(true);
    }
}
