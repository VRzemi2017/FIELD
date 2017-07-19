using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {
    [SerializeField]
    private float Intensity;
    private Light m_light;

	// Use this for initialization
	void Start ( ) {
        m_light = GetComponent<Light>( );
	}
	
	// Update is called once per frame
	void Update ( ) {
		Flashing( );
        Intensity = m_light.intensity;
	}

    //点滅処理をこの中で処理する
    private void Flashing( ) {
        m_light.intensity = Mathf.Sin( Time.time ) + 0.5f;
    }
}
