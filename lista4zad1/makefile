main:
	mcs -t:library list.cs
	mcs -t:library arr.cs -r:list.dll
	mcs main.cs -r:list.dll -r:arr.dll