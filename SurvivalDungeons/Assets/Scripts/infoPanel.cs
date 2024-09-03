using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class infoPanel : MonoBehaviour
{
    public GameObject buttunAction;
    public GameObject butunPurches;


    public SlotArmorPlayer slotArmorPlayer;
    private void OnEnable()
    {
        SelectItemArmor.isOpenInfoPanel += ButtonParametrs;
    }

    private void OnDisable()
    {
        SelectItemArmor.isOpenInfoPanel -= ButtonParametrs;
    }

    private void ButtonParametrs(bool isEquipped, TypeArmor typeArmor, GameObject itemObject)
    {
        if(isEquipped == true)
        {
            Debug.Log("экипировка одета");
            buttunAction.GetComponentInChildren<TextMeshProUGUI>().text = "Снять";
        }
        else
        {
            buttunAction.GetComponentInChildren<TextMeshProUGUI>().text = "Одеть";

            buttunAction.GetComponent<Button>().onClick.AddListener(() => slotArmorPlayer.MoveToSlotArmor(typeArmor, itemObject));
            Debug.Log("экипировка снята");
            //buttunAction.GetComponent<Button>();
        }
    }
}
