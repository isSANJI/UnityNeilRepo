﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        
    }


    public int maxHits;

    private int timesHit;

	// Use this for initialization
	void Start () {

        timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
