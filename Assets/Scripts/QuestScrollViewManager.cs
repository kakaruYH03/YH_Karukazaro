using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestScrollViewManager : MonoBehaviour
{
    [SerializeField] TextAsset csvFile;
    [SerializeField] RectTransform cellContent;
    [SerializeField] GameObject cellPrefab;
    List<Cell> cellList = new List<Cell>();

    public void Start()
    {
        if (csvFile != null)
        {
            List<Person> result = FileManager.LoadData(csvFile.bytes);

            for (int i = 0; i < result.Count; i++)
            {
                Person person = result[i];

                Cell cell = Instantiate(cellPrefab, cellContent).GetComponent<Cell>();
                cell.SetcellData(person);
                cellList.Add(cell);
            }
        }
    }
}