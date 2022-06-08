using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bat dau va cham");
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("Dang va cham");
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Thoat khoi va cham");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("bat dau va cham xuyen qua");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Dang va cham xuyen qua");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Thoat khoi va cham xuyen qua");
    }
}
