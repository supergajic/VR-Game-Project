using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        }

        if(Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            this.GetComponent<Rigidbody>().velocity = new Vector3(2f, 10f, 0f);
        }
	}
}
