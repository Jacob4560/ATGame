using UnityEngine;
using System.Collections;
using System;

// Creates a Timer object.
public class Timer : MonoBehaviour
{
  public bool active;

  public void doAfterTime(Action action, float duration)
  {
    active = true;
    // Begins coroutine, calls function "action" after duration
    StartCoroutine(WaitForTime(duration, action));
  }

  IEnumerator WaitForTime(float duration, Action action)
  {
    yield return new WaitForSeconds(duration);
    action?.Invoke();
    active = false;
  }
}

