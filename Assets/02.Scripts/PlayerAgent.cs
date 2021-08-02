using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Policies;      // Behaviour Parameters 컴포넌트를 접근하기 위한 네임스페이스

[RequireComponent(typeof(DecisionRequester))]
public class PlayerAgent : Agent
{
    public enum TEAM
    {
        BLUE, RED
    }

    // 플레이어의 팀
    public TEAM team = TEAM.BLUE;

    // Behaviour Parameters
    private BehaviorParameters bps;
}
