Feature: AddToCart

It will add the selected pizza to your cart

@tag1
Scenario: Adding Pizza to the Cart 
	Given Navigate to pizza website
	When On clicking Pizza List button 
	Then Displays lists of Pizza page
	When On clicking a Pizza's Buy button
	Then Order Checkout Page will be opened
	Then Checking the Pizza name if it is similar to the added Pizza name
