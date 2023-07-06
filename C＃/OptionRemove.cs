using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// <see cref="OptionAppear"/>で表示した設定ウィンドウを閉じるスクリプト
/// </summary>
public class OptionRemove : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    [SerializeField] GameObject option;
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
        if (option.activeSelf)
        {
            option.SetActive(false);
        }
        else
        {
            option.SetActive(true);
        }
    }
}
