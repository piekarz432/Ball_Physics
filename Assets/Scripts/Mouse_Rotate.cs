﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Rotate : MonoBehaviour
{

    private float baseAngle = 0.0f;
    public GameObject obiekt;


    void OnMouseDown()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(obiekt.transform.position);
        pos = Input.mousePosition - pos;
        baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        baseAngle -= Mathf.Atan2(transform.right.y, transform.right.x) * Mathf.Rad2Deg;

    }

    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
        obiekt.transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);
    }
}