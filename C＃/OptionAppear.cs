using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 設定ウィンドウを表示するスクリプト
/// </summary>
public class OptionAppear : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    [SerializeField] GameObject menu;
    [SerializeField]GameObject option;
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
        if(option.activeSelf)
        {
        }
        else
        {
            option.SetActive(true);
            menu.SetActive(false);
        }
    
    }
}
