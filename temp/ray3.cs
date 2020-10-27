using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray3 : MonoBehaviour
{
	public GameObject dot;

	public ArrayList track;	// 轨迹数组

	private void Start()
    {
		track = new ArrayList();
    }

    void Update()
	{
		//按下鼠标左键时响应该方法
		if (Input.GetMouseButtonDown(0))
		{
			//创建一条射线一摄像机为原点
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;
			//射线碰撞到游戏地形时
			if (Physics.Raycast(ray, out hit)==true)
			{
				//立方体	
				GameObject obj = GameObject.Instantiate(dot) as GameObject;
				// GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
				obj.transform.position = hit.point;

				track.Add(hit.point);

				Debug.Log(track.Count);
				// DrawLines(track);
				Debug.DrawLine(new Vector3(0, 0, 0), new Vector3(5,5,5),Color.red);

			}
		}

	}


	void DrawLines(ArrayList points)
    {
		for(int i=0;i<points.Count-1;i++)
        {
			Debug.DrawLine((Vector3)points[i], (Vector3)points[i + 1]);
        }
    }
}
