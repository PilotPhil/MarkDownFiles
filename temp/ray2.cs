using UnityEngine;
using System.Collections;

public class ray2 : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    // 创建射线到屏幕上的参考点，单位化坐标  
    Vector3 position = new Vector3(0.5f, 0.5f, 0.0f);
    void Update()
    {
        // 射线沿着屏幕x轴从左向右循环扫描  
        position.x = position.x >= 1.0f ? 0.0f : position.x + 0.02f;
        // 生成射线  
        ray = Camera.main.ViewportPointToRay(position);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            // 如果与物体发生碰撞，在Scene视图中绘制射线  
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            // 打印射线检测到的物体的名称  
            Debug.Log("射线检测到的物体名称: " + hit.transform.name);
        }
    }
}