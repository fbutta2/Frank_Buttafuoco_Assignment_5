using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
    double speed = 0.25;
    public Camera cam;


    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            cam.enabled = false;
            return;
        }
        var x = Input.GetAxis("Horizontal") * (float) speed*4;
        var z = Input.GetAxis("Vertical") * (float) speed;
        this.transform.Translate(z, 0, 0);
        this.transform.Rotate(0, x, 0 );

    }
    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void SpeedUp()
    {
        speed += 0.1;
        Debug.Log("speed is " + speed);
    }
}
