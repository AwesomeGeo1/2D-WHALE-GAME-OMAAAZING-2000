﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {
    bool control = false;
   static int levelSwitched = 0;
   
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
                levelSwitched++;
                Debug.Log(control);
                if (levelSwitched == 1)
                {
                    Application.LoadLevel(1);
                }
              if (levelSwitched == 2)
                {
                    Application.LoadLevel(2);
                }
                
                
            }
        }
       

    }
    
    }

