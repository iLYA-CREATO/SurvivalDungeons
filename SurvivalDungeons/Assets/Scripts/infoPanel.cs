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
            Debug.Log("���������� �����");
            buttunAction.GetComponentInChildren<TextMeshProUGUI>().text = "�����";
        }
        else
        {
            buttunAction.GetComponentInChildren<TextMeshProUGUI>().text = "�����";

            buttunAction.GetComponent<Button>().onClick.AddListener(() => slotArmorPlayer.MoveToSlotArmor(typeArmor, itemObject));
            Debug.Log("���������� �����");
            //buttunAction.GetComponent<Button>();
        }
    }
}
