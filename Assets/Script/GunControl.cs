using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    [SerializeField] KeyCode MoveUp;
    [SerializeField] KeyCode MoveDown;
    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveRight;
    [SerializeField] float speed;

    void Update() 
    {
        if (Input.GetKey(MoveUp))
        {
            transform.position += new Vector3 (0f,speed,0f) * Time.deltaTime;
        }
        if (Input.GetKey(MoveDown))
        {
            transform.position += new Vector3 (0f,-speed,0f) * Time.deltaTime;
        }
        if (Input.GetKey(MoveRight))
        {
            transform.position += new Vector3 (speed,0f,0f) * Time.deltaTime;
        }
        if (Input.GetKey(MoveLeft))
        {
            transform.position += new Vector3 (-speed,0f,0f) * Time.deltaTime;
        }
        
    }
}
