using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Voice.Unity;

public class MutePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Recorder recorder = this.gameObject.GetComponent<Recorder>;
        Recorder recorder = this.gameObject.GetComponent<Recorder>();
    }

    // Update is called once per frame
    void Update()
    {
        Mute();
    }

    void Mute()
    {
        this.gameObject.GetComponent<Recorder>().TransmitEnabled = false;
        //recorder.TransmitEnabled = false;
        VoiceConnection voiceConnection = FindObjectOfType<VoiceConnection>();

        if (voiceConnection)

            voiceConnection.PrimaryRecorder.TransmitEnabled = false;
    }
}
