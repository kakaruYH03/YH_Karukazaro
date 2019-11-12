using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonManager : AnimationManager
{
    [SerializeField] public GameObject ScrollView;

    public void QuestButton()
    {
        Instantiate(ScrollView, transform.parent).GetComponent<GameObject>();
    }
}
