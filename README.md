Generator Kocich Faktów (Blazor Web App)
Krótka aplikacja webowa napisana w C# i .NET 8 (Blazor Interactive Server), służąca do asynchronicznego pobierania ciekawostek o kotach z zewnętrznego API i zarządzania ich historią w lokalnym pliku tekstowym. Projekt prezentuje znajomość wzorca Dependency Injection, operacji wejścia/wyjścia (I/O) oraz tworzenia nowoczesnych, reaktywnych interfejsów użytkownika.

🚀 Główne funkcjonalności
Integracja z API: Pobieranie danych w formacie JSON z publicznego endpointu catfact.ninja przy użyciu wbudowanego HttpClient.

Zarządzanie plikami (I/O): Trwały zapis pobranych faktów do pliku .txt z zachowaniem historii i dynamiczną numeracją kolejnych wpisów.

Separacja logiki: Wykorzystanie wzorca Dependency Injection (wstrzykiwanie zależności). Dedykowany FactStorageService w pełni separuje logikę pracy na plikach od komponentów wizualnych .razor.

Niestandardowy UI (Dark Mode): W pełni autorski, nowoczesny interfejs graficzny oparty na CSS Flexbox, zmiennych CSS i animacjach (zbudowany od zera, bez użycia gotowych frameworków jak Bootstrap).

Zarządzanie historią: Osobna podstrona do odczytu pliku z zaimplementowanym niestandardowym okienkiem modalnym (popup) do bezpiecznego usuwania całej historii.

🛠️ Technologie
Backend: C#, .NET 8, ASP.NET Core

Frontend: Blazor, HTML5, CSS3

Architektura: Dependency Injection, Asynchronous Programming (async/await)

⚙️ Jak uruchomić
Sklonuj repozytorium na swój dysk.

Otwórz plik rozwiązania (.sln) w programie Visual Studio.

Uruchom projekt. Aplikacja automatycznie wygeneruje plik fakty_o_kotach.txt w głównym katalogu podczas pierwszego zapisu.
