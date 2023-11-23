using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheak_gate : MonoBehaviour
{
    private void Start()
    {

    }

    // �����������Colliderʱ����
    private void OnTriggerEnter(Collider other)
    {
        // �����ײ�����Ƿ���"Player"
        if (other.CompareTag("Player"))
        {
            // ����Open����
            Debug.Log("Enter");
            GetComponent<Animation>().Play("Gate_Open");
        }
    }

    // ���������뿪Colliderʱ����
    private void OnTriggerExit(Collider other)
    {
        // �����ײ�����Ƿ���"Player"
        if (other.CompareTag("Player"))
        {
            // ����Close����
            Debug.Log("Exit");
            GetComponent<Animation>().Play("Gate_Close");
        }
    }
}

