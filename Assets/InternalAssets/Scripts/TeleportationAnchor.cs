using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationAnchor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerEnter()
    {

    }

    public void OnPointerExit()
    {
        
    }


    public void OnPointerClick()
    {
        GameObject.FindWithTag("Player").transform.position = transform.position + new Vector3(0, 1.6f, 0);
        Debug.Log("You teleported :)");
    }




    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
}
