using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public GameObject play;
    public GameObject pause;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        play.SetActive(false);
        pause.SetActive(true);

    }

    }
