using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject XWing;
    public  Vector3 offset = new Vector3(0,13,-18);
    void Start()
    {
    }
    void Update()
    {
        this.transform.position = XWing.transform.position + offset;
    }
}
