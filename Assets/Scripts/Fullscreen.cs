using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    void TriggerVideo1()
    {
        Handheld.PlayFullScreenMovie("Euro5.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
    }

    
}