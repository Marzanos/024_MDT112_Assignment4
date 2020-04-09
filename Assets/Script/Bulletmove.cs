using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmove : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.Translate(0f,0f,speed * Time.deltaTime);
        if(transform.position.z >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
