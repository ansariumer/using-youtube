using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_jump : MonoBehaviour
{
    public float jumpforce = 10f;
	public float gravity;
	Rigidbody rb;
    void Start()
    {
      rb = GetComponent <Rigidbody>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if(Input.GetKeyDown(KeyCode.Space)){
		rb.AddForce(Vector3.up*jumpforce,ForceMode.Impulse);
	  }
    }
}
