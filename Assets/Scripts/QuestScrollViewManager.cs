using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestScrollViewManager : MonoBehaviour, ICell
{
    [SerializeField] RectTransform cellContent;
    [SerializeField] RectTransform cellSize;
    [SerializeField] GameObject cellPrefab;
    float cellHeight = 200f;
    List<Cell> cellList = new List<Cell>();

    Contacts? contacts;

    public void Start()
    {
        LoadData();
        Cell cell = Instantiate(cellPrefab, cellContent).GetComponent<Cell>();
        cell.cellDelegate = this;
    }

    public void Test()
    {
        Cell cell = Instantiate(cellPrefab, cellContent).GetComponent<Cell>();
        cell.cellDelegate = this;
    }

    public void BigCell(Cell cell)
    {
        //if ()
        //{
            cellContent.sizeDelta = new Vector2(0, cellContent.sizeDelta.y + cellHeight);
        //}

        ///else
        //{
            cellContent.sizeDelta = new Vector2(0, cellContent.sizeDelta.y - cellHeight);
        //}
    }

    void LoadData()
    {
        if (contacts.HasValue)
        {
            Contacts contactsValue = contacts.Value;
            contactsValue.contactList.Sort();

            for (int i = 0; i < contactsValue.contactList.Count; i++)
            {

            }
        }
    }
}