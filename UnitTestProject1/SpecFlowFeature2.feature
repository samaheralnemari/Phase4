Feature: SpecFlowFeature2
	Simple calculator for adding two numbers

@mytag
Scenario: TableBill
	Given the following table:
	| id | PizzaType | Price |
	| 1 | Hawaiian | 18 |
	| 2 | Veggie | 18 |
	Then my binding should have the following objects
	| id | PizzaType | Price |
	| 1 | Hawaiian | 18 |
	| 2 | Veggie | 18 |

