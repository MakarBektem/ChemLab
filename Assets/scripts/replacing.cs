using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replacing : MonoBehaviour
{
    public GameObject ob2;      //������, �� ������� ���������� ��������
    public GameObject[] obs1;   //������� �������� ��������
    public GameObject[] obs3;
    public GameObject teXt;     //����� "��������� �������� ���� � �����"
    public GameObject teXt2;    //����� "������� �"
    public GameObject texT3;    //����� "��������� � ����"

    void Update()
    {
        
        for (int i = 0; i < obs1.Length; i++)
        {
            for (int e = 0; e < obs3.Length; e++)
            {
            var head = obs1[i].transform.position - obs3[e].transform.position;                 //�������� ���� ��������� ���������� ��������
            var lenght = Mathf.Sqrt(head[0] * head[0] + head[1] * head[1] + head[2] * head[2]); //���������� ����� ���������
            if (lenght < 0.7)
            {
                teXt.SetActive(false);      //����������� ������� ������ � ��������� ������� � ������ ��������� ��������
                teXt2.SetActive(true);
            }
            if (lenght < 0.7 && Input.GetKey(KeyCode.E))
            {
                Replace(obs1[i], ob2, obs3[e]);     //������ �������1 � ������������ �������� ��������
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
