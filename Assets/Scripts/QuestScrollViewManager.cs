using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestScrollViewManager : MonoBehaviour, ICell
{
    [SerializeField] TextAsset csvFile;
    [SerializeField] RectTransform cellContent;
    [SerializeField] GameObject cellPrefab;
    float cellHeight = 200f;
    List<Cell> cellList = new List<Cell>();

    public void Start()
    {
        if (csvFile != null)
        {
            List<Person> result = FileManager.LoadData(csvFile.bytes);
            cellContent.sizeDelta = new Vector2(0, result.Count * cellHeight);

            for (int i = 0; i < result.Count; i++)
            {
                Person person = result[i];

                Cell cell = Instantiate(cellPrefab, cellContent).GetComponent<Cell>();
                cell.SetcellData(person);
                cell.cellDelegate = this;
            }
        }
    }

    public void BigCell(Cell cell)
    {
        cellContent.sizeDelta = new Vector2(0, cellList.Count + cellHeight);
    }
}