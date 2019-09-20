using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireposthingo : MonoBehaviour {

    public GameObject projectile;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            shootBullet();
        }
    }

    void shootBullet()
    {
        GameObject bullet = Instantiate(projectile, this.transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.right * 0.000075f);
    }
}
