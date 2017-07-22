using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    //set,get変数
    public float Intensity { set {  m_intensity = value; } }
    public Color LightColor { set { m_color = value; } }

    //自身の"Light"の更新のため
    private Light m_light;

    private float m_intensity;
    private Color m_color;

	// Use this for initialization
	void Start ( ) {
        m_light = GetComponent<Light>( );
	}
	
    //全ての処理後、レンダリングの直前に更新すれば良いので"LateUpdate"にしてあります。
    //確実に"LightsManager"の"Update"の後にするためでもある
	void LateUpdate ( ) {
        m_light.intensity = m_intensity;
        m_light.color = m_color;
	}
}
