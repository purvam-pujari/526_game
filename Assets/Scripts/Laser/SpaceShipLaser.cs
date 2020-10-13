using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipLaser : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    
    public int speed;
    public Transform bulletPoint;

    
    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown("space")){
            GameObject newBullet = Instantiate(bullet) as GameObject;
            newBullet.transform.position = bulletPoint.position;
            newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
        }
    }
}
