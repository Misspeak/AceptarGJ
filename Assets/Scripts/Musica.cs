using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour
{

    void OnTriggerEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}
