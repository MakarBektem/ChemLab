using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap1 : MonoBehaviour
{
    private GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;
    public GameObject texT;

    void Update()
    {

        ob1 = GameObject.Find("NaOH+CuSO4(Clone)");
        var coord = ob1.transform.position;
        var head = ob1.transform.position - ob3.transform.position;
        var lenght = Mathf.Sqrt(head[0] * head[0] + head[1] * head[1] + head[2] * head[2]);
       
        if (lenght < 0.7 && Input.GetKey(KeyCode.E) )
            {
                ob2.transform.position = coord;
                Destroy(ob1);
            texT.SetActive(false);
            }
       
    }
}