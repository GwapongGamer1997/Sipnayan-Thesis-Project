using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auracontrol1 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (nextbutton1.resetAura == "y")
        {
            GetComponent<ParticleSystem>().Stop();
        }

        if (nextbutton1.resetAura == "n")
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

}
