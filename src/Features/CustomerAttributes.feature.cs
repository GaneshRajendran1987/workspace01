﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace src.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Customer Attributes")]
    public partial class CustomerAttributesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomerAttributes.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Customer Attributes", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CA002 Existing customer has no orders, (exists in silver.DimCustomerAttributes wi" +
            "th default values), now has new order")]
        public virtual void CA002ExistingCustomerHasNoOrdersExistsInSilver_DimCustomerAttributesWithDefaultValuesNowHasNewOrder()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CA002 Existing customer has no orders, (exists in silver.DimCustomerAttributes wi" +
                    "th default values), now has new order", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 3
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
        testRunner.Given("the table \'DimCustomerAccountAttributes\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
        testRunner.And("the table \'DimCustomerAttributes\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 6
        testRunner.And("the table \'DimCustomerAccount\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimLatestCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "FirstOrderDimBilledDateSKey [int]",
                            "FirstOrderDimShippedDateSKey [int]",
                            "FirstOrderDimCustomerAgeSKey [int]",
                            "FirstOrderCustomerAge [int]",
                            "FirstOrderDimAffiliateSKey [int]",
                            "FirstOrderDimDiscountSKey [int]",
                            "FirstOrderDimOrderCreatedDateSKey [int]",
                            "FirstOrderDimOrderCreatedTimeSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table1.AddRow(new string[] {
                            "No orders",
                            "1",
                            "-1",
                            "UNK",
                            "-1",
                            "-1",
                            "-1",
                            "0",
                            "-1",
                            "-1",
                            "-1",
                            "-1",
                            "0"});
#line 7
        testRunner.And("the table \'DimCustomerAttributes\' on the workbench contains the data:", ((string)(null)), table1, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "FirstOrderDimOrderCreatedDateSKey [int]",
                            "FirstOrderDimOrderCreatedTimeSKey [int]",
                            "FirstOrderDimBilledDateSKey [int]",
                            "FirstOrderDimShippedDateSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table2.AddRow(new string[] {
                            "Existing Customer with 1 new order",
                            "1",
                            "1",
                            "Ref1",
                            "20190104",
                            "1",
                            "20190104",
                            "20190104",
                            "1"});
#line 10
        testRunner.And("the table \'DimCustomerAccountAttributes\' on the workbench contains the data:", ((string)(null)), table2, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimCustomerAccountSKey [int]",
                            "DimLatestCustomerAccountSKey [int]"});
                table3.AddRow(new string[] {
                            "",
                            "1",
                            "1"});
#line 13
        testRunner.And("the table \'DimCustomerAccount\' on the workbench contains the data:", ((string)(null)), table3, "And ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "ParameterName",
                            "Value",
                            "Type"});
                table4.AddRow(new string[] {
                            "TriggerId",
                            "12345678-1234-1234-1234-123456789123",
                            "System.String"});
                table4.AddRow(new string[] {
                            "RunId",
                            "12345678-1234-1234-1234-123456789123",
                            "System.String"});
