using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// メニューのオブジェクトを表示するスクリプト
/// </summary>
public class MenuAppear : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    [SerializeField] GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    public void OnClick()
    {
        if (menu.activeSelf)
        {
            menu.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
        }
    }
}
