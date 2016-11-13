using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 10f); // x = -2.3 till 2.3  y = -0.4  z = Alltid 10
        //Vector3 paddlePos = new Vector3(Input.acceleration.x, this.transform.position.y , 10f); // x = -2.3 till 2.3  y = -0.4  z = Alltid 10 FUNKAR!

        //float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; // FUNKAR!
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        //paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f); //FUNKAR!

        this.transform.position = paddlePos;
	}

    //void Start()
    //{
    //    Input.gyro.enabled = true;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
    //}
}
