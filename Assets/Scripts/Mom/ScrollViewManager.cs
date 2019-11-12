using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewManager : MonoBehaviour
{
    // 프리팹
    [SerializeField] GameObject mainScrollViewPrefab;       // 스크롤뷰 프리팹
    [SerializeField] GameObject QuestScrollViewPrefab;      // 퀘스트 스크롤뷰 프리팹

    void Start()
    {
        mainScrollViewPrefab.gameObject.SetActive(true);
        QuestScrollViewPrefab.gameObject.SetActive(false);
    }

    public void QustButton()
    {
        //Instantiate(QuestScrollViewPrefab, transform.parent);
        mainScrollViewPrefab.gameObject.SetActive(false);
        QuestScrollViewPrefab.gameObject.SetActive(true);
    }

    public void MainButton()
    {
        mainScrollViewPrefab.gameObject.SetActive(true);
        QuestScrollViewPrefab.gameObject.SetActive(false);
    }
}
