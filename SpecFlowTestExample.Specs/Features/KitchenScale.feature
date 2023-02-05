Feature: 重さを文字列に変換する

Rule: 重さは1g単位である
	
Scenario: 重さがマイナスなら"EEEE"に変換する
	# 境界値
	Given 重さが-1g
	Then 重さを変換後の文字列は"EEEE"
	# 代表値
	Given 重さが-10g
	Then 重さを変換後の文字列は"EEEE"