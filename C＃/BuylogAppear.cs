using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 購入履歴のスクロールビューを表示するスクリプト
/// </summary>
public class BuylogAppear : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    [SerializeField] GameObject buylog;
    [SerializeField] GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if (buylog.activeSelf)
        {
        }
        else
        {
            buylog.SetActive(true);
            menu.SetActive(false);
        }
    }
}
