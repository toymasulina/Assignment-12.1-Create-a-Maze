using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public GameObject winMessage;
    public AudioSource winAudioSource;
    public AudioClip winClip;

    // Start is called before the first frame update
    void Start()
    {
        winMessage.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if (!winMessage.activeInHierarchy)
            {
                winMessage.SetActive(true);
                winAudioSource.PlayOneShot(winClip);
            }
        }
    }
}
