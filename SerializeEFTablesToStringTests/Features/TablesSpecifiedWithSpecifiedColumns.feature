Feature: TablesSpecifiedWithSpecifiedColumns
	To allow a list of columns to be specified for each taable
	the syntax for the specification must be allowed to be  list of 
	strings representing the tables required with columns in list 
	between square brackets for example:
		"Policy,Party[party_unique_ref,surname,forename]"
	where all the columns for Policy are required while only three columns for Party are required
	Also "Policy[]" is also allowed meaning all columns

	
Scenario: Simple, one table requesting all columns
	Given a parameter string "Policy_Component"
	Then the required table and Columns should be output 
| table            | columns | isExcludded |
| Policy_Component | *       | false       |

Scenario: Simple, one table with an empty columns list therefore requesting all columns
	Given a parameter string "Policy_Option[]"
	Then the required table and Columns should be output
| table         | columns |	 isExcludded |
| Policy_Option | *       |	 false       |

Scenario: One table with list of columns to include
	Given a parameter string "Policy_Component[product_code;policy_number;policy_component_sequence;product_component_code;start_date;end_date]"
	Then the required table and Columns should be output
| table            | columns                                                                                                   |
| Policy_Component | [product_code],[policy_number],[policy_component_sequence],[product_component_code],[start_date],[end_date] |

Scenario: Two tables one requesting all columns the other a limited set
	Given a parameter string "Policy_Component[],Policy_Option[payment_frequency;sum_assured;insured_term]"
	Then the required table and Columns should be output
| table            | columns                                          | isExcludded |
| Policy_Component | *                                                | false       |
| Policy_Option    | [payment_frequency],[sum_assured],[insured_term] | false       |

Scenario: One table with a list of columns to exclude
	Given a parameter string "Policy_Option[!policy_option_id;policy_component_id;policy_number;product_component_code;product_code;product_option_code;status;status_change_date;start_date;end_date;expected_start_date;date_creat;premium_amount;benefit_amount;retirement_age;quote_id;additional_premium_component;payment_frequency;sum_assured;insured_term;additional_nominal_charge;additional_multiplicative_charge;smoker"
	Then the required table and Columns should be output
| table         | columns                                   | isExcludded |
| Policy_Option | [occupation_class],[requested_start_date] | false       |
