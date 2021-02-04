using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    //1
    public Vector3 camOffset = new Vector3(0f, 2f, -3f);

    //2
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        //3
        target = GameObject.Find("Player").transform;
    }

    //4
    void LateUpdate()
    {

        //5
        this.transform.position = target.TransformPoint(camOffset);

        //6
        this.transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
