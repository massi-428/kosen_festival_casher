using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// <see cref = "CountPlus"/>で追加を決定した値をリストに追加するスクリプト
/// </summary>
public class AddOrder : MonoBehaviour
{
    public static List<int> order_log=new List<int>();
    public static List<int> number_log=new List<int>();
    [SerializeField] CountPlus countPlus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick(int n)
    {
        if (n == 1)
        {
            order_log.Add(countPlus.count);
            number_log.Add(n+1);
        }
    }
}
