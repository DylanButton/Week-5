using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
 public Animator animator;
 void Update(){
    if (Input.GetButtonDown("Fire2"))
        {
            animator.SetBool("IsScoped", true);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animator.SetBool("IsScoped", false);
        }
 }
 }
