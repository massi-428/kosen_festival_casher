using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// <see cref="MenuAppear"/>で表示したウィンドウを閉じるスクリプト
/// </summary>
public class MenuRemove : MonoBehaviour
{
    private Rigidbody2D rbody2D;
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
