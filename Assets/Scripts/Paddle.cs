using UnityEngine;
using System.Collections;


public class Paddle : MonoBehaviour {

    public GameObject paddle;
    private int speed;

	// Use this for initialization
	void Start () {
        speed = 8;
    }
	
	// Update is called once per frame
	void Update () {

        //Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 10f); // x = -2.3 till 2.3  y = -0.4  z = Alltid 10
        //Vector3 paddlePos = new Vector3(Input.acceleration.x, this.transform.position.y , 10f); // x = -2.3 till 2.3  y = -0.4  z = Alltid 10 FUNKAR!

        //float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; // FUNKAR!
        //float mousePosInBlocks = Input.GetAxis("RightJoystickX") / Screen.width * 16;

        //if (this.transform.position.x < -5 && this.transform.position.x < 30)
        //{
        if (paddle.transform.position.x > -5 && paddle.transform.position.x < 28)
        {
            transform.Translate(Vector3.right * Input.GetAxis("RightJoystickX") * speed * Time.deltaTime);
        }
        else
        {
            speed = 0;
        }

        //paddlePos.x = Mathf.Clamp(mousePosInBlocks, -8f, 28f);
        //paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f); //FUNKAR!

        //this.transform.position = paddlePos;
	}
}
