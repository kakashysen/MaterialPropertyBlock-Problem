using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator anim;
    private Renderer rend;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rend = GetComponent<Renderer>();

        rend.material.color = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space)){
            anim.SetFloat("changeColor", 1.0f);
        }
        else{
            anim.SetFloat("changeColor", -1.0f);
        }
	}
}
