using UnityEngine;

public class Hehe : MonoBehaviour
{
    public AudioSource audioSource; 

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
