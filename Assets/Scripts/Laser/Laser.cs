using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > screenBounds.z * 1.5){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) {
		// Debug.Log("Colliding: " + other.gameObject.tag);
		if(other.gameObject.tag == "Pick Up") {
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		} else if(other.gameObject.tag == "Red" || other.gameObject.tag == "Green" || other.gameObject.tag == "Blue"){
			Destroy(this.gameObject);
		}
	}
}
