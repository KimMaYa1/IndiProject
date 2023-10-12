using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class PlayerAnimationData
{
    [SerializeField] private string groundParmeterName = "@Ground";
    [SerializeField] private string idleParmeterName = "Idle";
    [SerializeField] private string walkParmeterName = "Walk";
    [SerializeField] private string runParmeterName = "Run";

    [SerializeField] private string airParmeterName = "@Air";
    [SerializeField] private string jumpParmeterName = "Jump";
    [SerializeField] private string fallParmeterName = "Fall";

    [SerializeField] private string attackParmeterName = "@Attack";
    [SerializeField] private string baseAttackParmeterName = "BaseAttack";
    [SerializeField] private string comboAttackParmeterName = "ComboAttack";

    public int GroundParameterHash { get; private set; }
    public int IdleParameterHash { get; private set; }
    public int WalkParameterHash { get; private set; }
    public int RunParameterHash { get; private set; }
    public int AirParameterHash { get; private set; }
    public int JumpParameterHash { get; private set; }
    public int FallParameterHash { get; private set; }
    public int AttackParameterHash { get; private set; }
    public int ComboAttackParameterHash { get; private set; }
    public int BaseAttackParameterHash { get; private set; }

    public void Initialize()
    {
        GroundParameterHash = Animator.StringToHash(groundParmeterName);
        IdleParameterHash = Animator.StringToHash(idleParmeterName);
        WalkParameterHash = Animator.StringToHash(walkParmeterName);
        RunParameterHash = Animator.StringToHash(runParmeterName);
        AirParameterHash = Animator.StringToHash(airParmeterName);
        JumpParameterHash = Animator.StringToHash(jumpParmeterName);
        FallParameterHash = Animator.StringToHash(fallParmeterName);
        AttackParameterHash = Animator.StringToHash(attackParmeterName);
        ComboAttackParameterHash = Animator.StringToHash(comboAttackParmeterName);
        BaseAttackParameterHash = Animator.StringToHash(baseAttackParmeterName);
    }
}
