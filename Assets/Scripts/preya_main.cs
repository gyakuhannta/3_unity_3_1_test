using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*public class ChangeChara : MonoBehaviour
{

    //　現在どのキャラクターを操作しているか
    private int nowChara;
    //　操作可能な ゲームキャラクター
    [SerializeField]
    private List<GameObject> charaList;

    void Start()
    {
        //　最初の操作キャラクターを0番目のキャラクターにする
        charaList[0].GetComponent<ControlOnOffChara>().ChangeControl(true);
    }

    void Update()
    {
        //　Qキーが押されたら操作キャラクターを次のキャラクターに変更する
        if (Input.GetKeyDown("q"))
        {
            ChangeCharacter(nowChara);
        }
    }

    //　操作キャラクター変更メソッド
    void ChangeCharacter(int tempNowChara)
    {
        //　現在操作しているキャラクターを動かなくする
        charaList[tempNowChara].GetComponent<ControlOnOffChara>().ChangeControl(false);
        //　次のキャラクターの番号を設定
        var nextChara = tempNowChara + 1;
        if (nextChara >= charaList.Count)
        {
            nextChara = 0;
        }
        //　次のキャラクターを動かせるようにする
        charaList[nextChara].GetComponent<ControlOnOffChara>().ChangeControl(true);
        //　現在のキャラクター番号を保持する
        nowChara = nextChara;
    }
}*/