using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewManager : MonoBehaviour, ICell
{
    [SerializeField] RectTransform content;

    List<Cell> cellList = new List<Cell>();

    float cellHeight = 200f;

    private void Awake()
    {

    }

    public void CellOpen(Cell cell)
    {
        bool isOn = false;

        if (isOn == false)
        {
            int cellIndex = cellList.IndexOf(cell);
            content.sizeDelta = new Vector2(1080, cellHeight * 2);
            isOn = true;
            Debug.Log("된다");
        }
        else
        {
            content.sizeDelta = Vector2.zero;
            isOn = false;
        }

    }
}