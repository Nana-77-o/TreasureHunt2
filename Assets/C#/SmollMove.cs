using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmollMove : MonoBehaviour
{
    private Vector3 player_pos;
    public void Update()
    {
        Clamp();
    }
    void Clamp()
    {
        player_pos = transform.position; //プレイヤーの位置を取得

        player_pos.x = Mathf.Clamp(player_pos.x, -100f, 100f);
        player_pos.z = Mathf.Clamp(player_pos.z, -100f, 100f);//x位置が常に範囲内か監視
        transform.position = new Vector3(player_pos.x, player_pos.y,player_pos.z); //範囲内であれば常にその位置がそのまま入る
    }
}