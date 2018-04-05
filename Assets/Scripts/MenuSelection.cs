using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour {
    private RaycastHit hit;

    void Start()
    {
        Debug.Log("test");
    }

	void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));

        if(Physics.Raycast(ray, out hit))
        {
            StartCoroutine(ScaleHit());
            //hit.transform.LookAt(Camera.main.gameObject.transform.position);
            if (hit.transform.gameObject.name == "Waterfall" && Input.GetMouseButton(0))
            {
                SceneManager.LoadScene("_MainScene", LoadSceneMode.Single);
                Debug.Log("New level pls");
            }
        }

    }
    IEnumerator ScaleHit()
    {
        Vector3 startScale = hit.transform.localScale;
        Vector3 targetScale = new Vector3(2.0f, 2.0f, 2.0f);
        float scaleDuration = 5;

        for (float t = 0; t < 1; t += Time.deltaTime / scaleDuration) {
            hit.transform.localScale = Vector3.Lerp(startScale, targetScale, t);
                    yield return null;
        }

}
}
