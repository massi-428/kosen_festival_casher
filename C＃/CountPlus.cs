using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/// <summary>
/// 注文追加によって追加される個数を決めるスクリプト
/// </summary>
public class CountPlus : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI bought;
    public static CountPlus pm;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        // bought = GetComponentInChildren<TextMeshProUGUI>();
        bought.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick(int n)//TextMeshProに文字を出力する
    {

        switch (n)
        {
            case 0:
                count++;
                bought.text = count.ToString();
                break;

            case 1:
                count--;
                bought.text = count.ToString();
                break;
        }
    }
}
