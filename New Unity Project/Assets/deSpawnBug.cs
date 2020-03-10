using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deSpawnBug : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sound;
    public GameObject disableTrigger;
    public GameObject disableTrigger2;



    private void OnCollisionEnter(Collision collision)
    {
        sound.SetActive(true);
        disableTrigger2.SetActive(false);
        disableTrigger.SetActive(false);


 
        Debug.Log("Collision Detected");
    }
}
