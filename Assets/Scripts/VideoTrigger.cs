using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    // Reference to the VideoPlayer component
    public VideoPlayer videoPlayer;

    // This method is called when another object enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered is tagged as "Player" (or any relevant tag)
        if (other.CompareTag("Player"))
        {
            // Play the video
            videoPlayer.Play();
        }
    }
}
