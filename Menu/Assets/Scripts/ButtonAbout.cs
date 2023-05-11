using UnityEngine;
using UnityEngine.UI;

public class ButtonAbout : MonoBehaviour
{
    [SerializeField] private Button _buttonAdout;
    [SerializeField] private Color _colorButton;

    public void ChangeColor()
    {
        _buttonAdout.GetComponent<Image>().color = _colorButton;
    }
}
