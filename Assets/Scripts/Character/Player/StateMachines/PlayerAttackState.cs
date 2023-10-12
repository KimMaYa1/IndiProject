using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerBaseState
{
    public PlayerAttackState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.MovementSpeedModifier = 0;
        base.Enter();

        StartAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
        //플레이어는 공격할때 데미지를 못주는게 웨폰에 데미지를 부여해주지 않아서임 여기서 업데이트로 적과 똑같이 부여해야할듯
        //stateMachine.Player.Weapon.SetAttack(stateMachine.Player.Data.AttackData.GetAttackInfo(stateMachine.Player.Data.AttackData.GetAttackInfoCount()).Damage, stateMachine.Player.Data.AttackData.GetAttackInfo(stateMachine.Player.Data.AttackData.GetAttackInfoCount()).Force);
    }

    public override void Exit()
    {
        base.Exit();

        StopAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
    }
}
