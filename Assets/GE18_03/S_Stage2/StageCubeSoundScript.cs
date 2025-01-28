using UnityEngine;

public class StageCubeSoundScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(sound);
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(sound);
    }
}
