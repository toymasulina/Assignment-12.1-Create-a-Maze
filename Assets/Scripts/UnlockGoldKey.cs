using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockGoldKey : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key Gold"))
        {
            if (door.activeInHierarchy)
            {
                door.SetActive(false);
                other.gameObject.SetActive(false);
            }
        }
    }
}
