# Adrianna Pawłowska, Anastasiia Kobzar.
## Dokumentacja techniczna: Strona Internetowa z książkami

### Dokumentacja techniczna przedstawia ogólny opis strony internetowej związanej z książkami. Projekt zostanie zbudowany w oparciu o: 
* framework ASP.NET MVC
* Entity FrameWork Core dla dostępu do danych
* język C#.

### Dodatkowo, front end oparty jest na standardach
* HTML5
* CSS3
* Bootstrap.

## Rejestracja i Logowanie użytkownika:
Użytkownicy będą mieli możliwość rejestracji oraz logowania użytkownika, co umożliwi im dostęp do funkcji sklepu, dodawania produktów do strony z zamówieniami oraz realizacji zamówień. Bez niej nie można wejść na żadną stronę.

Każdy użytkownik podczas rejestracji ma do napisania:
* First Name
* Last Name, Email
* Password
* Confirm Password
* Rola (W roli trzeba określić w osobnej podstronie, która jest dostępna tylko dla Admina, można wpisać więcej ról.)

## Strona główna:

Na stronie głównej sklepu będą produkty, które wyświetlą:
* Zdjęcie okładki
* tytuł
* cenę
* opis
* autora

Użytkownik ma możliwość kupić produkt, który zostanie zapisany w zamówieniu.

Na nagłówku będzie możliwość wyboru strony:
* Home
* Książki
* Zamówienie
* Role
* Privacy
* Rejestracja
* Logowanie.

## Książki:
Na podstronie, która jest dostępna tylko dla Admina, jest możliwość zobaczenia wszystkich książek. Może je dodawać, edytować i usuwać. Przy dodawaniu książki Admin wpisuje:
* Tytuł
* Autora
* Opis
* Img ( ścieżka w kodzie: wwwroot-> img, dotąd można dodawać zdjęcia książek ( przy dodawaniu trzeba wpisać nazwę tego obrazku np. inna.jpg))

## Zamówienia:
Użytkownicy mają dostęp do przejrzenia swoich zamówień, w których są podane dane:
* Data dodania zamówienia
* nazwa książki
* imię, nazwisko, email użytkownika, który dodał produkt
* status zamówienia

Każdy użytkownik widzi tylko własne zamówienia, oprócz administratora, który ma dostęp do wszystkich zamówień. 

## Operacje CRUD dla Administratora:
Administrator sklepu będzie miał możliwość przeprowadzania operacji CRUD (Create, Read, Update, Delete) na wszystkich podstronach.
Baza danych, oparta na systemie zarządzania bazą danych SQL będzie zawierała takie tabele:
### Tabela Book przechowuje informacje o książkach, takie jak:
* Obrazek
* Tytuł
* Cena
* Opis
### Tabela User zawiera dane użytkowników takie jak:
* Imię
* Nazwisko
* Email
* Hasło  
### Tabela Orders zawiera dane o zamówieniach zrobionych przez klientów( dane klienta, książka która została wybrana)
## Instrukcja uruchomienia projektu
Po uruchomieniu projektu nie ma dostępu do żadnej strony. Na początku trzeba utworzyć role Admin, User(z wielkiej litery), ale na podstronie Role nie będą one wyświetlone. Są one wykorzystywane i pokazywane tylko przy rejestracji. 
Dostęp do Roli jest na początku dostępny dla każdego, ponieważ jest w controllerze authorize(AppRoleController.cs-> //Authorize(Roles=”Admin”)) zakomentowany, aby na początku dało się stworzyć rolę Admin lub inny, po tym można odkomentować i tylko admin będzie mieć dostęp.
Teraz można utworzyć nowe konto i wybrać rolę. User będzie mieć dostęp do stron:
* Home
* Zamówienie
* Privacy
* Rejestracja
* Logowanie.

Administrator będzie mieć dostęp do każdej podstrony
