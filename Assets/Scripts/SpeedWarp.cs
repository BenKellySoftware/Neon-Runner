using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedWarp : MonoBehaviour {
	//	public Material gradient;
	public Color[] NeonPallet;
	public int interval = 1;
	private float nextTime = 0;
	private int i = 0;
	// Update is called once per frame
	void Update () {
		GetComponent<CanvasRenderer>().GetMaterial().SetColor("_Color", Color.Lerp(NeonPallet[(i + 1)% (NeonPallet.Length-1)], NeonPallet[(i) % (NeonPallet.Length-1)], nextTime - Time.time));
		GetComponent<CanvasRenderer>().GetMaterial().SetColor("_Color2", Color.Lerp(NeonPallet[(i + 3) % (NeonPallet.Length-1)], NeonPallet[(i + 2) % (NeonPallet.Length-1)], nextTime - Time.time));
		if (Time.time >= nextTime) {
			i++;
			nextTime += interval;
		}
	}
}
