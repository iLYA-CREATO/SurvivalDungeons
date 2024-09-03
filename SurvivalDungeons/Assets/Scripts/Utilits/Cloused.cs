using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Скрипт отвечает за простое закрытие окон
/// </summary>
public class Cloused : MonoBehaviour
{
    public void _ClousePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