#line 16
        testRunner.When("the \'PopulateDimCustomerAttributes\' proc with params on workbench is executed:", ((string)(null)), table4, "When ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimLatestCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "Last24MonthsOrderCount [int]"});
                table5.AddRow(new string[] {
                            "Updated record with 1 new order",
                            "1",
                            "1",
                            "Ref1",
                            "1"});
#line 20
        testRunner.Then("the table \'DimCustomerAttributes\' on the workbench should only contain the data w" +
                        "ithout strict ordering:", ((string)(null)), table5, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CA003 Existing customer with 1 order in DimCustomerAttributes gets the second ord" +
            "er in DimCustomerAccountAttributes")]
        public virtual void CA003ExistingCustomerWith1OrderInDimCustomerAttributesGetsTheSecondOrderInDimCustomerAccountAttributes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CA003 Existing customer with 1 order in DimCustomerAttributes gets the second ord" +
                    "er in DimCustomerAccountAttributes", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
     this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
        testRunner.Given("the table \'DimCustomerAccountAttributes\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
        testRunner.And("the table \'DimCustomerAttributes\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
        testRunner.And("the table \'DimCustomerAccount\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimLatestCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "FirstOrderDimBilledDateSKey [int]",
                            "FirstOrderDimShippedDateSKey [int]",
                            "FirstOrderDimCustomerAgeSKey [int]",
                            "FirstOrderCustomerAge [int]",
                            "FirstOrderDimAffiliateSKey [int]",
                            "FirstOrderDimDiscountSKey [int]",
                            "FirstOrderDimOrderCreatedDateSKey [int]",
                            "FirstOrderDimOrderCreatedTimeSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table6.AddRow(new string[] {
                            "Updated record with 1 new order",
                            "1",
                            "1",
                            "Ref1",
                            "20190104",
                            "20190104",
                            "1",
                            "26",
                            "-1",
                            "-1",
                            "1",
                            "1",
                            "1"});
#line 28
        testRunner.And("the table \'DimCustomerAttributes\' on the workbench contains the data:", ((string)(null)), table6, "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "FirstOrderDimOrderCreatedDateSKey [int]",
                            "FirstOrderDimOrderCreatedTimeSKey [int]",
                            "FirstOrderDimBilledDateSKey [int]",
                            "FirstOrderDimShippedDateSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table7.AddRow(new string[] {
                            "Existing Customer with first order",
                            "1",
                            "1",
                            "Ref1",
                            "20190104",
                            "1",
                            "20190104",
                            "20190104",
                            "1"});
                table7.AddRow(new string[] {
                            "Existing Customer with 2nd new order",
                            "1",
                            "2",
                            "Ref2",
                            "20190105",
                            "1",
                            "20190105",
                            "20190105",
                            "1"});
                table7.AddRow(new string[] {
                            "Existing Customer with 3rd new order",
                            "1",
                            "3",
                            "Ref3",
                            "20190106",
                            "1",
                            "20190106",
                            "20190106",
                            "1"});
#line 31
        testRunner.And("the table \'DimCustomerAccountAttributes\' on the workbench contains the data:", ((string)(null)), table7, "And ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimCustomerAccountSKey [int]",
                            "DimLatestCustomerAccountSKey [int]"});
                table8.AddRow(new string[] {
                            "",
                            "1",
                            "1"});
#line 36
        testRunner.And("the table \'DimCustomerAccount\' on the workbench contains the data:", ((string)(null)), table8, "And ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "ParameterName",
                            "Value",
                            "Type"});
                table9.AddRow(new string[] {
                            "TriggerId",
                            "12345678-1234-1234-1234-123456789124",
                            "System.String"});
                table9.AddRow(new string[] {
                            "RunId",
                            "12345678-1234-1234-1234-123456789124",
                            "System.String"});
#line 39
        testRunner.When("the \'PopulateDimCustomerAttributes\' proc with params on workbench is executed:", ((string)(null)), table9, "When ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimLatestCustomerAccountSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table10.AddRow(new string[] {
                            "Updated record with 2nd new order",
                            "1",
                            "3"});
