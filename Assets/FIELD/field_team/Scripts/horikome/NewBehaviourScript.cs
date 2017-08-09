using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	private float Intensity;
	private Light p_light;
	//Intensity=強
	//Flashing=点滅

	// Use this for initialization
	void Start () {
		//ライトの取得
		p_light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		//点滅
		Flashing();
		Intensity = p_light.intensity;
	}

	private void Flashing() {
		//点滅はここで行う
		p_light.intensity = Mathf.Sin (Time.time) + 0.5f;
	}
}
