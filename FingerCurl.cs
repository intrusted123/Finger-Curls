using UnityEngine;
using Valve.VR;

public class FingerCurl : MonoBehaviour
{
	public SteamVR_Action_Skeleton skeletonAction;
	public Transform indexTip;
	public Transform indexKnuckle;
	public Transform indexBottom;
	public Transform middleTip;
	public Transform middleKnuckle;
	public Transform middleBottom;
	public Transform ringTip;
	public Transform ringKnuckle;
	public Transform ringBottom;
	public Transform pinkyTip;
	public Transform pinkyKnuckle;
	public Transform pinkyBottom;
	public Transform thumbTip;
	public Transform thumbKnuckle;
	public float curlAmount;
	[Header("Curl Direction/Rotation")]
	public bool x;
	public bool y;
	public bool z;
	public bool InvertRotation;
	private Vector3 indexTipEuler;
	private Vector3 indexKnuckleEuler;
	private Vector3 indexBottomEuler;
	private Vector3 middleTipEuler;
	private Vector3 middleKnuckleEuler;
	private Vector3 middleBottomEuler;
	private Vector3 ringTipEuler;
	private Vector3 ringKnuckleEuler;
	private Vector3 ringBottomEuler;
	private Vector3 pinkyTipEuler;
	private Vector3 pinkyKnuckleEuler;
	private Vector3 pinkyBottomEuler;
	private Vector3 thumbTipEuler;
	private Vector3 thumbKnuckleEuler;
 







	private void Update()
	{
		Thumb();
		Index();
		Middle();
		Ring();
		Pinky();
		SetXRotation();
		SetYRotation();
		SetZRotation();
	
		
		
		
		
       

	}

	private void Index()
	{
		
		indexTip.transform.localRotation = Quaternion.Euler(indexTipEuler);	 
		indexKnuckle.transform.localRotation = Quaternion.Euler(indexKnuckleEuler);	 
		indexBottom.transform.localRotation = Quaternion.Euler(indexBottomEuler);
		
		
	}

	private void Middle()
	{
		 
		middleTip.transform.localRotation = Quaternion.Euler(middleTipEuler);
		middleKnuckle.transform.localRotation = Quaternion.Euler(middleKnuckleEuler);
		middleBottom.transform.localRotation = Quaternion.Euler(middleBottomEuler);
		
	}

	private void Ring()
	{
		 
		ringTip.transform.localRotation = Quaternion.Euler(ringTipEuler);
		ringKnuckle.transform.localRotation = Quaternion.Euler(ringKnuckleEuler);
		ringBottom.transform.localRotation = Quaternion.Euler(ringBottomEuler);
	}

	private void Pinky()
	{
		 
		pinkyTip.transform.localRotation = Quaternion.Euler(pinkyTipEuler);		 
		pinkyKnuckle.transform.localRotation = Quaternion.Euler(pinkyKnuckleEuler);
		pinkyBottom.transform.localRotation = Quaternion.Euler(pinkyBottomEuler);
	}

