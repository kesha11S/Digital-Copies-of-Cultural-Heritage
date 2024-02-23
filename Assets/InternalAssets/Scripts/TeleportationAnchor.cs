using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationAnchor : MonoBehaviour
{
    //[SerializeField] private GameObject Player = GameObject.FindObjectOfType(Player);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerClick()
    {
        //Player.transform.position = new Vector3(0, 0, 0);
        Debug.Log("You teleported :)");
    }


    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
}
