﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializerOrWhatever : MonoBehaviour {

	// Use this for initialization
	void Start () {

		OSCHandler.Instance.Init();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
