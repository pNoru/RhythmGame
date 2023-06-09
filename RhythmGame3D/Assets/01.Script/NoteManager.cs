using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class NoteManager : MonoBehaviour
{
    public int N;
    public GameObject objectPrefeb;
    Queue<GameObject> ObjectPool = new Queue<GameObject>(); //������Ʈ�� ���� ť
    public static NoteManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            for (int i = 0; i < 50; i++)
            {
                CreateObject(); //�ʱ⿡ 50���� ������Ʈ�� ������
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    GameObject CreateObject() //�ʱ� OR ������Ʈ Ǯ�� ���� ������Ʈ�� ������ ��, ������Ʈ�� �����ϱ����� ȣ��Ǵ� �Լ�
    {
        GameObject newObj = Instantiate(objectPrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }
    public GameObject GetObject() //������Ʈ�� �ʿ��� �� �ٸ� ��ũ��Ʈ���� ȣ��Ǵ� �Լ�
    {
        if (ObjectPool.Count > 0) //���� ť�� �����ִ� ������Ʈ�� �ִٸ�,
        {
            GameObject objectInPool = ObjectPool.Dequeue();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
        else //ť�� �����ִ� ������Ʈ�� ���� �� ���� ���� ���
        {
            GameObject objectInPool = CreateObject();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
    }
    public void ReturnObjectToQueue(GameObject obj) //����� �Ϸ� �� ������Ʈ�� �ٽ� ť�� ������ ȣ�� �Ķ����->��Ȱ��ȭ �� ������Ʈ
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.ObjectPool.Enqueue(obj); //�ٽ� ť�� ����
        N += 1;
    }
}
