using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    private void Update()
    {
        if (this.transform.position.y >= -20)
        {
            transform.Translate(0, -100 * Time.deltaTime, 0);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
