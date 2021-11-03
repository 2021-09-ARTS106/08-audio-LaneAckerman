using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class enemysoundtrigger : MonoBehaviour
{
    //public AudioClip splashSound;
    public AudioSource battleMusic;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        // Make sure your character is tagged 'player'
        if (other.CompareTag("EnemyTrigger"))
        {

            battleMusic.Play();
        }
    }
}
