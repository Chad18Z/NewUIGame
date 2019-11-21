using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class Screenshake : MonoBehaviour
{
    float ShakeDuration = 0.05f;

    float smallShakeAmplitude = 1.3f;
    float mediumShakeAmplitude = 2f;
    float bigShakeAmplitude = 6f;

    float ShakeFrequency = 3.0f;

    float ShakeElapsedTime = 0f;

    bool isShaking = false;

    public static UnityEvent smallShakeEvent = new UnityEvent();
    public static UnityEvent mediumShakeEvent = new UnityEvent();
    public static UnityEvent bigShakeEvent = new UnityEvent();

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;

    // Start is called before the first frame update
    void Start()
    {
        if (VirtualCamera != null)
        {
            virtualCameraNoise = VirtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
        }

        virtualCameraNoise.m_AmplitudeGain = 0f;

        smallShakeEvent.AddListener(SmallShake);
        mediumShakeEvent.AddListener(MediumShake);
        bigShakeEvent.AddListener(BigShake);
    }

    private void SmallShake()
    {
        if (!isShaking)
        {
            StartCoroutine(Shaker(smallShakeAmplitude));
        }
    }

    private void MediumShake()
    {
        if (!isShaking)
        {
            StartCoroutine(Shaker(mediumShakeAmplitude));
        }
    }
    private void BigShake()
    {
        if (!isShaking)
        {
            StartCoroutine(Shaker(bigShakeAmplitude));
        }
    }


    // Update is called once per frame
    IEnumerator Shaker(float shakeAmplitude)
    {
        isShaking = true;

        ShakeElapsedTime = ShakeDuration;
        while (ShakeElapsedTime > 0)
        {
            virtualCameraNoise.m_AmplitudeGain = shakeAmplitude;
            virtualCameraNoise.m_FrequencyGain = ShakeFrequency;

            ShakeElapsedTime -= Time.deltaTime;
            yield return null;
        }
        virtualCameraNoise.m_AmplitudeGain = 0f;
        ShakeElapsedTime = 0f;

        isShaking = false;
        yield return null;
    }
}
