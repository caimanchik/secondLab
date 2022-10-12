using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip goodSpeak;
    public AudioClip normalSpeak;
    public AudioClip badSpeak;

    private AudioSource selectAudio;
    private readonly Dictionary<string, float> dataSet = new();
    private bool statusStart = false;
    private int i = 1;
    
    void Start()
    {
        StartCoroutine(GoogleSheets());
    }
    
    void Update()
    {
        if (dataSet["Mon_" + i] <= 200 & statusStart == false & i != dataSet.Count)
        {
            StartCoroutine(PlaySelectAudioGood());
            Debug.Log(dataSet["Mon_" + i]);
        }

        else if (dataSet["Mon_" + i] <= 300 & statusStart == false & i != dataSet.Count)
        {
            StartCoroutine(PlaySelectAudioNormal());
            Debug.Log(dataSet["Mon_" + i]);
        }
        
        else if (dataSet["Mon_" + i] > 300 & statusStart == false & i != dataSet.Count)
        {
            StartCoroutine(PlaySelectAudioBad());
            Debug.Log(dataSet["Mon_" + i]);
        }
        
    }

    IEnumerator GoogleSheets()
    {
        var currentResp =
            UnityWebRequest.Get(
                "https://sheets.googleapis.com/v4/spreadsheets/1M1_MBheSSc6P6Saql-HCwqSYOwYEG0Cc9kvSRcj0Ju0/values/Лист1?key=AIzaSyBoOWSAUFejfc3duN7KrRs12ZORIs60oPM");
        yield return currentResp.SendWebRequest();

        var rawResp = currentResp.downloadHandler.text;
        var rawJson = JSON.Parse(rawResp);

        foreach (var itemRawJson in rawJson["values"])
        {
            var parseJson = JSON.Parse(itemRawJson.ToString());
            var selectRaw = parseJson[0].AsStringList;
            dataSet.Add("Mon_" + selectRaw[0], float.Parse(selectRaw[1]));
        }
    }

    IEnumerator PlaySelectAudioGood()
    {
        statusStart = true;
        selectAudio = GetComponent<AudioSource>();
        selectAudio.clip = goodSpeak;
        selectAudio.Play();
        yield return new WaitForSeconds(3);
        statusStart = false;
        i++;
    }
    
    IEnumerator PlaySelectAudioNormal()
    {
        statusStart = true;
        selectAudio = GetComponent<AudioSource>();
        selectAudio.clip = normalSpeak;
        selectAudio.Play();
        yield return new WaitForSeconds(3);
        statusStart = false;
        i++;
    }
    
    IEnumerator PlaySelectAudioBad()
    {
        statusStart = true;
        selectAudio = GetComponent<AudioSource>();
        selectAudio.clip = badSpeak;
        selectAudio.Play();
        yield return new WaitForSeconds(4);
        statusStart = false;
        i++;
    }
}
