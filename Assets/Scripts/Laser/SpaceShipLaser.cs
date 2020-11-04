using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipLaser : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    
    public int speed;
    public Transform bulletPoint;
    private float rotationTime;
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    Vector2 currentSwipe;
    
    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)){
            fingerDown = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if(Input.GetMouseButtonUp(0)){
            fingerUp = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            currentSwipe = new Vector2(fingerUp.x - fingerDown.x, fingerUp.y - fingerDown.y);
            //swipe left
            if(currentSwipe.x == 0 && currentSwipe.y == 0) {
                // Debug.Log("left swipe");
                GameObject newBullet = Instantiate(bullet) as GameObject;
                newBullet.transform.position = bulletPoint.position;
                newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
            }
        }

        if(Input.GetKeyDown("space")){
            GameObject newBullet = Instantiate(bullet) as GameObject;
            newBullet.transform.position = bulletPoint.position;
            newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
        }
    }
}
