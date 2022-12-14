using UnityEngine;
using Tweens;

public class BasicUsage : MonoBehaviour
{
    [SerializeField] private float durationInSeconds;
    [SerializeField] private float startDelaySeconds;
    [SerializeField] private Vector3 endTarget;

    private EffectBuilder effectBuilder;

    void Start()
    {
        effectBuilder = new EffectBuilder(this);
        Effect moveEffect = new Move(transform, endTarget, durationInSeconds, startDelaySeconds);

        effectBuilder.AddEffect(moveEffect)
            .ExecuteAll();
    }


}
