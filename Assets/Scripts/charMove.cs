using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class charMove : MonoBehaviour {

	public float speed;
	private int count;
	private float startTime = 0f;
	private float time;
	private int flag = 0;

	public Text endText;

	private Rigidbody2D rgd;

	// Use this for initialization
	void Start () {
		rgd = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey ("up")) {
			rgd.MovePosition (rgd.position + (Vector2.up * Time.deltaTime * speed));
			transform.gameObject.GetComponent<Animator> ().Play ("up");
		}
		if (Input.GetKey ("down")) {
			rgd.MovePosition (rgd.position + (Vector2.down * Time.deltaTime * speed));
			transform.gameObject.GetComponent<Animator> ().Play ("down");
		}
		if (Input.GetKey ("left")) {
			rgd.MovePosition (rgd.position + (Vector2.left * Time.deltaTime * speed));
			transform.gameObject.GetComponent<Animator> ().Play ("left");
		}
		if (Input.GetKey ("right")) {
			rgd.MovePosition (rgd.position + (Vector2.right * Time.deltaTime * speed));
			transform.gameObject.GetComponent<Animator> ().Play ("right");
		}
		endText.text = "";
		if (count == 5) {
			endText.text = "It was actually all set up for a...";
			if (flag == 0) {
				startTime = Time.time;
				flag = 1;
			}
			if (Time.time - startTime > 4)
				SceneManager.LoadScene ("endScene", LoadSceneMode.Single);
		}
	}

	void OnCollisionEnter2D(Collision2D item) {
		if (item.gameObject.CompareTag ("pickup")) {
			Destroy (item.gameObject);
			count++;
		}
	}


}
