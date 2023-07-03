using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour
{
    private GameObject ob1;
    public GameObject ob2;
    public GameObject[] obs3;

    void Update()
    {
        ob1 = GameObject.Find("NaOH+FF(Clone)");  //поиск объекта на сцене
        var coord = ob1.transform.position;
        for (int i = 0; i < obs3.Length; i++)
        {
            var head = ob1.transform.position - obs3[i].transform.position;
            var lenght = Mathf.Sqrt(head[0] * head[0] + head[1] * head[1] + head[2] * head[2]);

            if (lenght < 0.7 && Input.GetKey(KeyCode.E))
            {
                ob2.transform.position = coord;
                Destroy(ob1);
                Destroy(obs3[i]);
                break;
            }
        }
    }
}