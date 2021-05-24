using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public string turn;

    public int hotKey = 0;
    private int numHotKeys = 5;

    private void Start()
    {
        turn = "Ellie";

        UpdateHotKey(0);
    }

    private void Update()
    {

        if (Input.mouseScrollDelta.y > 0.0f)
            UpdateHotKey(hotKey + 1);
        if (Input.mouseScrollDelta.y < 0.0f)
            UpdateHotKey(hotKey - 1);


        if (Input.GetKeyUp(KeyCode.Alpha1))
            UpdateHotKey(0);
        if (Input.GetKeyUp(KeyCode.Alpha2))
            UpdateHotKey(1);
        if (Input.GetKeyUp(KeyCode.Alpha3))
            UpdateHotKey(2);
        if (Input.GetKeyUp(KeyCode.Alpha4))
            UpdateHotKey(3);
        if (Input.GetKeyUp(KeyCode.Alpha5))
            UpdateHotKey(4);

        GameObject.Find("PlayerName").GetComponent<TMPro.TextMeshProUGUI>().text = turn;

        if (turn == "Ellie")
            GameObject.Find("Main Camera").GetComponent<CameraController>().player = GameObject.Find("Ellie");
        else
            GameObject.Find("Main Camera").GetComponent<CameraController>().player = GameObject.Find("Ollie");
    }

    

    private void UpdateHotKey(int n)
    {

        if (n < 0 || n >= numHotKeys)
            return;

        GameObject.Find("Hotkey" + hotKey).GetComponent<Button>().GetComponent<Image>().color = Color.white;

        hotKey = n;

        GameObject.Find("Hotkey" + hotKey).GetComponent<Button>().GetComponent<Image>().color = Color.yellow;
        
     


    }

    



}
