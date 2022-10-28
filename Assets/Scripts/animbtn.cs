using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIManagement;

public class animbtn : MonoBehaviour {

    public Animator anim;

 // Use this for initialization
 void Start () {
  
 }
 
 // Update is called once per frame
 void Update () {
       /* if(Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
        {
            anim.Play("open");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("close"))
        {
            anim.Play("open");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("open"))
        {
            anim.Play("close");
        }*/

        for (int i = 0; i<Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            {
              gameObject.SetActive(true);
                anim.Play("open");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("close"))
            {
                anim.Play("open");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("open"))
            {
                anim.Play("close");
            }
        }


    }
}
