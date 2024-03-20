using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEventSubscriber : MonoBehaviour
{
    public ExEventChannel eventChannel;

    void OnEventRaisde()
    {
        Debug.Log(gameObject.name + " ���� �̺�Ʈ �߻�");
    }

    private void OnEnable()
    {
        eventChannel.OnEventRaised.AddListener(OnEventRaisde);
    }

    private void OnDisable()
    {
        eventChannel.OnEventRaised.RemoveListener(OnEventRaisde);
    }
}
