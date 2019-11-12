using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestScrollViewManager : MonoBehaviour, ICell
{
    [SerializeField] RectTransform cellContent;

    List<Cell> cellList = new List<Cell>();

    Contacts? contacts;


    public void BigCell(Cell cell)
    {
        if (contacts.HasValue)
        {
            Contacts contactsValue = contacts.Value;
            cellContent.sizeDelta = new Vector2(0, contactsValue.contactList.Count * 2);
        }
        else
        {

        }
    }
}