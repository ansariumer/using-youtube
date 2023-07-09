
using UnityEngine;


public class playermovement : MonoBehaviour{

	public Rigidbody rb;

	public float forwardForce= 2000f;
	
	public float sidewaysForce=500f;

	public float jumpForce=200f;

	// Update is called once per frame
	
	void FixedUpdate(){
		// Add a forwardForce
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //  Add a right side force 
		if(Input.GetKey("d")){

			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);    
		}
		// Add a left side force 
		if(Input.GetKey("a")){

			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		//  add jump
		if(Input.GetKey("s")){

			rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
		if (rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
