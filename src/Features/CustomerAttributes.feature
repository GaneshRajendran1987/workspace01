Feature: Customer Attributes

    Scenario: CA002 Existing customer has no orders, (exists in silver.DimCustomerAttributes with default values), now has new order
        Given the table 'DimCustomerAccountAttributes' on the workbench is truncated
        And the table 'DimCustomerAttributes' on the workbench is truncated
        And the table 'DimCustomerAccount' on the workbench is truncated
        And the table 'DimCustomerAttributes' on the workbench contains the data:
            | Comment   | DimLatestCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | FirstOrderDimBilledDateSKey [int] | FirstOrderDimShippedDateSKey [int] | FirstOrderDimCustomerAgeSKey [int] | FirstOrderCustomerAge [int] | FirstOrderDimAffiliateSKey [int] | FirstOrderDimDiscountSKey [int] | FirstOrderDimOrderCreatedDateSKey [int] | FirstOrderDimOrderCreatedTimeSKey [int] | Last24MonthsOrderCount [int] |
            | No orders | 1                                  | -1                        | UNK                                         | -1                                | -1                                 | -1                                 | 0                           | -1                               | -1                              | -1                                      | -1                                      | 0                            |
        And the table 'DimCustomerAccountAttributes' on the workbench contains the data:
            | Comment                            | DimCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | FirstOrderDimOrderCreatedDateSKey [int] | FirstOrderDimOrderCreatedTimeSKey [int] | FirstOrderDimBilledDateSKey [int] | FirstOrderDimShippedDateSKey [int] | Last24MonthsOrderCount [int] |
            | Existing Customer with 1 new order | 1                            | 1                         | Ref1                                        | 20190104                                | 1                                       | 20190104                          | 20190104                           | 1                            |
        And the table 'DimCustomerAccount' on the workbench contains the data:
            | Comment | DimCustomerAccountSKey [int] | DimLatestCustomerAccountSKey [int] |
            |         | 1                            | 1                                  |
        When the 'PopulateDimCustomerAttributes' proc with params on workbench is executed:
            | ParameterName | Value                                | Type          |
            | TriggerId     | 12345678-1234-1234-1234-123456789123 | System.String |
            | RunId         | 12345678-1234-1234-1234-123456789123 | System.String |
        Then the table 'DimCustomerAttributes' on the workbench should only contain the data without strict ordering:
            | Comment                         | DimLatestCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | Last24MonthsOrderCount [int] |
            | Updated record with 1 new order | 1                                  | 1                         | Ref1                                        | 1                            |

     Scenario: CA003 Existing customer with 1 order in DimCustomerAttributes gets the second order in DimCustomerAccountAttributes
        Given the table 'DimCustomerAccountAttributes' on the workbench is truncated
        And the table 'DimCustomerAttributes' on the workbench is truncated
        And the table 'DimCustomerAccount' on the workbench is truncated
        And the table 'DimCustomerAttributes' on the workbench contains the data:
            | Comment                         | DimLatestCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | FirstOrderDimBilledDateSKey [int] | FirstOrderDimShippedDateSKey [int] | FirstOrderDimCustomerAgeSKey [int] | FirstOrderCustomerAge [int] | FirstOrderDimAffiliateSKey [int] | FirstOrderDimDiscountSKey [int] | FirstOrderDimOrderCreatedDateSKey [int] | FirstOrderDimOrderCreatedTimeSKey [int] | Last24MonthsOrderCount [int] |
            | Updated record with 1 new order | 1                                  | 1                         | Ref1                                        | 20190104                          | 20190104                           | 1                                  | 26                          | -1                               | -1                              | 1                                       | 1                                       | 1                            |
        And the table 'DimCustomerAccountAttributes' on the workbench contains the data:
            | Comment                            | DimCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | FirstOrderDimOrderCreatedDateSKey [int] | FirstOrderDimOrderCreatedTimeSKey [int] | FirstOrderDimBilledDateSKey [int] | FirstOrderDimShippedDateSKey [int] | Last24MonthsOrderCount [int] |
            | Existing Customer with first order | 1                            | 1                         | Ref1                                        | 20190104                                | 1                                       | 20190104                          | 20190104                           | 1                            |
            | Existing Customer with 2nd new order | 1                            | 2                         | Ref2                                        | 20190105                                | 1                                       | 20190105                          | 20190105                           | 1                            |
            | Existing Customer with 3rd new order | 1                            | 3                         | Ref3                                        | 20190106                                | 1                                       | 20190106                          | 20190106                           | 1                            |
        And the table 'DimCustomerAccount' on the workbench contains the data:
            | Comment | DimCustomerAccountSKey [int] | DimLatestCustomerAccountSKey [int] |
            |         | 1                            | 1                                  |
        When the 'PopulateDimCustomerAttributes' proc with params on workbench is executed:
            | ParameterName | Value                                | Type          |
            | TriggerId     | 12345678-1234-1234-1234-123456789124 | System.String |
            | RunId         | 12345678-1234-1234-1234-123456789124 | System.String |
        Then the table 'DimCustomerAttributes' on the workbench should have 'Last24MonthsOrderCount' aggregated across mutiple orders:
            | Comment                         | DimLatestCustomerAccountSKey [int] | Last24MonthsOrderCount [int] |
            | Updated record with 2nd new order | 1                                | 3                            |

    Scenario: CA004 Existing customer has no orders, (exists in silver.DimCustomerAttributes with default values), now has multiple orders across different accounts (A1,A2,A3)
        Given the table 'DimCustomerAccountAttributes' on the workbench is truncated
        And the table 'DimCustomerAttributes' on the workbench is truncated
        And the table 'DimCustomerAccount' on the workbench is truncated
        And the table 'DimCustomerAttributes' on the workbench contains the data:
            | Comment   | DimLatestCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | FirstOrderDimBilledDateSKey [int] | FirstOrderDimShippedDateSKey [int] | FirstOrderDimCustomerAgeSKey [int] | FirstOrderCustomerAge [int] | FirstOrderDimAffiliateSKey [int] | FirstOrderDimDiscountSKey [int] | FirstOrderDimOrderCreatedDateSKey [int] | FirstOrderDimOrderCreatedTimeSKey [int] | Last24MonthsOrderCount [int] |
            | No orders | 1                                  | -1                        | UNK                                         | -1                                | -1                                 | -1                                 | 0                           | -1                               | -1                              | -1                                      | -1                                      | 0                            |
        And the table 'DimCustomerAccountAttributes' on the workbench contains the data:
            | Comment                            | DimCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | FirstOrderDimOrderCreatedDateSKey [int] | FirstOrderDimOrderCreatedTimeSKey [int] | FirstOrderDimBilledDateSKey [int] | FirstOrderDimShippedDateSKey [int] | Last24MonthsOrderCount [int] |
            | Existing Customer with Account 1 with Order Ref1 | 1                            | 1                         | Ref1                                        | 20190104                                | 1                                       | 20190104                          | 20190104                           | 1                            |
            | Existing Customer with Account 2 with Order Ref2 | 2                            | 2                         | Ref2                                        | 20190105                                | 1                                       | 20190105                          | 20190105                           | 1                            |
            | Existing Customer with Account 2 with Order Ref3 | 2                            | 3                         | Ref3                                        | 20200106                                | 1                                       | 20200106                          | 20200106                           | 1                            |
            | Existing Customer with Account 2 with Order Ref4 | 2                            | 4                         | Ref4                                        | 20200107                                | 1                                       | 20200107                          | 20200107                           | 1                            |
            | Existing Customer with Account 3 with Order Ref5 | 3                            | 5                         | Ref5                                        | 20210108                                | 1                                       | 20210108                          | 20210108                           | 1                            |
            | Existing Customer with Account 3 with Order Ref6 | 3                            | 6                         | Ref6                                        | 20220109                                | 1                                       | 20220109                          | 20220109                           | 1                            |
        And the table 'DimCustomerAccount' on the workbench contains the data:
            | Comment | DimCustomerAccountSKey [int] | DimLatestCustomerAccountSKey [int] |
            |         | 1                            | 1                                  |
            |         | 2                            | 1                                  |
            |         | 3                            | 1                                  |
        When the 'PopulateDimCustomerAttributes' proc with params on workbench is executed:
            | ParameterName | Value                                | Type          |
            | TriggerId     | 12345678-1234-1234-1234-123456789125 | System.String |
            | RunId         | 12345678-1234-1234-1234-123456789125 | System.String |
        Then the table 'DimCustomerAttributes' on the workbench should have 'Last24MonthsOrderCount' aggregated across mutiple Accounts and orders:
            | Comment                         | DimLatestCustomerAccountSKey [int] | FirstOrderReceiptID [int] | FirstOrderCustomerOrderReference [nvarchar] | Last24MonthsOrderCount [int] |
            | Updated record with 6  orders   | 1                                  | 1                         | Ref1                                        | 6                            |