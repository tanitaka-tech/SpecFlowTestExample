Feature: 重さを文字列に変換する

Rule: 重さは1g単位である
	
Scenario: 重さがマイナスなら"EEEE"に変換する
	# 境界値
	Given 重さが-1
	Then 変換後の文字列は"EEEE"
	# 代表値
	Given 重さが-10
	Then 変換後の文字列は"EEEE"