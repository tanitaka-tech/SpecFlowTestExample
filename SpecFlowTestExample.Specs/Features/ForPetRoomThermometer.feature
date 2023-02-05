Feature: 温度を快適さを表す文字列に変換する
	ペットを飼うのは大変。部屋の温度を快適な温度に保つ必要があるため。
	このペット用室温計で、ペットに快適な温度かどうかを確認できるようにしたい。

Rule: 室温計の精度は0.1度単位である

Scenario: 温度が24.0度未満の時は"寒い"という文字列に変換する
	# 境界値
	Given 温度が23.9
	Then 変換後の文字列は"寒い"
	# 代表値
	Given 温度が20.0
	Then 変換後の文字列は"寒い"
	
Scenario: 温度が24.0度以上26.0度未満の時は"快適"という文字列に変換する
	# 境界値
	Given 温度が24.0
	Then 変換後の文字列は"快適"
	# 代表値
	Given 温度が25.0
	Then 変換後の文字列は"快適"
	# 境界値
	Given 温度が25.9
	Then 変換後の文字列は"快適"
	
Scenario: 温度が26.0度以上の時は"暑い"という文字列に変換する
	# 境界値
	Given 温度が26.0
	Then 変換後の文字列は"暑い"
	# 代表値
	Given 温度が30.0
	Then 変換後の文字列は"暑い"