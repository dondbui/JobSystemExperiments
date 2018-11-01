using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public struct TestJob : IJobParallelForTransform
{

    public void Execute(int index, TransformAccess transform)
    {
        Quaternion q = transform.rotation;
        Vector3 angles = q.eulerAngles;
        angles.x += 0.5f;

        if (angles.x >= 90)
        {
            angles.x = 0;
        }

        q.eulerAngles = angles;

        transform.rotation = q;
    }
}
