using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{

    public Vector3 mBefore;
    public Vector3 mAfter;
    public Vector3 distance;
    public Vector3 targetPos;
    public Vector3 rawPos;
    public float coin;
    public bool bFlag;
    public bool aFlag;

    // Start is called before the first frame update
    void Start()
    {
        bFlag = false;
        aFlag = false;
        coin = 50f;

        rawPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetMouseButtonDown(0))
        {
            mBefore.x = Input.mousePosition.x;
            mBefore.z = -Input.mousePosition.z;
            mBefore.y = 0;
            bFlag = true;
        }

        if(Input.GetMouseButtonUp(0))
        {
            mAfter.x = Input.mousePosition.x;
            mAfter.z = -Input.mousePosition.y;
            mAfter.y = 0;
            aFlag = true;
        }

        if(bFlag==true & aFlag==true)
        {
            distance = mAfter - mBefore;
            Debug.Log(distance);

            targetPos.y = this.transform.position.y;
            targetPos.x = this.transform.position.x - distance.x / coin;
            targetPos.z = this.transform.position.z + distance.z / coin;

            this.transform.position = targetPos;

            bFlag = false;
            aFlag = false;

        }

    }

}
