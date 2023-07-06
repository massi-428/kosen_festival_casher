using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using System;
/// <summary>
/// スクロールビューの中のテキストを表示するスクリプト
/// </summary>
public class ScrollText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI list_text;
    [SerializeField] AddOrder AddOrder;
    public int bought_count;
    public int list_count;
    public List<int> order_list;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        list_count=AddOrder.order_log.Count();
    }
    public void BoughtList()
    {
        order_list=AddOrder.order_log;
        for(int n=0;n<list_count;n++)
        {
            list_text.text=order_list[n].ToString();
        }
    }
}