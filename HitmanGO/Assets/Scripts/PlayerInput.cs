﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
	
	float m_h;
	public float H { get { return m_h; } }
	float m_v;
	public float V { get { return m_v; } }
	public bool m_inputEnabled = false; 
	public bool InputEnabled { get { return m_inputEnabled; } set { m_inputEnabled = value ; } }	

	//plyaerInput.InputEnabled = false;
	public void GetKeyInput() {
		if (m_inputEnabled) {
			m_h = Input.GetAxisRaw("Horizontal");
			m_v = Input.GetAxisRaw("Vertical");
		}
	}

}
