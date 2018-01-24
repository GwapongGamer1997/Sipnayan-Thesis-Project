using System.Collections;

using UnityEngine;

public class auracontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if (nextbutton.resetAura == "y")
        {
            GetComponent<ParticleSystem>().Stop();
        }

        if (nextbutton.resetAura == "n") 
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

}
