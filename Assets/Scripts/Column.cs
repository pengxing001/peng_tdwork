using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{

    float speed = 5;
    void Start()
    {
        //Reset();    //ȷ��ÿ�ε������Ԥ���嶼���������ɳ�ʼλ��
    }

    public void Reset(int k = 0)//������Ʒλ�õĺ���,�в�������
    {
        float z = 100;
        if(k == 1)
        {
            z = Random.Range(-10, 80);
        }
        if(Random.Range(0, 100) < 50)   //���÷�֧�ṹʵ���м�ƫ����
        {
            transform.position = new Vector3(Random.Range(2, 20), 0, z);
        }
        else
        {
            transform.position = new Vector3(Random.Range(-20, -2), 0, z);
        }
        transform.localScale = new Vector3(1, Random.Range(1, 6), 1);
    }

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if(transform.position.z < Camera.main.transform.position.z - 1)
        {
            gameObject.SetActive(false);
        }
    }
}
