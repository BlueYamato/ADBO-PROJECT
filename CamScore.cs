using UnityEngine;
using System.Collections;

public class CamScore : MonoBehaviour {
	public int sc;
	public float sco;
	public int high;
	public GUIStyle style1;


	void Start () {
		sco = 0;
		PlayerPrefs.SetInt ("high", 0);
	}


	void Update () {
		sco += Time.deltaTime * 10;
		sc = (int)sco;
		if (high < sco) {
			PlayerPrefs.SetInt ("high", sc);
			transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
		}
	}

	void OnGUI ()
	{
		string hi = high.ToString ();
		string score = sc.ToString ();

		GUI.Label (new Rect (Screen.width * 0.8f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), score,style1);
		GUI.Label (new Rect (Screen.width * 0.65f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), "HI " + hi,style1);

	}
}
