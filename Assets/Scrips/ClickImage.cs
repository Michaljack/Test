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
            //正确的声音
            GameStart.Instance.PlayAudio("StartSerie");
            //油桶消失
            GameStart.Instance.HideYOU();

        }
        else
        {
            //错误的声音
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
