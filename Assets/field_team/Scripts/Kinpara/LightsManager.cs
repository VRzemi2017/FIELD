﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsManager : MonoBehaviour {
    private enum FLASH {
        NORMAL,
        FLASHMAX
    }

    //Inspectorでいじれる値
    [SerializeField]
    private FLASH FlashPattern = FLASH.NORMAL;
    [SerializeField]
    private Color LightsColor = Color.red;
    [SerializeField]
    [ Range( 0.0f, 8.0f ) ]private float MaxIntensity = 0.4f;
    [SerializeField]
    private LightController[ ] Lights;

    //メンバ変数
    private float m_intensity;
    private Color m_color;


	// Use this for initialization
	void Start ( ) {
        //各初期化
        for ( int i = 0; i < Lights.Length; i++ ) {
            Lights[ i ].Intensity = MaxIntensity;
            Lights[ i ].LightColor = LightsColor;
        }

        //メンバ変数初期化
        m_intensity = MaxIntensity;
        m_color = LightsColor;
    }

    // Update is called once per frame
    void Update( ) {
        LightUpdate( );
        SetLights( );
    }

    //各Lightへの処理
    private void LightUpdate( ) {
        switch ( FlashPattern ) {
            case FLASH.NORMAL:
                SynchroFlashing( );
                break;
        }
    }

    //同時明滅処理
    private void SynchroFlashing( ) {
        //マジックナンバー使ってますが修正中
        m_intensity = Mathf.Sin( Time.timeSinceLevelLoad ) + 0.5f;
    }

    //ライトに処理を設定する
    private void SetLights( ) {
        for ( int i = 0; i < Lights.Length; i++ ) {
            Lights[ i ].Intensity = m_intensity;
            Lights[ i ].LightColor = m_color;
        }
    }
}
