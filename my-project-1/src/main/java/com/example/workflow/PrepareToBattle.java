package com.example.workflow;

import org.camunda.bpm.engine.delegate.DelegateExecution;
import org.camunda.bpm.engine.delegate.JavaDelegate;
import org.springframework.stereotype.Component;

@Component
public class PrepareToBattle implements org.camunda.bpm.engine.delegate.JavaDelegate {
    @Override
    public void execute(DelegateExecution delegateExecution) throws Exception {
        int eW = (int) 100;
        String bStatus = "Un";
        delegateExecution.setVariable("enemyWarrious", eW);
        delegateExecution.setVariable("battleStatus", bStatus);
    }
}
