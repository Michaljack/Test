using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickImage : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(1);
        if (this.tag == "cuowu")
        {
            gameObject.SetActive(false);
            GameStart.Instance.num++;
            //��ȷ������
            GameStart.Instance.PlayAudio("StartSerie");
            //��Ͱ��ʧ
            GameStart.Instance.HideYOU();

        }
        else
        {
            //���������
            GameStart.Instance.PlayAudio("BAT");

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
