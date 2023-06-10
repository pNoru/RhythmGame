using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPooling : MonoBehaviour
{
    public GameObject notePrefeb, linePrefeb, bONPrefeb;
    Queue<GameObject> NotePool = new Queue<GameObject>(), LinePool = new Queue<GameObject>(), BONPool = new Queue<GameObject>(); //������Ʈ�� ���� ť
    public static ObjPooling instance = null;
    
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            for (int i = 0; i < 20; i++)
            {
                CreateNote(); //�ʱ⿡ ������Ʈ���� ������
            }

            for (int i = 0; i < 10; i++)  
            {
                CreateLine(); 
            }  //����

            for (int i = 0; i < 10; i++)
            {
                CreateBON(); 
            }  //��ư

        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    GameObject CreateNote() //�ʱ� OR ������Ʈ Ǯ�� ���� ������Ʈ�� ������ ��, ������Ʈ�� �����ϱ����� ȣ��Ǵ� �Լ�
    {
        GameObject newObj = Instantiate(notePrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }
    GameObject CreateLine() //����
    {
        GameObject newObj = Instantiate(linePrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }
    GameObject CreateBON() //��ư
    {
        GameObject newObj = Instantiate(bONPrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }


    public GameObject GetNote() //������Ʈ�� �ʿ��� �� �ٸ� ��ũ��Ʈ���� ȣ��Ǵ� �Լ�
    {
        if (NotePool.Count > 0) //���� ť�� �����ִ� ������Ʈ�� �ִٸ�,
        {
            GameObject objectInPool = NotePool.Dequeue();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
        else //ť�� �����ִ� ������Ʈ�� ���� �� ���� ���� ���
        {
            GameObject objectInPool = CreateNote();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
    }
    public void ReturnNoteToQueue(GameObject obj) //����� �Ϸ� �� ������Ʈ�� �ٽ� ť�� ������ ȣ�� �Ķ����->��Ȱ��ȭ �� ������Ʈ
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.NotePool.Enqueue(obj); //�ٽ� ť�� ����
    }


    public GameObject GetLine() //����
    {
        if (LinePool.Count > 0) 
        {
            GameObject objectInPool = LinePool.Dequeue();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
        else 
        {
            GameObject objectInPool = CreateLine();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
    }
    public void ReturnLineToQueue(GameObject obj) //����
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.LinePool.Enqueue(obj); 
    }


    public GameObject GetBON() //��ư
    {
        if (BONPool.Count > 0) 
        {
            GameObject objectInPool = BONPool.Dequeue();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
        else 
        {
            GameObject objectInPool = CreateBON();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
    }
    public void ReturnBONToQueue(GameObject obj) //��ư
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.BONPool.Enqueue(obj); 
    }


}
