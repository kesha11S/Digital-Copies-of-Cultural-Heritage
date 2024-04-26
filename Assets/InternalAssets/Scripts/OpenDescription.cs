//Скрипт телепортации, при нажатии на точку телепортации
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDescription : MonoBehaviour
{
    public Material GazedMaterial;
    public Material UngazedMaterial;
    public GameObject descText;
    public GameObject descPlane;

    //Проверяет, нажал ли пользователь на эту точку
    public void OnPointerClick() 
    {
        if (descText.GetComponent<Renderer>().enabled == GetComponent<Renderer>().enabled) {
            descText.GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
            descPlane.GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
        }
        else {
            descText.GetComponent<Renderer>().enabled = GetComponent<Renderer>().enabled;
            descPlane.GetComponent<Renderer>().enabled = GetComponent<Renderer>().enabled;
        }
        
    }

    public void OnPointerEnter()
    {
        gameObject.GetComponent<MeshRenderer> ().material = GazedMaterial;
    }

    public void OnPointerExit()
    {
        gameObject.GetComponent<MeshRenderer> ().material = UngazedMaterial;
    }
}
