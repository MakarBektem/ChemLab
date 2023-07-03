using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replacing : MonoBehaviour
{
    public GameObject ob2;      //объект, на который заменяются исходные
    public GameObject[] obs1;   //массивы исходных объектов
    public GameObject[] obs3;
    public GameObject teXt;     //текст "поднесите реагенты друг к другу"
    public GameObject teXt2;    //текст "нажмите Е"
    public GameObject texT3;    //текст "поднесите к огню"

    void Update()
    {
        
        for (int i = 0; i < obs1.Length; i++)
        {
            for (int e = 0; e < obs3.Length; e++)
            {
            var head = obs1[i].transform.position - obs3[e].transform.position;                 //разность всех координат заменяемых объектов
            var lenght = Mathf.Sqrt(head[0] * head[0] + head[1] * head[1] + head[2] * head[2]); //расстояние между объектами
            if (lenght < 0.7)
            {
                teXt.SetActive(false);      //деактивация первого текста и активация второго в случае сближения объектов
                teXt2.SetActive(true);
            }
            if (lenght < 0.7 && Input.GetKey(KeyCode.E))
            {
                Replace(obs1[i], ob2, obs3[e]);     //замена объекта1 с уничтожением исходных объектов
                teXt2.SetActive(false);
                texT3.SetActive(true);
            }
            }
        }
        
        void Replace(GameObject obj1, GameObject obj2, GameObject obj3)
        {
            Instantiate(obj2, obj1.transform.position, Quaternion.identity);
            Destroy(obj1);
            Destroy(obj3);
        }
    }
}
