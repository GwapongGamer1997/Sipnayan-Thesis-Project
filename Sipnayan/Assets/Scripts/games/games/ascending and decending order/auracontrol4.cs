using System.Collections;

using UnityEngine;

public class auracontrol4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if (nxtbutton4.resetAura == "y")
        {
            GetComponent<ParticleSystem>().Stop();
        }

        if (nxtbutton4.resetAura == "n") 
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

}
