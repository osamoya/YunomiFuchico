using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Old_ScreenToWolrd_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("クリック確認");
            OnClickScreen();
        }
    }

    void OnClickScreen()
    {
        Debug.Log("関数確認");

        // マウスのポインタがあるスクリーン座標を取得
        Vector3 screen_point = Input.mousePosition;
        // z に 1 を入れないと正しく変換できない
        screen_point.z = 1.0f;
        // スクリーン座標をワールド座標に変換
        Vector3 world_position = Camera.main.ScreenToWorldPoint(screen_point);

        Debug.Log("座標：" + world_position);
    }
}
