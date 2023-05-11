using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonExit : MonoBehaviour
{
    [SerializeField] private Transform _buttonExit;

    public void CloseScene()
    {


        if (_buttonExit.rotation.z == 0)
        {
            _buttonExit.DORotateQuaternion(Quaternion.Euler(0, 0, 180f), 0.5f).SetEase(Ease.Linear);
            _buttonExit.GetComponent<Image>().DOColor(Color.red, 0.5f).SetEase(Ease.Linear);
        }
        else
        {
            _buttonExit.DORotateQuaternion(Quaternion.Euler(0, 0, 0), 0.5f).SetEase(Ease.Linear);
            _buttonExit.GetComponent<Image>().DOColor(Color.white, 0.5f).SetEase(Ease.Linear);
        }


    }

}
