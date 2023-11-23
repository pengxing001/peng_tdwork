using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherDoor002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // �����ײ�����Ƿ���"Player"
        if (other.CompareTag("Player"))
        {
            // ����Open����
            GetComponent<Animation>().Play("DoorOther002_Open");
        }
    }

    // ���������뿪Colliderʱ����
    private void OnTriggerExit(Collider other)
    {
        // �����ײ�����Ƿ���"Player"
        if (other.CompareTag("Player"))
        {
            // ����Close����
            GetComponent<Animation>().Play("DoorOther002_Close");
        }
    }
}