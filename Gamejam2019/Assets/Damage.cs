using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public GameObject me;
    
    // Use this for initialization
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Oof");
            Object.Destroy(me);
        }
            //do stuff
 }

    private void OnBecomeInvisible()
    {
        Object.Destroy(me);
    }
}
