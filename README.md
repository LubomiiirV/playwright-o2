# playwright-o2
docu:
https://playwright.dev/dotnet/docs/intro


dotnet new nunit -n (nazov projektu) //treba definovať názov projektu bez () Velkemale 

cd (nazov porjektu)

dotnet add package Microsoft.Playwright.MSTest

dotnet build

pwsh bin/Debug/net8.0/playwright.ps1 install // net8.0 je aktuálna verzia, zmeniť podla potreby

HEADED=1 dotnet test // púšťa cest s browserom

$env:PWDEBUG=1 - ak chcem debugovať krok po kroku pripadne vidieť ako prebieha test v prehladači

dotnet test //pripadne mat nainstalovane extensions vo VSCODE kde sa daju púšťat on click scenáre aj debugovať

PATH to screenshots: \bin\Debug\net8.0\screenshots\

Test Generator:

pwsh bin/Debug/net8.0/playwright.ps1 codegen demo.playwright.dev/todomvc




Pripravil som nasledujucu ulohu, ktora je podmnozinou realnej prace pre danu poziciu.

Rozbehaj si playwright vo visual studio code

Vytvorenie test (BE validacie nie su nutne) na produkcnej o2 stranke pre nakup pausalu s telefonom (objednavku nedokoncovat)

Biznis process je nasledovny:
Chod na o2.sk
Odnaviguj sa do ktorehokolvek telefonu cez horne menu
Dany telefon kup s programom
Preklikaj sa všetkymi krokmi až do údajov zákazníka
Vyplnte vsetky povinne polia a oznacte povinne suhlasy a kliknite potvrdit
Tu test skonci, nakolko v dalsom kroku by ste potvrdili objednavku finalne, co nie je nutne

--all done

Bonusova Uloha:
Nagivovat sa na internet na doma. Na tejto stranke overit dostupnost internetu na doma pre lubovolnu adresu.

Testy prosim poslite nahrate na video + kod v C#.

Bonusove body:
validacie na FE
validacie na BE

pouzitie features ako screenshot obrazka alebo nahratie videa priamo z IDE -- done screenshots

vyhladanie konkretneho telefonu v kombinacii s pausalom

implementacia page object modelu -- done
