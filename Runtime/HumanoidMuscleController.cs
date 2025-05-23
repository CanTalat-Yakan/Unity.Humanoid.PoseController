using UnityEngine;

namespace UnityEssentials
{
    /// <summary>
    /// Provides functionality to control and manipulate the muscle values of a humanoid avatar.
    /// </summary>
    /// <remarks>This class is designed to work with humanoid avatars in Unity. It allows for setting
    /// individual muscle values by index, name, or predefined muscle enumeration, as well as resetting all muscles to
    /// their default state. The class requires a valid humanoid <see cref="Avatar"/> to function correctly and must be
    /// initialized before use.</remarks>
    public class HumanoidMuscleController : MonoBehaviour
    {
        [SerializeField] private Avatar _avatar;

        private HumanPoseHandler _poseHandler;
        private HumanPose _humanPose;

        private bool _isInitialized;

        public void Start() =>
            Initialize();

        public void Initialize()
        {
            if (_avatar == null || !_avatar.isHuman)
            {
                Debug.LogError("Missing or invalid Humanoid Avatar!");
                return;
            }

            _poseHandler = new HumanPoseHandler(_avatar, transform);
            _humanPose = new HumanPose();
            _isInitialized = true;
        }

        public void SetMuscle(HumanBodyMuscles muscle, float value)
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            _poseHandler.GetHumanPose(ref _humanPose);
            _humanPose.muscles[(int)muscle] = Mathf.Clamp(value, -1, 1);
            _poseHandler.SetHumanPose(ref _humanPose);
        }

        public void SetMuscle(int muscleIndex, float value)
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            if (muscleIndex < 0 || muscleIndex >= HumanTrait.MuscleCount)
            {
                Debug.LogError($"Invalid muscle index: {muscleIndex} (Must be 0-{HumanTrait.MuscleCount - 1})");
                return;
            }

            _poseHandler.GetHumanPose(ref _humanPose);
            _humanPose.muscles[muscleIndex] = Mathf.Clamp(value, -1, 1);
            _poseHandler.SetHumanPose(ref _humanPose);
        }

        public void SetMuscle(string muscleName, float value)
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            for (int i = 0; i < HumanTrait.MuscleCount; i++)
            {
                if (HumanTrait.MuscleName[i] == muscleName)
                {
                    SetMuscle(i, value);
                    return;
                }
            }
            Debug.LogError($"Muscle not found: {muscleName}");
        }

        public void ResetAllMuscles()
        {
            if (!_isInitialized) Initialize();
            if (!_isInitialized) return;

            _poseHandler.GetHumanPose(ref _humanPose);
            for (int i = 0; i < _humanPose.muscles.Length; i++)
                _humanPose.muscles[i] = 0;

            _poseHandler.SetHumanPose(ref _humanPose);
        }

        public void PrintAllMuscles()
        {
            for (int i = 0; i < HumanTrait.MuscleCount; i++)
                Debug.Log($"{i}: {HumanTrait.MuscleName[i]}");
        }
    }
}