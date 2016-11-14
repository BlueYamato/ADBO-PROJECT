using UnityEngine;
using UnityEngine.SceneManagement;public class controller : MonoBehaviour
{

	private Vector2 jumpForce = new Vector2(0, 300);

	private double jumpCount=1; 
	public bool isJump;
	public bool isSleding;
	public Rigidbody2D rb;
	public bool isDead;
	public Animator animator;
	private BoxCollider2D PocongCollider;
	void Start(){	
		rb = GetComponent<Rigidbody2D>();
		PlayerPrefs.SetInt("speed", 5);
		animator = new Animator ();
		PocongCollider = GetComponent<BoxCollider2D>();
	}
	void Update ()
	{


		transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);

		if (Input.GetKeyUp("space")&&isJump==false&&isSleding==false)
		{

		Jump ();

		}

		if (Input.GetKey (KeyCode.DownArrow)&&isJump==false) {
			Duck ();
		} else if (Input.GetKeyUp(KeyCode.DownArrow)) {
			
			PocongCollider.size = new Vector2 (10.625f, 17f); 
			GetComponent<Animator> ().Play ("luncat");
			isSleding = false;
		}


	}
	void Jump(){
		isJump = true;
		jumpCount = 0;
	
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		GetComponent<Rigidbody2D> ().AddForce (jumpForce);

	}

	void OnCollisionEnter2D(Collision2D coll){
		
		isJump = false;
		if (coll.gameObject.tag == "obstacle") {
			isDead = true;
			PlayerPrefs.SetInt("speed", 0);
			GetComponent<Animator> ().Stop ();
		} else {
			isDead = false;
		}
	}


	void Duck(){
		
		isSleding = true;
		PocongCollider.size = new Vector2 (6.004205f, 4.65256f); 
		GetComponent<Animator> ().Play ("sleding");

	}}




