using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;

	void OnTriggerEnter(Collider trigger)
    {
        print("Trigger");
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Collision");
    }
}
