using UnityEngine;
using System.Collections;

public class FollowCar : MonoBehaviour {

    public Transform target;    // ターゲット(自動車)への参照
    private Vector3 offset_position;     // 相対座標
    private Quaternion rotation_matrix;  // 回転座標
    private Vector3 camera_position;
    private void Start()
    {
        // 自分自身とtargetの相対距離を求める オフセット = 自動車の座標 - カメラの座標
        offset_position = GetComponent<Transform>().position - target.position;
    }

    private void Update()
    {
        // 自動車の回転角度を求める
        rotation_matrix = target.rotation;
        camera_position= rotation_matrix * offset_position;


        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
        GetComponent<Transform>().position = target.position + camera_position;
        GetComponent<Transform>().rotation = target.rotation;
    }
}