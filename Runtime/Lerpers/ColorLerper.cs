using System.Collections;
using UnityEngine;

namespace Tweens.Lerpers
{
    /// <summary>
    /// The Lerper for any Color-based or fade-based Effect.
    /// </summary>
    public class ColorLerper : Lerper<Color>
    {
        /// <inheritdoc cref="Tweens.Lerpers.Lerper{T1}.Start"/>
        public override IEnumerator Start()
        {
            yield return _wait;

            float duration = _durationInSecs - 0.01f;

            _isComplete = false;

            while (_timeElapsed < duration)
            {
                float complete = _timeElapsed / duration;

                _setter(_startValue + (_endValue - _startValue) * Mathf.SmoothStep(0, 1, complete));

                _timeElapsed += Time.deltaTime;
                yield return null;

            }

            _setter(_endValue);
            _isComplete = true;
        }
    }

}