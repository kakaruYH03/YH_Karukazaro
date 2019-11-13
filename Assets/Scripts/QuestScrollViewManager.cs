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
                cellList.Add(cell);
                cell.cellDelegate = this;
            }
        }
    }

    // TODO: 각 Cell에 index 값을 넣는다
    // cell을 클릭해서 커졌을때 다른셀을 눌러도 cellcontent가 늘어나게 하기 or 이전에 누른셀은 축소하고 다른셀을 늘리기

    public void BigCell(Cell cell)
    {
        cellContent.sizeDelta = new Vector2(0, cellList.Count * cellHeight);
    }
}