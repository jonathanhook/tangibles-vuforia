using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    public int TrackToControl = 0;
    public DJMixer mixer;

    public void OnTargetFound()
    {
        Debug.Log(TrackToControl + " found");
        mixer.SetTrackState(TrackToControl, true);
    }

    public void OnTargetLost()
    {
        Debug.Log(TrackToControl + " lost");
        mixer.SetTrackState(TrackToControl, false);
    }
}
