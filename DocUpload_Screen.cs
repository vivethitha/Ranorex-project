﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SubmissionCase_E2E
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DocUpload_Screen recording.
    /// </summary>
    [TestModule("1bba4b94-74bf-487d-801d-45aed35114da", ModuleType.Recording, 1)]
    public partial class DocUpload_Screen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static DocUpload_Screen instance = new DocUpload_Screen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DocUpload_Screen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DocUpload_Screen Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.LabelTagYes'", repo.ApplicationUnderTest.LabelTagYesInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.LabelTagYesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CompleteThisAssignment' at 50;15.", repo.ApplicationUnderTest.CompleteThisAssignmentInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CompleteThisAssignment.Click("50;15");
            Delay.Milliseconds(200);
            
            // Validation Start
            Report.Log(ReportLevel.Info, "Section", "Validation Start", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'ApplicationUnderTest.KindlyUploadTheDocumentToProceed'", repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo, new ActionTimeout(20000), new RecordItemIndex(3));
            repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Kindly upload the document to Proceed') on item 'ApplicationUnderTest.KindlyUploadTheDocumentToProceed'.", repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo, "InnerText", "Kindly upload the document to Proceed");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='New-Submission') on item 'ApplicationUnderTest.NewSubmission'.", repo.ApplicationUnderTest.NewSubmissionInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.NewSubmissionInfo, "InnerText", "New-Submission");
            Delay.Milliseconds(100);
            
            // Validaion End
            Report.Log(ReportLevel.Info, "Section", "Validaion End", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabelTagYes' at 13;10.", repo.ApplicationUnderTest.LabelTagYesInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.LabelTagYes.Click("13;10");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(9));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CompleteThisAssignment' at 50;15.", repo.ApplicationUnderTest.CompleteThisAssignmentInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.CompleteThisAssignment.Click("50;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
