# SubscriptionFeeCalculator
Console Application to calculate online registration for a monthly subscription company. 

## Features

1. **Age Fee**:
   - If you are 19 years old or younger, the age fee is $10.
   - If you are between 20 and 29 years old, the age fee is $25.50.
   - If you are between 30 and 59 years old, the age fee is $50.50.
   - Otherwise, there is no age fee.

2. **Start Month Adjustment**:
   - The start month affects the fee:
     - January or February: Deduct $10.
     - March or April: Add 10% of the age fee.
     - May: Add $20.
     - Other months: No adjustment.

3. **Client Referral Discount**:
   - If you have been referred by an existing client (answer "Y" to the question), a discount will be applied.
   - The specific discount amount is not mentioned in this version.
