using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCounter : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    public void UpdateText(string text)
    {
        _counterText.text = text;
    }
}
