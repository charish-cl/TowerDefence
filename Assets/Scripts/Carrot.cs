using UnityEngine;
using System.Collections;
using Assets.Scripts;
//下降的萝卜！！！！
public class Carrot : MonoBehaviour
{

    Camera mainCamera;

    // Use this for initialization
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //不断下降！！
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y - Time.deltaTime * FallSpeed,
            transform.position.z);
        transform.Rotate(0, 0, Time.deltaTime * 10);

        if (Input.GetMouseButtonDown(0))
        {
            //check if the user tap/click touches the carrot
            Vector2 location = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            if (this.GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(location,
                1 << LayerMask.NameToLayer("Carrot")))
            {
                //增加玩家金币
                GameManager.Instance.AlterMoneyAvailable(Constants.CarrotAward);
                //毁灭萝卜
                Destroy(this.gameObject);
            }
        }
    }

    public float FallSpeed = 1;
}
