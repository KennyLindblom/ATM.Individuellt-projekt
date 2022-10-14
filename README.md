# ATM.Individuellt-projekt

Jag skapade en jagged array för att hålla allt innehåll av användare, pinkod, privatkonto och sparkonto. Detta funkade jättebra i början när man skapade loggin.
Problemet kom senare när man skulle bygga metoder för att ta ut pengar och flytta pengar mellan konton. I och med att all information var sparade som string gjorde 
det  hela mer kompicerat. Var tvungen att konventera från string till decimal och sen tillbaks igen till sträng vilket var otroligt svårt att få till. 

Hade jag gjort om det hade jag skapat två olika arrays, en för att hålla Användernamn och pinkod och decimal array för att hålla alla
konto saldon. som tillex,


string [,] EveryUser = new string [,] = {{"Johan", "1234"}} m.m---------
decimal [] AllAccounts = new decimal [,] = {{12345,55m, 7774,50}} m.m-------------




Mycket återkommande text string som jag skulle kunnat ha laggt i en egen metod för att bara återkalla när den texten behövs.  
Jag har lärt mig väldigt mycket under det här projektet iallfall och det ser jag som ett stort plus. 
