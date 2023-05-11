using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] private GameObject _buttonPlay;

    private void Start()
    {
        _buttonPlay.transform.DOScale(new Vector3(1f, 1f, 1), 0.5f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        _buttonPlay.GetComponent<Image>().DOColor(Color.yellow, 0.5f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
