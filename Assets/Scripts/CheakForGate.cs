using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheakForGate : MonoBehaviour
{
    public GameObject gate1;
    public GameObject gate2;

    private Animator gate1Animator;
    private Animator gate2Animator;

    private void Start()
    {
        // ��ȡgate1��gate2��Animator���
        gate1Animator = gate1.GetComponent<Animator>();
        gate2Animator = gate2.GetComponent<Animator>();
    }

    // ����ײ��ʼʱ����
    private void OnCollisionEnter(Collision collision)
    {
        // �����ײ�Ķ����Ƿ�ΪPlayer
        if (collision.gameObject.CompareTag("Player"))
        {
            // ����gate1��gate2��open����
            PlayOpenAnimation();
        }
    }

    // ����ײ����ʱ����
    private void OnCollisionExit(Collision collision)
    {
        // �����ײ�Ķ����Ƿ�ΪPlayer
        if (collision.gameObject.CompareTag("Player"))
        {
            // ����gate1��gate2��close����
            PlayCloseAnimation();
        }
    }

    private void PlayOpenAnimation()
    {
        // ����gate1��LeftOpen����
        if (gate1Animator != null)
        {
            gate1Animator.Play("LeftOpen");
        }

        // ����gate2��RightOpen����
        if (gate2Animator != null)
        {
            gate2Animator.Play("RightOpen");
        }
    }

    private void PlayCloseAnimation()
    {
        // ����gate1��LeftClose����
        if (gate1Animator != null)
        {
            gate1Animator.Play("LeftClose");
        }

        // ����gate2��RightClose����
        if (gate2Animator != null)
        {
            gate2Animator.Play("RightClose");
        }
    }
}


