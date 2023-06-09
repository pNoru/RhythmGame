using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPooling : MonoBehaviour
{
    public GameObject notePrefeb, linePrefeb, bONPrefeb;
    Queue<GameObject> NotePool = new Queue<GameObject>(), LinePool = new Queue<GameObject>(), BONPool = new Queue<GameObject>(); //오브젝트를 담을 큐
    public static ObjPooling instance = null;
    
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            for (int i = 0; i < 20; i++)
            {
                CreateNote(); //초기에 오브젝트들을 생성함
            }

            for (int i = 0; i < 10; i++)  
            {
                CreateLine(); 
            }  //라인

            for (int i = 0; i < 10; i++)
            {
                CreateBON(); 
            }  //버튼

        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    GameObject CreateNote() //초기 OR 오브젝트 풀에 남은 오브젝트가 부족할 때, 오브젝트를 생성하기위해 호출되는 함수
    {
        GameObject newObj = Instantiate(notePrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }
    GameObject CreateLine() //라인
    {
        GameObject newObj = Instantiate(linePrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }
    GameObject CreateBON() //버튼
    {
        GameObject newObj = Instantiate(bONPrefeb, instance.transform);
        newObj.gameObject.SetActive(false);

        return newObj;
    }


    public GameObject GetNote() //오프젝트가 필요할 때 다른 스크립트에서 호출되는 함수
    {
        if (NotePool.Count > 0) //현재 큐에 남아있는 오브젝트가 있다면,
        {
            GameObject objectInPool = NotePool.Dequeue();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
        else //큐에 남아있는 오브젝트가 없을 때 새로 만들어서 사용
        {
            GameObject objectInPool = CreateNote();

            objectInPool.gameObject.SetActive(true);
            objectInPool.transform.SetParent(null);
            return objectInPool;
        }
    }
    public void ReturnNoteToQueue(GameObject obj) //사용이 완료 된 오브젝트를 다시 큐에 넣을때 호출 파라미터->비활성화 할 오브젝트
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.NotePool.Enqueue(obj); //다시 큐에 넣음
    }


    public GameObject GetLine() //라인
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
    public void ReturnLineToQueue(GameObject obj) //라인
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.LinePool.Enqueue(obj); 
    }


    public GameObject GetBON() //버튼
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
    public void ReturnBONToQueue(GameObject obj) //버튼
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(instance.transform);
        instance.BONPool.Enqueue(obj); 
    }


}
