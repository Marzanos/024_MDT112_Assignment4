using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{ 
    void Update()
    {      
       if (transform.position.y <= -2)
       {
            Debug.Log("You win");
       }
    }
}