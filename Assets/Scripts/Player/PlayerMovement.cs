using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 6f;
	Vector3 movement;
	Animator anim;
	Rigidbody playerRigidBody;
	int floormask;
	float camRayLength = 100f;

	void Awake ()
	{
		LayerMask.GetMask ("Floor");
		anim = GetComponent <Animator> ();
		playerRigidBody = GetComponent <Rigidbody> ();
	}
	void FixedUpdate()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
		turning ();
		Animating (h,v);

	}
	void Move (float h , float v)
	{ movement.Set (h, 0f, v);
		movement = movement.normalized *speed * Time.deltaTime;
		playerRigidBody.MovePosition (transform.position + movement );
	}
	void turning ()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorhit;

		if (Physics.Raycast (camRay, out floorhit, camRayLength, floormask)) {
			Vector3 playerToMouse = floorhit.point - transform.position;
			playerToMouse.y = 0f;
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			playerRigidBody.MoveRotation (newRotation);
		} 
	}
	void Animating (float h, float v)
	{
		bool walking = h != 0 || v != 0;
		anim.SetBool ("IsWalking", walking);

}
}
