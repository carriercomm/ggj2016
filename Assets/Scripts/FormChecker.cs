﻿using UnityEngine;
using System.Collections;

public class FormChecker : MonoBehaviour
{
  public GameObject doneCube;
	
  public bool isChecked = false;
  float timer = 0;

  void Update()
  {
    var formChecked = true;
    foreach (Transform sphereTransform in transform)
    {
      
      var sphere = sphereTransform.gameObject;

      var checker = sphere.GetComponent<SphereChecker>();
      if (checker != null)
      {
        if (!checker.isChecked)
        {
          formChecked = false;
          break;
        }
      }
    }

    if (!formChecked)
    {
      timer = 0;
    } else
    {
      timer += Time.deltaTime;
    }

    if (timer > 2)
    {
      isChecked = true;
    } else
    {
      isChecked = false;
    }


    if (isChecked)
    {
      doneCube.SetActive(true);
    } else
    {
      doneCube.SetActive(false);
    }
  }
}