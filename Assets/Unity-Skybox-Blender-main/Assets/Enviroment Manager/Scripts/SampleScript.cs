using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CoBlendSkies());
    }

    private IEnumerator CoBlendSkies()
    {
        while (true)
        {
            EnviromentManager.Instance.BlendEnviroment("Day", 10.0f);
            yield return new WaitForSeconds(120.0f);

            EnviromentManager.Instance.BlendEnviroment("Mid", 10.0f);
            yield return new WaitForSeconds(120.0f);

            EnviromentManager.Instance.BlendEnviroment("Night", 10.0f);
            yield return new WaitForSeconds(120.0f);
        }
    }
}
