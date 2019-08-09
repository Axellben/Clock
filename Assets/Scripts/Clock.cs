using UnityEngine;
using System;

public class Clock : MonoBehaviour {

  public Transform hoursTransform;
  public Transform minutesTransform;
  public Transform secondsTransform;

  float degreesPerHour = 30f;
  float degreesPerMinute = 6f;
  float degreesPerSecond = 6f;

  public bool continuous = false;


    void Update() {
    if (continuous) {
      UpdateContinuous();
    } else {
      UpdateDiscrete();
    }
  }


  void UpdateDiscrete() {
    DateTime time = DateTime.Now;
    hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.Hour * degreesPerHour, 0f);
    minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.Minute * degreesPerMinute, 0f);
    secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.Second * degreesPerSecond, 0f);
  }

  void UpdateContinuous() {
    TimeSpan time = DateTime.Now.TimeOfDay;
    hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
    minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
    secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
  }
}
