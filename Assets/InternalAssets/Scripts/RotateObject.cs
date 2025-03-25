//Скрипт телепортации, при нажатии на точку телепортации
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Material GazedMaterial;
    public Material UngazedMaterial;
    public GameObject rotatingObject;
    private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    //Проверяет, нажал ли пользователь на эту точку
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick() 
    {
        rotatingObject.transform.Rotate(0.0f, 15.0f, 0.0f, Space.World);
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
