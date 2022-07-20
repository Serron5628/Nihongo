using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ButtonPush : MonoBehaviour
{
    private int a = -1;
    private int b = -1;

    private string[,] chara = Nihongo();
    private string all = "";
    // Start is called before the first frame update

    bool charaInputFlag = false;

    public GameObject chara_object = null;

    void Update()
    {
        var current = Keyboard.current;

        if (current == null)
        {
            // キーボードが接続されていないと
            // Keyboard.currentがnullになる
            return;
        }

        // Aキーの入力状態取得
        var oKey = current.oKey;
        var pKey = current.pKey;

        if (oKey.wasPressedThisFrame)
        {
            if (charaInputFlag)
            {
                all += chara[Mathf.Max(a, 0), Mathf.Max(b, 0)];
                a = -1;
                b = -1;
                Debug.Log(all);
                charaInputFlag = false;

                Text chara_text = chara_object.GetComponent<Text>();
                chara_text.text = all;
            }
            a++;
            Debug.Log(chara[Mathf.Max(a, 0), Mathf.Max(b, 0)]);
        }

        if (pKey.wasPressedThisFrame)
        {
            charaInputFlag = true;
            b++;
            Debug.Log(chara[Mathf.Max(a, 0), Mathf.Max(b, 0)]);
        }



    }

    static string[,] Nihongo()
    {
        string[,] nihongo = new string[10, 15];

        nihongo[0, 0] = "あ";
        nihongo[0, 1] = "い";
        nihongo[0, 2] = "う";
        nihongo[0, 3] = "え";
        nihongo[0, 4] = "お";

        nihongo[1, 0] = "か";
        nihongo[1, 1] = "き";
        nihongo[1, 2] = "く";
        nihongo[1, 3] = "け";
        nihongo[1, 4] = "こ";
        nihongo[1, 5] = "が";
        nihongo[1, 6] = "ぎ";
        nihongo[1, 7] = "ぐ";
        nihongo[1, 8] = "げ";
        nihongo[1, 9] = "ご";

        nihongo[2, 0] = "さ";
        nihongo[2, 1] = "し";
        nihongo[2, 2] = "す";
        nihongo[2, 3] = "せ";
        nihongo[2, 4] = "そ";
        nihongo[2, 5] = "ざ";
        nihongo[2, 6] = "じ";
        nihongo[2, 7] = "ず";
        nihongo[2, 8] = "ぜ";
        nihongo[2, 9] = "ぞ";

        nihongo[3, 0] = "た";
        nihongo[3, 1] = "ち";
        nihongo[3, 2] = "つ";
        nihongo[3, 3] = "て";
        nihongo[3, 4] = "と";
        nihongo[3, 5] = "だ";
        nihongo[3, 6] = "ぢ";
        nihongo[3, 7] = "づ";
        nihongo[3, 8] = "で";
        nihongo[3, 9] = "ど";

        nihongo[4, 0] = "は";
        nihongo[4, 1] = "ひ";
        nihongo[4, 2] = "ふ";
        nihongo[4, 3] = "へ";
        nihongo[4, 4] = "ほ";
        nihongo[4, 5] = "ば";
        nihongo[4, 6] = "び";
        nihongo[4, 7] = "ぶ";
        nihongo[4, 8] = "べ";
        nihongo[4, 9] = "ぼ";
        nihongo[4, 10] = "ぱ";
        nihongo[4, 11] = "ぴ";
        nihongo[4, 12] = "ぷ";
        nihongo[4, 13] = "ぺ";
        nihongo[4, 14] = "ぽ";

        nihongo[5, 0] = "ま";
        nihongo[5, 1] = "み";
        nihongo[5, 2] = "む";
        nihongo[5, 3] = "め";
        nihongo[5, 4] = "も";

        nihongo[6, 0] = "や";
        nihongo[6, 1] = "ゆ";
        nihongo[6, 2] = "よ";

        nihongo[7, 0] = "ら";
        nihongo[7, 1] = "り";
        nihongo[7, 2] = "る";
        nihongo[7, 3] = "れ";
        nihongo[7, 4] = "ろ";

        nihongo[8, 0] = "わ";
        nihongo[8, 1] = "を";
        nihongo[8, 2] = "ん";

        return nihongo;
    }

}