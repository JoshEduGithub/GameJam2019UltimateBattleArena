﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public GameObject Character;
    public int speed;
    public int Recoil;

    public Vector3 mousePos;
    public Vector3 objectPos;
    public float angle;

    public GameObject projectile;
    public GameObject FirePos;
    public GameObject FirePosCentre;
    public Animator anm;

    private void Update()
    {
        //movement

        Vector3 Movement = new Vector3(Input.GetAxis("P2HOR"), Input.GetAxis("P2VER"), 0);

        Character.transform.position += Movement * speed / 10;

        //aiming
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        FirePosCentre.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anm.SetBool("isGoingUp", false);
            anm.SetBool("isGoingDown", false);
            anm.SetBool("isGoingLeft", true);
            anm.SetBool("isGoingRight", false);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anm.SetBool("isGoingUp", false);
            anm.SetBool("isGoingDown", false);
            anm.SetBool("isGoingLeft", false);
            anm.SetBool("isGoingRight", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anm.SetBool("isGoingUp", true);
            anm.SetBool("isGoingDown", false);
            anm.SetBool("isGoingLeft", false);
            anm.SetBool("isGoingRight", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anm.SetBool("isGoingUp", false);
            anm.SetBool("isGoingDown", true);
            anm.SetBool("isGoingLeft", false);
            anm.SetBool("isGoingRight", false);
        }
    }



}
