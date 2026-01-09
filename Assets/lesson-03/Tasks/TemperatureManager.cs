using TMPro;
using UnityEngine;

namespace Lesson03.Tasks
{

    public class TemperatureManager : MonoBehaviour
    {
        public TMP_Text _alertText;
        public float minTemperature = 65f;
        public float maxTemperature = 75f;
        public float temperatureChangeRate = 0.2f;
        public float updateInterval = 0.1f;


        private string[] roomNames = { "Living Room", "Kitchen", "Bedroom", "Bathroom", "Office" };
        private float[] roomTemperatures;
        private float nextUpdateTime = 0f;

        private void Start()
        {
            roomTemperatures = new float[roomNames.Length];
            for (int i = 0; i < roomTemperatures.Length; i++)
            {
                roomTemperatures[i] = Random.Range(minTemperature, maxTemperature);
            }
            nextUpdateTime = Time.time + updateInterval;
        }

        private void Update()
        {
            if (Time.time >= nextUpdateTime)
            {
                UpdateTemperatures();
                CheckTemperatureAlerts();
                nextUpdateTime = Time.time + updateInterval;
            }
        }
        private void UpdateTemperatures()
        {
            for (int i = 0; i < roomTemperatures.Length; i++)
            {
                float change = Random.Range(-temperatureChangeRate, temperatureChangeRate);
                roomTemperatures[i] += change;
                roomTemperatures[i] = Mathf.Clamp(roomTemperatures[i], minTemperature - 10f, maxTemperature + 10f);
                Debug.Log($"{roomNames[i]} Temperature: {roomTemperatures[i]:F2}°F");
            }
        }
        private void CheckTemperatureAlerts()
        {
            string alertMessage = "";
            for (int i = 0; i < roomTemperatures.Length; i++)
            {
                if (roomTemperatures[i] < minTemperature)
                {
                    alertMessage += $"{roomNames[i]} is too cold! ({roomTemperatures[i]:F2}°F)\n";
                }
                else if (roomTemperatures[i] > maxTemperature)
                {
                    alertMessage += $"{roomNames[i]} is too hot! ({roomTemperatures[i]:F2}°F)\n";
                }
            }

            if(_alertText != null)
            {
                if(string.IsNullOrEmpty(alertMessage))
                {
                    _alertText.text = "All rooms are within the comfortable temperature range.";
                    _alertText.color = Color.green;
                }
                else
                {
                    _alertText.text = alertMessage;
                    _alertText.color = Color.red;
                }
            }
        }
    }
}