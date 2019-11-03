using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpMonitor : MonoBehaviour
{
    int m_hp;
    int m_cnt;
    GameObject temp;

    private TextMesh textMesh;
    void Start()
    {
        temp = GameObject.Find("camera");
        textMesh = gameObject.GetComponentInChildren<TextMesh>();
    }

    void OnEnable()
    {

        Application.logMessageReceived += LogMessage;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        // Set the text 
        textMesh.text = message;
    }

    void Update()
    {
        m_hp = temp.GetComponent<damage>().hp;
        m_cnt = temp.GetComponent<damage>().cnt;
        Debug.Log(string.Format("HP: {0} / 20                                       Kill Count: {1}", m_hp,m_cnt));
        if (m_hp <= 0)
        {
            Debug.Log(string.Format("GAME OVER                                      Final Score: {0}", m_cnt));
            Destroy(this);
        }
    }
}
