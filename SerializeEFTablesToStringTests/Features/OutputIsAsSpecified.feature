#@ignore
Feature: OutputIsAsSpecified
	To ensure that entities are rendered as specified 
	by the paramters 


Scenario: Set up
	Given the core DB is cleared
	And a set of policies have been created
| Number | policy_number | party_unique_ref             | party_row_id | firstname | surname    | gender | date_of_birth | product_component_code | PolicyComponentSequence | policy_component_id | product_code | uw_decision_id | user_id | user_name         | email                 | password     | sum_assured | insured_term | quoted_amount | requested_start_date   | calculated_total_premium | calculated_base_premium | payment_frequency | IBAN                   | risk_type_code | entry_age | last_usi_id | last_usi |
| 1      | 100000001B    | ANNETTMÜLLER19961119001      | 1            | Annett    | Müller     | Frau   | 1996-11-19    | TERM_LIFE_01           | 1                       | 1                   | CL01         | 1              | 100001  | AnnettMüller      | AnnettMüller@a.b      | password0001 | 10000       | 35           | 100           | 2016/10/31 12:00:00 AM | 100                      | 100                     | 12                | DE39473544398981200114 | NONE           | 19        | 1           | 1        |
| 2      | 100000002C    | ANTJESCHMIDT19951120001      | 2            | Antje     | Schmidt    | Frau   | 1995-11-20    | TERM_LIFE_01           | 1                       | 2                   | CL01         | 2              | 100002  | AntjeSchmidt      | AntjeSchmidt@a.b      | password0001 | 20000       | 35           | 200           | 2016/04/09 12:00:00 AM | 200                      | 200                     | 4                 | DE59504743126299026145 | NONE           | 20        | 2           | 2        |
| 3      | 100000003D    | BARBARASCHNEIDER19941120001  | 3            | Barbara   | Schneider  | Frau   | 1994-11-20    | TERM_LIFE_01           | 1                       | 3                   | CL01         | 3              | 100003  | BarbaraSchneider  | BarbaraSchneider@a.b  | password0001 | 30000       | 35           | 300           | 2016/03/28 12:00:00 AM | 300                      | 300                     | 2                 | DE51370717347636311886 | NONE           | 21        | 3           | 3        |
| 4      | 100000004E    | BIRGITFISCHER19931120001     | 4            | Birgit    | Fischer    | Frau   | 1993-11-20    | TERM_LIFE_01           | 1                       | 4                   | CL01         | 4              | 100004  | BirgitFischer     | BirgitFischer@a.b     | password0001 | 40000       | 35           | 400           | 2016/10/07 12:00:00 AM | 400                      | 400                     | 1                 | DE55412159066008472295 | NONE           | 22        | 4           | 4        |
| 5      | 100000005F    | BRIGITTEWEBER19921120001     | 5            | Brigitte  | Weber      | Frau   | 1992-11-20    | TERM_LIFE_01           | 1                       | 5                   | CL01         | 5              | 100005  | BrigitteWeber     | BrigitteWeber@a.b     | password0001 | 50000       | 35           | 500           | 2016/01/31 12:00:00 AM | 500                      | 500                     | 12                | DE50214683394118609559 | NONE           | 23        | 5           | 5        |

Scenario: Policy_Option is rendered correctly
	Given a parameter string "Policy_Option[!policy_option_id]"
	Then the output should be correct

Scenario: : Policy_Component and  Policy Option Rendered Correctly
	Given a parameter string "Policy_Component[!policy_component_id;last_usi_id],Policy_Option[policy_number;product_component_code]"
	Then the output should be correct

	
