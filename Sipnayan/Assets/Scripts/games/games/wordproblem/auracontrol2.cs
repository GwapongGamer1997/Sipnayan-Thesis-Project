using System.Collections;

using UnityEngine;

public class auracontrol2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if (nxtbutton.resetAura == "y")
        {
            GetComponent<ParticleSystem>().Stop();
        }

        if (nxtbutton.resetAura == "n") 
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

}
