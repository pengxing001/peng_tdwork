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
        //右上角小地图

        haper.transform.position = transform.position;
        //小地图的本地文章  = haper 本子坐标* 地图长度     
        smilMap.transform.localPosition = new Vector3(haper.transform.localPosition.x * -2010, haper.transform.localPosition.z * -2565, 1);
        //设置 小地图上箭头的旋转
        arr.localEulerAngles = new Vector3(0, 0, 360 - transform.eulerAngles.y);
        //Debug.Log("11");
    }
}
