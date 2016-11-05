using UnityEngine;
using UnityEngine.SceneManagement;
public class controller : MonoBehaviour
{

	private Vector2 jumpForce = new Vector2(0, 300);

	private double jumpCount=1; 
	public int asd=0;
	public Rigidbody2D rb;


	void Start(){	
		rb = GetComponent<Rigidbody2D>();
		PlayerPrefs.SetInt("speed", 5);



	}
	void Update ()
	{


		transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
		if (Input.GetKeyUp("space")&&jumpCount>0)
		{

			Jump ();

		}


	}
	void Jump(){
		jumpCount = 0;

		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		GetComponent<Rigidbody2D> ().AddForce (jumpForce);

	}

	void OnCollisionEnter2D(Collision2D coll){

		jumpCount = 1;

	}


	void Duck(){
		// to do
	}}




