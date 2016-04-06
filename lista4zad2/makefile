main:
	mcs -t:library prime.cs
	mcs main.cs -r:prime.dll
	touch prime.txt
	mono main.exe >prime.txt
	open prime.txt
	