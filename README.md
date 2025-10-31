# Unity Essentials

This module is part of the Unity Essentials ecosystem and follows the same lightweight, editor-first approach.
Unity Essentials is a lightweight, modular set of editor utilities and helpers that streamline Unity development. It focuses on clean, dependency-free tools that work well together.

All utilities are under the `UnityEssentials` namespace.

```csharp
using UnityEssentials;
```

## Installation

Install the Unity Essentials entry package via Unity's Package Manager, then install modules from the Tools menu.

- Add the entry package (via Git URL)
    - Window → Package Manager
    - "+" → "Add package from git URL…"
    - Paste: `https://github.com/CanTalat-Yakan/UnityEssentials.git`

- Install or update Unity Essentials packages
    - Tools → Install & Update UnityEssentials
    - Install all or select individual modules; run again anytime to update

---

# Humanoid Pose Controller

> Quick overview: Runtime helper to author and apply humanoid poses by writing Unity’s human muscle values. Provides a settings object with grouped controls and event-driven updates, plus one-click Apply/Reset.

Humanoid poses can be authored, previewed, and applied at runtime by manipulating Unity’s human muscles, with safe clamping and a clean inspector. Grouped controls and on‑change events help keep related muscles in sync, and one‑click Apply/Reset enables fast iteration for cutscenes, emotes, and runtime pose adjustments.

![screenshot](Documentation/Screenshot.png)

## Features
- Runtime pose authoring for humanoid rigs
  - Controls Unity human muscles via `HumanPoseHandler`
  - Safe clamping to [-1, 1] and avatar validation
- Grouped, event-driven controls
  - `HumanoidPoseSettings` exposes grouped sliders (e.g., Standing, CurlInOut, per-limb, fingers)
  - On-change events automatically propagate to the `HumanoidMuscleController`
- One-click actions
  - `[Button] ApplyPose` writes all configured muscles at once
  - `[Button] ResetPose` resets all muscles to neutral (0)
- Flexible APIs
  - Set muscles by enum, index, or Unity muscle name string
  - `PrintAllMuscles()` utility to list indices and names
- Runtime-ready
  - Ships with a runtime asmdef: `UnityEssentials.HumanoidPoseController.asmdef`

## Requirements
- Unity Editor 6000.0+
- A valid Humanoid `Avatar` assigned on `HumanoidMuscleController`
- The GameObject using the controller should be the humanoid root for the avatar pose

## Usage
1) Add the components
   - Create a GameObject (e.g., `HumanoidPoseRoot`)
   - Add `HumanoidMuscleController` and assign a valid humanoid `Avatar`
   - Add `HumanoidPoseController` (it auto-requires the muscle controller)

2) Configure pose settings
   - In `HumanoidPoseController`, adjust the exposed `HumanoidPoseSettings` fields
   - Use grouped controls like `Standing`, `CurlInOut`, fingers stretch/spread (left/right)
   - Changes fire events that update the underlying muscles in real time

3) Apply or reset
   - Click `ApplyPose` to explicitly write all muscles from the current settings
   - Click `ResetPose` to return all muscles to neutral (0)

4) Drive from code (optional)
   - You can set values at runtime and they’ll propagate via the settings event:
     ```csharp
     var ctrl = GetComponent<HumanoidPoseController>();
     // Example: tweak a setting, which triggers the bound event
     // ctrl.PoseSettings.LeftArmDownUp = 0.5f; // if you expose a getter
     // or call the muscle controller directly
     GetComponent<HumanoidMuscleController>().SetMuscle((int)HumanBodyMuscles.LeftArmDownUp, 0.5f);
     ```

## How It Works
- `HumanoidMuscleController`
  - Wraps Unity’s `HumanPoseHandler` to read/write `HumanPose.muscles`
  - Provides `SetMuscle` overloads (by enum/index/name), clamps values, and validates indices
- `HumanoidPoseSettings`
  - Holds all sliders and grouped controls for body, limbs, fingers, head/face
  - Uses on-change methods to invoke `SetMuscleEvent(index, value)` for the correct muscle(s)
  - Includes composite controls like `Standing` and `CurlInOut` that drive multiple related muscles
- `HumanoidPoseController`
  - Initializes and wires `SetMuscleEvent` to the muscle controller in `Start()`
  - Provides `[Button]` methods: `ApplyPose()` to set all key muscles, and `ResetPose()` to zero them
- `HumanBodyMuscles` enum
  - Enumerates the Unity muscle indices for clear, readable references

## Notes and Limitations
- Avatar requirement: The assigned `Avatar` must be humanoid; otherwise initialization fails (logged error)
- Muscle indices: Internally map to Unity’s `HumanTrait.MuscleName` order; custom rigs or different Unity versions should still align with humanoid mapping
- Performance: Frequent calls use `GetHumanPose`/`SetHumanPose`; batch writes (ApplyPose) are efficient for snapshots
- Inspector attributes: Uses `Foldout`, `Button`, and `OnValueChanged` attributes from UnityEssentials for a nicer inspector; if missing, functionality works but grouping/buttons won’t render

## Files in This Package
- `Runtime/HumanoidPoseController.cs` – Wires settings to muscles and exposes Apply/Reset
- `Runtime/HumanoidPoseSettings.cs` – Grouped sliders and on-change events for pose authoring
- `Runtime/HumanoidMuscleController.cs` – HumanPoseHandler wrapper (set by enum/index/name, reset, print)
- `Runtime/HumanoidMuscles.cs` – Enum mapping of Unity muscle indices
- `Runtime/UnityEssentials.HumanoidPoseController.asmdef` – Runtime assembly definition

## Tags
unity, humanoid, avatar, muscles, humanpose, pose, animation, runtime, inspector, sliders
