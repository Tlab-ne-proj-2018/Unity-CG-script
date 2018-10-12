using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// レーザー距離計
namespace UnityStandardAssets.Vehicles.Car
{
    public class CalcDistance : MonoBehaviour
    {
        
        public const float NOTHING = -1;    // 計測不能

        public float maxDistance = 30;      // 計測可能な最大距離
        public float distance = 1.0f;              // 計測距離

        // 距離計測
        public void Update()
        {
            // 前方ベクトル計算
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            // 距離計算
            RaycastHit hit;
            if (Physics.Raycast(transform.position, fwd, out hit, maxDistance))
            {
                distance = hit.distance;
                Debug.Log(distance);
            }
            else
            {
                distance = NOTHING;
            }
        }
    }
}
