using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MiniMap : MonoBehaviour
{
    public GameObject haper;
    public GameObject smilMap;
    public Transform arr;

    private void Update()
    {
        //���Ͻ�С��ͼ

        haper.transform.position = transform.position;
        //С��ͼ�ı�������  = haper ��������* ��ͼ����     
        smilMap.transform.localPosition = new Vector3(haper.transform.localPosition.x * -2010, haper.transform.localPosition.z * -2565, 1);
        //���� С��ͼ�ϼ�ͷ����ת
        arr.localEulerAngles = new Vector3(0, 0, 360 - transform.eulerAngles.y);
        //Debug.Log("11");
    }
}
