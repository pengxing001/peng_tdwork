using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage_Column : MonoBehaviour
{
    public GameObject PrefabColumn;
    public GameObject PrefabRoad;
    public AudioClip audioClip;

    private AudioSource audioSource;
    List<GameObject> listColumn = new List<GameObject>();
    List<GameObject> listRoad = new List<GameObject>();

    public float freq = 2;
    float freqTime = 0;
    int RoadCount = 0;
    void Start()
    {
        freqTime = 0;
        for(int i = 0; i < 20; i++)
        {
            CreateColumn(1);
        }

        Vector3 vec = Vector3.zero;
        for (int i = 0; i < 12; i++)
        {
            CreateRoad(vec);
            vec.z -= 1;
        }

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (freqTime <= 0)
        {
            CreateColumn();
            freqTime = freq;
        }
        else
        {
            freqTime -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound();
        }
    }

    void CreateColumn(int k = 0)
    {
        GameObject obj = null;  //����ѭ�������б��е�����
        for(int i = 0; i < listColumn.Count; i++)
        {
            if (listColumn[i].activeInHierarchy == false)   //�ҵ��б����б������obj�У�ѭ����ֹ
            {
                obj = listColumn[i];
                break;
            }
        }
        if(obj == null) //ѭ��������δ�ҵ���Ʒ����������Ʒ
        {
            obj = Instantiate(PrefabColumn);
            listColumn.Add(obj);    //����Ʒ��ӵ��б���

        }
        else
        {
            obj.SetActive(true);
        }
        obj.GetComponent<Column>().Reset(k);
    }

    void CreateRoad(Vector3 position)
    {
        if(RoadCount >= 12)
        {
            return;
        }
        GameObject obj = null;
        for (int i = 0; i < listRoad.Count; i++)
        {
            if (listRoad[i].activeInHierarchy == false)
            {
                obj = listRoad[i];
                break;
            }
        }
        if (obj == null)
        {
            obj = Instantiate(PrefabRoad);
            listRoad.Add(obj);

        }
        else
        {
            obj.SetActive(true);
        }
        obj.GetComponent<Roads>().Reset(position);
        RoadCount++;
    }

    public void SubRoadCount()
    {
        RoadCount--;
    }

    // ��������Ƭ�εķ���
    void PlaySound()
    {
        // ����AudioSource��clip����Ϊָ��������Ƭ��
        audioSource.clip = audioClip;

        // ��������Ƭ��

        Debug.Log("music~");
        audioSource.Play();
    }

    public void OnRegister()
    {
        Application.OpenURL("https://www.yuanshen.com/#/");
    }
}
