using System.Collections;
using UnityEngine;

public class Example : MonoBehaviour
{
	[SerializeField] private AnimatedProgressbar	m_progressbarUI	= null	;
	[SerializeField] private float					m_speed			= 0		;

	private float m_fillAmount;

	private IEnumerator Start()
	{
		while ( m_fillAmount < 1 )
		{
			m_fillAmount += m_speed;
			m_progressbarUI.FillAmount = m_fillAmount;
			yield return null;
		}
	}
}
