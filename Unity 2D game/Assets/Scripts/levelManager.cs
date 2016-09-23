using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {
    bool control = false;
	// Use this for initialization
	void Start () {
      
     
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("flagPole").GetComponent<EndGame>().levelComplete)
        {
            

            if( control == false)
            {
                control = true;
                Debug.Log(control);
               
            }
        }
       

    }
}
