using UnityEngine;
using System.Collections;

public class test : MonoBehaviour 
{
	int tiaInt = 33;
	// Use this for initialization
	void Start(){
		tiaInt = timesthree (tiaInt);
		Debug.Log (tiaInt);
	}
	int timesthree (int testInt){
		int three = testInt * 3;

		return three;
	}
    }
	// Update is called once per frame
	

