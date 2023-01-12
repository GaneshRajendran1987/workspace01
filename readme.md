# Setup Instructions

This repo has been setup to leverage **VS Code .devcontainers**, please complete the following instructions

## Install Docker
- https://code.visualstudio.com/docs/remote/containers#_installation

## Open this folder in dev container
This will take some time the first time as it needs to download the images
- https://code.visualstudio.com/docs/remote/containers#_quick-start-open-an-existing-folder-in-a-container

## Next Steps
After the container is created you should be presented with a terminal running inside the container, if not just open a new bash terminal in the container that looks like this.

`root ➜ /workspace $`

Execute the following command

`./setupDb.sh`

If everything worked you should get this output
```
Changed database context to 'master'.
Changed database context to 'DataservicesTest'.
DATABASE SETUP COMPLETE :)
```

You can now run the tests by executing
```
cd src/
dotnet test
```

# Tests

## Scenario 1 (Fixing a bug)
You will have 1 failing test that needs to be fixed. The bug is with the test feature and not the stored procedure, helpers or framework code. The expected results is correct.

## Scenario 2 (Adding a new test)
```
Given the customer already exists in DimCustomerAttributes
And a new order is place within the last 24 months
Then the Last 24 Month Order Count is 2
```

## Scenario 3 (Adding a new test)
```
Given a customer had multiple accounts over a period
And the different accounts have been grouped in DimCustomerAccount
Then all orders of the same customer (across accounts) are aggregated together
```
## Additional scenarios
Use anytime that you have left to document any additional testing scenarios you feel appropriate, there is no requirement to implement the code for these additional tests.

# Debugging
If you would like to use breakpoints and debug the code you can use the **.NET Core Attach to Test Host** launch task in the debug panel.

This will start the test host and wait for the debugger to attach. You will see the following in your output; Make a note of the **Process Id**

```
Host debugging is enabled. Please attach debugger to testhost process to continue.
Process Id: 10976, Name: dotnet
```
As soon as this output is visible you will be provided with a Process Picker dropdown. Select the process with the same id as the Process Id in the output. In this case it would have been 10976

## Additional Scenarios
## Scenario 1 
```
Given a customer have duplicate orders in DimCustomerAccountAttributes
Then all orders of the same customer are aggregated together after deduplication of orders
```

## Scenario 2
```
Given a customer have no orders in DimCustomerAccountAttributes
Then customer should have an entry in DimCustomeAttributes with default values
```

## Scenario 3
```
Given mutiple customer records in DimCustomerAccountAttributes with orders
Then all customers should be populated in DimCustomeAttributes by aggregating the Ordercount across Accounts & Orders
```

## Scenario 4
```
Given a customer have records in DimCustomerAccountAttributes with NULL values
And matching customer record not available in DimCustomerAccount
Then customer record should be populated in DimCustomeAttributes with default values
```

## Scenario 5
```
Given a new customer record present in DimCustomerAccountAttributes with orders
And matching customer record not available in DimCustomerAccount
Then customer record should not be populated in DimCustomeAttributes
```

## Scenario 5
```
Given a new customer record present in DimCustomerAccountAttributes with orders
And two matching customer record present in DimCustomerAccount (Shared Account - Account mapped with 2 customer record)
Then two customer record should be populated in DimCustomeAttributes with Ordercount aggregated
```