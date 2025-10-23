using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Debug.Log("What is this attached to: " + gameObject.name);
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
