using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundaries : MonoBehaviour  
{
  
  

    void Start()
    {
       
     
    }

    // Update is called once per frame
    void Update()
    {
      
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.05f, 0.95f);
        pos.y = Mathf.Clamp(pos.y, 0.09f, 0.95f);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }






         /* var clamp = Screen.width * 2.0f / 1440;

        transform.position=new Vector3(Mathf.Clamp(transform.position.x,-clamp,clamp), Mathf.Clamp(transform.position.y,-4f,4f),transform.position.z);

        Debug.Log("clamp");
    }*/
        
}
