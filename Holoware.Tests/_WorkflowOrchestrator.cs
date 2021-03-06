﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrchestrationModule;
using OrchestrationModule.ApplicationStates;


using Bizmonger.Patterns;

namespace Holoware.Tests
{
    [TestClass]
    public class _WorkflowOrchestrator
    {
        #region Testware
        [TestCleanup]
        public void Cleanup()
        {
            ServiceLocator.Instance.Clear();
        }
        #endregion

        [TestMethod]
        public void initialize_workflow()
        {
            var orchestrator = new WorkflowOrchestrator();
            orchestrator.Initialize();

            var initialState = new StartWorkflowState();
            orchestrator.Execute(initialState);
        }
    }
}