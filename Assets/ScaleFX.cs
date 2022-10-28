using UnityEngine;
 using System.Collections;
 
 public class ScaleFX : MonoBehaviour {

       Transform target;
    float smoothTime = 0.3f;
    float yVelocity = 0.0f;

     void Update() {
          // float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
       
        // transform.localScale = new Vector3(Mathf.PingPong(Time.time, 3));
         transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        // transform.localScale = new Vector3(Mathf.PingPong(Time.time, 3);
         // transform.localScale = new Vector3(ScaleX,ScaleY,ScaleZ);
    
     }

 /*     void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }*/
 }