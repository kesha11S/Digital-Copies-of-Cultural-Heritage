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
    private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    //Проверяет, нажал ли пользователь на эту точку
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
        audioSource.clip = audioClip;
        audioSource.Play();

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
