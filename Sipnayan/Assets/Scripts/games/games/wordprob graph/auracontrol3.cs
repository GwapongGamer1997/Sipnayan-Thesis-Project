using System.Collections;

using UnityEngine;

public class auracontrol3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if (nxtbutton1.resetAura == "y")
        {
            GetComponent<ParticleSystem>().Stop();
        }

        if (nxtbutton1.resetAura == "n") 
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

}
