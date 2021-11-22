using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Button _buttonLeft;
    [SerializeField] private Button _buttonRight;
    [SerializeField] private Button _buttonTop;
    [SerializeField] private Button _buttonBottom;

    private void Awake()
    {
        _buttonLeft.onClick.AddListener(OnLeftClick);
        _buttonRight.onClick.AddListener(OnRightClick);
        _buttonTop.onClick.AddListener(OnTopClick);
        _buttonBottom.onClick.AddListener(OnBottomClick);
    }

    private void OnLeftClick()
    {
       Debug.Log("Left");
    }
    private void OnRightClick()
    {
        Debug.Log("Right");
    }
    private void OnTopClick()
    {
        Debug.Log("Left");
    }
    private void OnBottomClick()
    {
        Debug.Log("Left");
    }
}
