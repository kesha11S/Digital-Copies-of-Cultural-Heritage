using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KerdugenStartAnimation : MonoBehaviour
{
    public Material GazedMaterial;
    public Material UngazedMaterial;
    public GameObject animationObject;
    private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    private Animator mAnimator;

    void Start()
    {
        mAnimator = animationObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    //Проверяет, нажал ли пользователь на эту точку
    public void OnPointerClick() 
    {
        mAnimator.SetTrigger("TrStart");
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