#line 43
        testRunner.Then("the table \'DimCustomerAttributes\' on the workbench should have \'Last24MonthsOrder" +
                        "Count\' aggregated across mutiple orders:", ((string)(null)), table10, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CA004 Existing customer has no orders, (exists in silver.DimCustomerAttributes wi" +
            "th default values), now has multiple orders across different accounts (A1,A2,A3)" +
            "")]
        public virtual void CA004ExistingCustomerHasNoOrdersExistsInSilver_DimCustomerAttributesWithDefaultValuesNowHasMultipleOrdersAcrossDifferentAccountsA1A2A3()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CA004 Existing customer has no orders, (exists in silver.DimCustomerAttributes wi" +
                    "th default values), now has multiple orders across different accounts (A1,A2,A3)" +
                    "", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 47
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 48
        testRunner.Given("the table \'DimCustomerAccountAttributes\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 49
        testRunner.And("the table \'DimCustomerAttributes\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
        testRunner.And("the table \'DimCustomerAccount\' on the workbench is truncated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimLatestCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "FirstOrderDimBilledDateSKey [int]",
                            "FirstOrderDimShippedDateSKey [int]",
                            "FirstOrderDimCustomerAgeSKey [int]",
                            "FirstOrderCustomerAge [int]",
                            "FirstOrderDimAffiliateSKey [int]",
                            "FirstOrderDimDiscountSKey [int]",
                            "FirstOrderDimOrderCreatedDateSKey [int]",
                            "FirstOrderDimOrderCreatedTimeSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table11.AddRow(new string[] {
                            "No orders",
                            "1",
                            "-1",
                            "UNK",
                            "-1",
                            "-1",
                            "-1",
                            "0",
                            "-1",
                            "-1",
                            "-1",
                            "-1",
                            "0"});
#line 51
        testRunner.And("the table \'DimCustomerAttributes\' on the workbench contains the data:", ((string)(null)), table11, "And ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "FirstOrderDimOrderCreatedDateSKey [int]",
                            "FirstOrderDimOrderCreatedTimeSKey [int]",
                            "FirstOrderDimBilledDateSKey [int]",
                            "FirstOrderDimShippedDateSKey [int]",
                            "Last24MonthsOrderCount [int]"});
                table12.AddRow(new string[] {
                            "Existing Customer with Account 1 with Order Ref1",
                            "1",
                            "1",
                            "Ref1",
                            "20190104",
                            "1",
                            "20190104",
                            "20190104",
                            "1"});
                table12.AddRow(new string[] {
                            "Existing Customer with Account 2 with Order Ref2",
                            "2",
                            "2",
                            "Ref2",
                            "20190105",
                            "1",
                            "20190105",
                            "20190105",
                            "1"});
                table12.AddRow(new string[] {
                            "Existing Customer with Account 2 with Order Ref3",
                            "2",
                            "3",
                            "Ref3",
                            "20200106",
                            "1",
                            "20200106",
                            "20200106",
                            "1"});
                table12.AddRow(new string[] {
                            "Existing Customer with Account 2 with Order Ref4",
                            "2",
                            "4",
                            "Ref4",
                            "20200107",
                            "1",
                            "20200107",
                            "20200107",
                            "1"});
                table12.AddRow(new string[] {
                            "Existing Customer with Account 3 with Order Ref5",
                            "3",
                            "5",
                            "Ref5",
                            "20210108",
                            "1",
                            "20210108",
                            "20210108",
                            "1"});
                table12.AddRow(new string[] {
                            "Existing Customer with Account 3 with Order Ref6",
                            "3",
                            "6",
                            "Ref6",
                            "20220109",
                            "1",
                            "20220109",
                            "20220109",
                            "1"});
#line 54
        testRunner.And("the table \'DimCustomerAccountAttributes\' on the workbench contains the data:", ((string)(null)), table12, "And ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimCustomerAccountSKey [int]",
                            "DimLatestCustomerAccountSKey [int]"});
                table13.AddRow(new string[] {
                            "",
                            "1",
                            "1"});
                table13.AddRow(new string[] {
                            "",
                            "2",
                            "1"});
                table13.AddRow(new string[] {
                            "",
                            "3",
                            "1"});
#line 62
        testRunner.And("the table \'DimCustomerAccount\' on the workbench contains the data:", ((string)(null)), table13, "And ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "ParameterName",
                            "Value",
                            "Type"});
                table14.AddRow(new string[] {
                            "TriggerId",
                            "12345678-1234-1234-1234-123456789125",
                            "System.String"});
                table14.AddRow(new string[] {
                            "RunId",
                            "12345678-1234-1234-1234-123456789125",
                            "System.String"});
#line 67
        testRunner.When("the \'PopulateDimCustomerAttributes\' proc with params on workbench is executed:", ((string)(null)), table14, "When ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comment",
                            "DimLatestCustomerAccountSKey [int]",
                            "FirstOrderReceiptID [int]",
                            "FirstOrderCustomerOrderReference [nvarchar]",
                            "Last24MonthsOrderCount [int]"});
                table15.AddRow(new string[] {
                            "Updated record with 6  orders",
                            "1",
                            "1",
                            "Ref1",
                            "6"});
#line 71
        testRunner.Then("the table \'DimCustomerAttributes\' on the workbench should have \'Last24MonthsOrder" +
                        "Count\' aggregated across mutiple Accounts and orders:", ((string)(null)), table15, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
