﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMovie : MonoBehaviour {

    public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, -10, 0) * speed * Time.deltaTime);
    }
}
