// In this case, result = 4
float result = Mathf.Lerp (3f, 5f, 0.5f)

Vector3 from = new Vector3 (1f, 2f, 3f);
Vector3 to = new Vector3 (5f, 6f, 7f);

// Here result = (4, 5, 6)
Vector3 result = Vector3.Lerp (from, to, 0.75f);

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
}
//If the intensity of the light starts off at 0 then after the first update it will be set to 4. The next frame it will be set to 6, then to 7, then to 7.5 and so on. Thus over several frames, the lights intensity will tend towards 8 but the rate of its change will slow as it approaches its target. Note that this happens over the course of several frames.

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
}