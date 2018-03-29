using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoIntensity : MonoBehaviour {

    Transform sunTrans;
    Light curLight; 

	// Use this for initialization
	void Start () {
        sunTrans = GetComponent<Transform>();
        curLight = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        sunTrans.Rotate(Time.deltaTime * 20, 0, 0);

        if (sunTrans.rotation.eulerAngles.x < 0 || 
            sunTrans.rotation.eulerAngles.x > 180 )
        {
            curLight.intensity = 0;
        }
        else
        {
            curLight.intensity = 1;
        }
	}
}
