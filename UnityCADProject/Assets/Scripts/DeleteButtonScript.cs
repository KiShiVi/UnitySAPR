using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButtonScript : MonoBehaviour
{
    public GameObject mainScript;
    public void onClick()
    {
        Destroy(mainScript.GetComponent<StoringTheSelectedShape>().selectionShape);
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape = null;
    }
}
