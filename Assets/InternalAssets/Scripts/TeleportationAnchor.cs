//Скрипт телепортации, при нажатии на точку телепортации
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationAnchor : MonoBehaviour
{
    //Проверяет, нажал ли пользователь на эту точку
    public void OnPointerClick() 
    {
        //Перемещает пользователя (GameObject с тегом "Игрок") на позицию 
        //точки телепортации плюс высота пользователя
        GameObject.FindWithTag("Player").transform.position = transform.position + new Vector3(0, 1.6f, 0);
        
        //Выводит дебаг сообщение, что пользователь телепортировался
        Debug.Log("You teleported :)");
    }

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

    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
}
