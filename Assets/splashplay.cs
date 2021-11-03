using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashplay : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioSource audioS;

       
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        // Make sure your character is tagged 'player'
        if (other.CompareTag("Water"))
        {

            audioS.PlayOneShot(splashSound);
        }
    }
}
