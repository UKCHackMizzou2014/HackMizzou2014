using UnityEngine;
using System.Collections;

public class ForLoopScript : MonoBehaviour {
	public Main Main;
	public string mycode;
	private Vector3 startPoint = new Vector3 (0, 0, 0);
	private bool Return = false;
	/*float = 2.0f;
	private var step : float = 0.0f;
	private var onPlatform : boolean = false;
	*/
	void Awake () {
		Main = GameObject.FindWithTag ("GameController").GetComponent<Main>() as Main;
		}
	// Use this for initialization
	void Start () {
		startPoint = transform.position;
		mycode = "for (int a = 0; a <0 ;a++){}";
	}
	
	// Update is called once per frame
	void Update () {
		if (Return == true) {
			rigidbody.MovePosition(startPoint);
			Return = false;
		}
		/*else rigidbody.MovePosition(Vector3.Lerp(transform.position, startPoint,
		                                         (Time.time * duration)));*/
	
	}

	void OnTriggerEnter (Collider element) {
		Debug.Log ("Hello");
		Return = true;
		//Main.Add(mycode);
	}
}
