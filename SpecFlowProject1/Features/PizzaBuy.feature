Feature: PizzaBuy

A short summary of the feature

@tag1
Scenario: Buying the Pizza
	Given Navigating to pizza website
	When On clicking Pizza List
	Then Shows Pizza List
	When On clicking Buy Button
	Then Order Checkout Page displays
	When On clicking Confirm Order
	Then Confirmation Page is displayed
