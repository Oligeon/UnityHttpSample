using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpScript : MonoBehaviour
{
    private string url = "https://more-more-more.com/wp-content/uploads/2016/10/320bb162c6baa48aee7e744f5a699e91.png";
    // Start is called before the first frame update
    // 非同期のため、IEnumerator使用
    IEnumerator Start()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = www.texture;
            
        }
    }

  
}