	private void Thumb()
	{

		thumbTip.transform.localRotation = Quaternion.Euler(thumbTipEuler);
		thumbKnuckle.transform.localRotation = Quaternion.Euler(thumbKnuckleEuler);
	}
	private void SetXRotation()
    {
		if (x)
		{
			indexTipEuler = new Vector3(skeletonAction.indexCurl * curlAmount, 0f, 0f);
			indexKnuckleEuler = new Vector3(skeletonAction.indexCurl * curlAmount, 0f, 0f);
			indexBottomEuler = new Vector3(skeletonAction.indexCurl * curlAmount, 0f, 0f);
			middleTipEuler = new Vector3(skeletonAction.middleCurl * curlAmount, 0f, 0f);
			middleKnuckleEuler = new Vector3(skeletonAction.middleCurl * curlAmount, 0f, 0f);
			middleBottomEuler = new Vector3(skeletonAction.middleCurl * curlAmount, 0f, 0f);
			ringTipEuler = middleTipEuler = new Vector3(skeletonAction.ringCurl * curlAmount, 0f, 0f);
			ringKnuckleEuler = middleTipEuler = new Vector3(skeletonAction.ringCurl * curlAmount, 0f, 0f);
			ringBottomEuler = middleTipEuler = new Vector3(skeletonAction.ringCurl * curlAmount, 0f, 0f);
			pinkyTipEuler = middleTipEuler = new Vector3(skeletonAction.pinkyCurl * curlAmount, 0f, 0f);
			pinkyKnuckleEuler = middleTipEuler = new Vector3(skeletonAction.pinkyCurl * curlAmount, 0f, 0f);
			pinkyBottomEuler = pinkyTipEuler = middleTipEuler = new Vector3(skeletonAction.pinkyCurl * curlAmount, 0f, 0f);
			thumbKnuckleEuler = pinkyTipEuler = middleTipEuler = new Vector3(skeletonAction.thumbCurl * curlAmount, 0f, 0f);
			thumbTipEuler = pinkyTipEuler = middleTipEuler = new Vector3(skeletonAction.thumbCurl * curlAmount, 0f, 0f);

			
		}
		if (x && InvertRotation)
		{
			indexTipEuler = new Vector3(-skeletonAction.indexCurl * curlAmount, 0f, 0f);
			indexKnuckleEuler = new Vector3(-skeletonAction.indexCurl * curlAmount, 0f, 0f);
			indexBottomEuler = new Vector3(-skeletonAction.indexCurl * curlAmount, 0f, 0f);
			middleTipEuler = new Vector3(-skeletonAction.middleCurl * curlAmount, 0f, 0f);
			middleKnuckleEuler = new Vector3(-skeletonAction.middleCurl * curlAmount, 0f, 0f);
			middleBottomEuler = new Vector3(-skeletonAction.middleCurl * curlAmount, 0f, 0f);
			ringTipEuler = middleTipEuler = new Vector3(-skeletonAction.ringCurl * curlAmount, 0f, 0f);
			ringKnuckleEuler = middleTipEuler = new Vector3(-skeletonAction.ringCurl * curlAmount, 0f, 0f);
			ringBottomEuler = middleTipEuler = new Vector3(-skeletonAction.ringCurl * curlAmount, 0f, 0f);
			pinkyTipEuler = middleTipEuler = new Vector3(-skeletonAction.pinkyCurl * curlAmount, 0f, 0f);
			pinkyKnuckleEuler = middleTipEuler = new Vector3(-skeletonAction.pinkyCurl * curlAmount, 0f, 0f);
			pinkyBottomEuler = pinkyTipEuler = middleTipEuler = new Vector3(-skeletonAction.pinkyCurl * curlAmount, 0f, 0f);
			thumbKnuckleEuler = pinkyTipEuler = middleTipEuler = new Vector3(-skeletonAction.thumbCurl * curlAmount, 0f, 0f);
			thumbTipEuler = pinkyTipEuler = middleTipEuler = new Vector3(-skeletonAction.thumbCurl * curlAmount, 0f, 0f);
		}
	}
	private void SetYRotation()
    {
		if (y)
		{
			indexTipEuler = new Vector3(0f, skeletonAction.indexCurl * curlAmount, 0f);
			indexKnuckleEuler = new Vector3(0f, skeletonAction.indexCurl * curlAmount, 0f);
			indexBottomEuler = new Vector3(0f, skeletonAction.indexCurl * curlAmount, 0f);
			middleTipEuler = new Vector3(0f, skeletonAction.middleCurl * curlAmount, 0f);
			middleKnuckleEuler = new Vector3(0f, skeletonAction.middleCurl * curlAmount, 0f);
			middleBottomEuler = new Vector3(0f, skeletonAction.middleCurl * curlAmount, 0f);
			ringTipEuler = new Vector3(0f, skeletonAction.ringCurl * curlAmount, 0f);
			ringKnuckleEuler = new Vector3(0f, skeletonAction.ringCurl * curlAmount, 0f);
			ringBottomEuler = new Vector3(0f, skeletonAction.ringCurl * curlAmount, 0f);
			pinkyTipEuler = new Vector3(0f, skeletonAction.pinkyCurl * curlAmount, 0f);
			pinkyKnuckleEuler = new Vector3(0f, skeletonAction.pinkyCurl * curlAmount, 0f);
			thumbTipEuler = new Vector3(0f, skeletonAction.thumbCurl * curlAmount, 0f);
			thumbKnuckleEuler = new Vector3(0f, skeletonAction.thumbCurl * curlAmount, 0f);

		}
		if (y && InvertRotation)
		{
			indexTipEuler = new Vector3(0f, -skeletonAction.indexCurl * curlAmount, 0f);
			indexKnuckleEuler = new Vector3(0f, -skeletonAction.indexCurl * curlAmount, 0f);
			indexBottomEuler = new Vector3(0f, -skeletonAction.indexCurl * curlAmount, 0f);
			middleTipEuler = new Vector3(0f, -skeletonAction.middleCurl * curlAmount, 0f);
			middleKnuckleEuler = new Vector3(0f, -skeletonAction.middleCurl * curlAmount, 0f);
			middleBottomEuler = new Vector3(0f, -skeletonAction.middleCurl * curlAmount, 0f);
			ringTipEuler = new Vector3(0f, -skeletonAction.ringCurl * curlAmount, 0f);
			ringKnuckleEuler = new Vector3(0f, -skeletonAction.ringCurl * curlAmount, 0f);
			ringBottomEuler = new Vector3(0f, -skeletonAction.ringCurl * curlAmount, 0f);
			pinkyTipEuler = new Vector3(0f, -skeletonAction.pinkyCurl * curlAmount, 0f);
			pinkyKnuckleEuler = new Vector3(0f, -skeletonAction.pinkyCurl * curlAmount, 0f);
			thumbTipEuler = new Vector3(0f, -skeletonAction.thumbCurl * curlAmount, 0f);
			thumbKnuckleEuler = new Vector3(0f, -skeletonAction.thumbCurl * curlAmount, 0f);
		}
	}
	private void SetZRotation()
    {
		if (z)
		{
			indexTipEuler = new Vector3(0f, 0f, skeletonAction.indexCurl * curlAmount);
			indexKnuckleEuler = new Vector3(0f, 0f, skeletonAction.indexCurl * curlAmount);
			indexBottomEuler = new Vector3(0f, 0f, skeletonAction.indexCurl * curlAmount);
			middleTipEuler = new Vector3(0f, 0f, skeletonAction.middleCurl * curlAmount);
			middleKnuckleEuler = new Vector3(0f, 0f, skeletonAction.middleCurl * curlAmount);
			middleBottomEuler = new Vector3(0f, 0f, skeletonAction.middleCurl * curlAmount);
			ringTipEuler = new Vector3(0f, 0f, skeletonAction.ringCurl * curlAmount);
			ringKnuckleEuler = new Vector3(0f, 0f, skeletonAction.ringCurl * curlAmount);
			ringBottomEuler = new Vector3(0f, 0f, skeletonAction.ringCurl * curlAmount);
			pinkyTipEuler = new Vector3(0f, 0f, skeletonAction.pinkyCurl * curlAmount);
			pinkyKnuckleEuler = new Vector3(0f, 0f, skeletonAction.pinkyCurl * curlAmount);
			pinkyBottomEuler = new Vector3(0f, 0f, skeletonAction.pinkyCurl * curlAmount);
		}
		if (z && InvertRotation)
		{
			indexTipEuler = new Vector3(0f, 0f, -skeletonAction.indexCurl * curlAmount);
			indexKnuckleEuler = new Vector3(0f, 0f, -skeletonAction.indexCurl * curlAmount);
			indexBottomEuler = new Vector3(0f, 0f, -skeletonAction.indexCurl * curlAmount);
			middleTipEuler = new Vector3(0f, 0f, -skeletonAction.middleCurl * curlAmount);
			middleKnuckleEuler = new Vector3(0f, 0f, -skeletonAction.middleCurl * curlAmount);
			middleBottomEuler = new Vector3(0f, 0f, -skeletonAction.middleCurl * curlAmount);
			ringTipEuler = new Vector3(0f, 0f, -skeletonAction.ringCurl * curlAmount);
			ringKnuckleEuler = new Vector3(0f, 0f, -skeletonAction.ringCurl * curlAmount);
			ringBottomEuler = new Vector3(0f, 0f, -skeletonAction.ringCurl * curlAmount);
			pinkyTipEuler = new Vector3(0f, 0f, -skeletonAction.pinkyCurl * curlAmount);
			pinkyKnuckleEuler = new Vector3(0f, 0f, -skeletonAction.pinkyCurl * curlAmount);
			pinkyBottomEuler = new Vector3(0f, 0f, -skeletonAction.pinkyCurl * curlAmount);
			thumbTipEuler = new Vector3(0f, 0f, -skeletonAction.thumbCurl * curlAmount);
			thumbKnuckleEuler = new Vector3(0f, 0f, -skeletonAction.pinkyCurl * curlAmount);
		}
	}
}
