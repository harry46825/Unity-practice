using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public GameObject HealthBarUIPrefab;//直接將barholder掛載到這個script上這樣只要有使用這個script的敵人就不用各別把血條拉上去
    public Transform BarPoint;//BAR要生成在哪個點

    public bool AlwaysVisible;//可設定受到攻擊後才會顯示血條還是永遠顯示
    Image HealthSlider;
    Transform UIbar;
    Transform cam;

    void OnEnable()
    {
        cam = Camera.main.transform;
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.renderMode == RenderMode.WorldSpace)
            {
                UIbar = Instantiate(HealthBarUIPrefab, canvas.transform).transform;
                HealthSlider = UIbar.GetChild(0).GetComponent<Image>();
                UIbar.gameObject.SetActive(AlwaysVisible);

            }
        }
    }

    void LateUpdate()
    {
        if (UIbar != null)
        {
            UIbar.position = BarPoint.position;
            UIbar.forward = -cam.forward;
        }
    }

}

