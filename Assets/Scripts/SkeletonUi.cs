using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonUi : MonoBehaviour
{
    Image m_image;
    public Sprite Spine;
    public Sprite ribs;
    public Sprite arm;
    public Sprite arms;
    public Sprite armsLeg;
    public Sprite Full;

    void Start()
    {
        m_image = GetComponent<Image>();
    }

    void Update()
    {
        switch (Spawner.value)
        {

            case 2:
                m_image.sprite = Spine;
                break;

            case 3:
                m_image.sprite = ribs;
                break;

            case 4:
                m_image.sprite = arm;
                break;

            case 5:
                m_image.sprite = arms;
                break;

            case 8:
                m_image.sprite = armsLeg;
                break;

            case 10:
                m_image.sprite = Full;
                break;

        }


    }
}
