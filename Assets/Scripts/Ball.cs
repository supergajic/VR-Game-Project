using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    private float countdown;
    private float constantSpeed = 8f;

	// Use this for initialization
	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
        countdown = 5f;
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
            countdown -= Time.deltaTime;
        }

        if(countdown < 0)
        {
            countdown = 5f;
            hasStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = constantSpeed * (this.GetComponent<Rigidbody2D>().velocity.normalized);
            //this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f); // 10f är för hastigheten.
        }
	}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Vector2 tweak = new Vector2 (Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));

    //    this.GetComponent<Rigidbody2D>().velocity += tweak;
    //}
}
