//Скрипт телепортации, при нажатии на точку телепортации
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationAnchor : MonoBehaviour
{
    public Material GazedMaterial;
    public Material UngazedMaterial;
    private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;


    //Проверяет, нажал ли пользователь на эту точку
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick() 
    {
        //Перемещает пользователя (GameObject с тегом "Игрок") на позицию 
        //точки телепортации плюс высота пользователя
        GameObject.FindWithTag("Player").transform.position = transform.parent.transform.position + new Vector3(0, 1.6f, 0);
        audioSource.clip = audioClip;
        audioSource.Play();

        //Выводит дебаг сообщение, что пользователь телепортировался
        Debug.Log("You teleported :)");
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
