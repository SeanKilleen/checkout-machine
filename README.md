# checkout-machine: Can You Spot the Issues?
A toy example checkout machine for certified scrum developer (CSD).

## Spot the Issues!
This solution is imperfect and incomplete -- it differs from what the directions below expect in certain ways. 

Your mission -- should you choose to accept it -- is to refactor this solution toward a better design.

## Problem  
You are a customer at a self-checkout market. You scan the stock keeping unit (SKU) of each product and review the total price you need to pay.

If you have a bonus card, you can scan your bonus card to receive discounts.  

Current deals with the bonus card include 1/2 off `salsa` as well as buy 2, get 1 free `chips`.

There is a 50 cents surcharge for tobacco products.

All scanned products must make a call to a _remote_ inventory control system that logs the scanned products for inventory control purposes (assume a REST webservice call).  

A seperate call is also made to an id verification system that returns whether to prompt for id or not.  

### Products

The store currently sells the following products:

| Name  | SKU  | Price (in cents)    | 
|-------|------|-----------|
| Chips | 123  | 200  |
| Salsa | 456  | 100  |
| Wine  | 1000 | 1000 | 
| Cigarettes | 111 | 500 | 

### Design 
```csharp
public class SelfCheckoutMachine
{
  public void Scan (string sku)
  {
    // scans a single item
  }

  public int Total
  {
    get {
      // returns the total of all scanned
      // items with discounts / taxes applied
    }
  }
 }
```
## Running Tests

Any tests should live in the `CheckoutMachineTests` project.  

To run tests, use the Visual Studio Test Runner or a 3rd-party tool.