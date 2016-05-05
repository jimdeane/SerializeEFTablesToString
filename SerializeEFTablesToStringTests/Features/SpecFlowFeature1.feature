Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
| [policy_component_id] | [policy_number] | [product_component_code] | [product_code] | [product_option_code] | [status] | [status_change_date] | [start_date] | [end_date] | [expected_start_date] | [date_created] | [premium_amount] | [benefit_amount] | [retirement_age] | [quote_id] | [additional_premium_component] | [payment_frequency] | [sum_assured] | [insured_term] | [additional_nominal_charge] | [additional_multiplicative_charge] | [smoker] | [occupation_class] | [requested_start_date] |
| 1                     | 100000001B      | TERM_LIFE_01             | CL01           | NONE                  | PENDING  | 2016-05-05           | 2016-10-31   | NULL       | NULL                  | 2016-05-05     | 100.00           | 0.00             | NULL             | NULL       | 0.00                           | 12                  | 50000.00      | 35.00          | NULL                        | NULL                               | NULL     | NULL               | 2016-10-31             |
