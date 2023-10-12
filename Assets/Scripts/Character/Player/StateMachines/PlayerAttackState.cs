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
        //�÷��̾�� �����Ҷ� �������� ���ִ°� ������ �������� �ο������� �ʾƼ��� ���⼭ ������Ʈ�� ���� �Ȱ��� �ο��ؾ��ҵ�
        //stateMachine.Player.Weapon.SetAttack(stateMachine.Player.Data.AttackData.GetAttackInfo(stateMachine.Player.Data.AttackData.GetAttackInfoCount()).Damage, stateMachine.Player.Data.AttackData.GetAttackInfo(stateMachine.Player.Data.AttackData.GetAttackInfoCount()).Force);
    }

    public override void Exit()
    {
        base.Exit();

        StopAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
    }
}
