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
    ///The Adverse2_Driver_Attorney_Details recording.
    /// </summary>
    [TestModule("c251cc70-a9d7-4b78-8ed0-0e6d8bdaa72f", ModuleType.Recording, 1)]
    public partial class Adverse2_Driver_Attorney_Details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse2_Driver_Attorney_Details instance = new Adverse2_Driver_Attorney_Details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse2_Driver_Attorney_Details()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse2_Driver_Attorney_Details Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AttorneyDetails' at 67;26.", repo.ApplicationUnderTest.AttorneyDetailsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AttorneyDetails.Click("67;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_Attorney_FirmName' with focus on 'ApplicationUnderTest.AD2_Attorney_FirmName'.", repo.ApplicationUnderTest.AD2_Attorney_FirmNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AD2_Attorney_FirmName.PressKeys("AD2_Attorney_FirmName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_Attorney_FirstName' with focus on 'ApplicationUnderTest.AD2_Attorney_FirstName'.", repo.ApplicationUnderTest.AD2_Attorney_FirstNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AD2_Attorney_FirstName.PressKeys("AD2_Attorney_FirstName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_Attorney_LastName' with focus on 'ApplicationUnderTest.AD2_Attorney_LastName'.", repo.ApplicationUnderTest.AD2_Attorney_LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AD2_Attorney_LastName.PressKeys("AD2_Attorney_LastName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_Attorney_Address1' with focus on 'ApplicationUnderTest.AD2_Attorney_Address1'.", repo.ApplicationUnderTest.AD2_Attorney_Address1Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.AD2_Attorney_Address1.PressKeys("AD2_Attorney_Address1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_Attorney_Address2' with focus on 'ApplicationUnderTest.AD2_Attorney_Address2'.", repo.ApplicationUnderTest.AD2_Attorney_Address2Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AD2_Attorney_Address2.PressKeys("AD2_Attorney_Address2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_Attorney_City' with focus on 'ApplicationUnderTest.AD2_Attorney_City'.", repo.ApplicationUnderTest.AD2_Attorney_CityInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD2_Attorney_City.PressKeys("AD2_Attorney_City");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'LA' on item 'ApplicationUnderTest.AD2_Attorney_State'.", repo.ApplicationUnderTest.AD2_Attorney_StateInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AD2_Attorney_State.Element.SetAttributeValue("TagValue", "LA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(8));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '112233445' with focus on 'ApplicationUnderTest.AD2_Attorney_Zip'.", repo.ApplicationUnderTest.AD2_Attorney_ZipInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AD2_Attorney_Zip.PressKeys("112233445");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'attorney3@gmail.com' with focus on 'ApplicationUnderTest.AD2_Attorney_Email'.", repo.ApplicationUnderTest.AD2_Attorney_EmailInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AD2_Attorney_Email.PressKeys("attorney3@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '03/02/2019' on item 'ApplicationUnderTest.AD2_Attorney_RepDate'.", repo.ApplicationUnderTest.AD2_Attorney_RepDateInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AD2_Attorney_RepDate.Element.SetAttributeValue("TagValue", "03/02/2019");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(13));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(14));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Personal' on item 'ApplicationUnderTest.AD2_AD_UseType'.", repo.ApplicationUnderTest.AD2_AD_UseTypeInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.AD2_AD_UseType.Element.SetAttributeValue("TagValue", "Personal");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Cell' on item 'ApplicationUnderTest.AD2_AD_PhoneType'.", repo.ApplicationUnderTest.AD2_AD_PhoneTypeInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.AD2_AD_PhoneType.Element.SetAttributeValue("TagValue", "Cell");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Caller ID' on item 'ApplicationUnderTest.AD2_AD_Source'.", repo.ApplicationUnderTest.AD2_AD_SourceInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.AD2_AD_Source.Element.SetAttributeValue("TagValue", "Caller ID");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9500095006' with focus on 'ApplicationUnderTest.AD2_AD_PhoneNumber'.", repo.ApplicationUnderTest.AD2_AD_PhoneNumberInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.AD2_AD_PhoneNumber.PressKeys("9500095006");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(20));
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence '{Tab}'.", new RecordItemIndex(21));
                Keyboard.Press("{Tab}");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 46;15.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(22));
            repo.ApplicationUnderTest.SubmitButton1.Click("46;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}