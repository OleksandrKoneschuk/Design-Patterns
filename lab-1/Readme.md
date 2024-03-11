### a. DRY (Don't Repeat Yourself)

- **Дотримання принципу:**
  - Код уник повторювання коду за допомогою використання методу `GetIntegerInput`, який обробляє введення цілих чисел з клавіатури.

- **Посилання на код:**
  - [GetIntegerInput метод](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L143-L147)

---

### b. KISS (Keep It Simple, Stupid)

- **Дотримання принципу:**
  - Код використовує прості структури даних і прості алгоритми для досягнення своїх мет.

- **Посилання на код:**
  - [Оголошення класів та методів](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L9-L89)

---

### c. SOLID (5 окремих принципів)

1. **Single Responsibility Principle (SRP):**
   - Кожен клас відповідає за одну основну відповідальність.
     - [Money клас](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L9-L34)
     - [Product клас](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L36-L45)
     - [Warehouse клас](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L47-L59)
     - [Reporting клас](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L61-L89)

2. **Open/Closed Principle (OCP):**
   - Код може бути легко розширений для нових можливостей без модифікації існуючого коду.
     - [Основний код Main методу](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L123-L133)

3. **Liskov Substitution Principle (LSP):**
   - Об'єкти класів можуть бути використані замість об'єктів базового класу без змін функціональності.
     - [Використання класів Money, Product, Warehouse, Reporting](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L97)

4. **Dependency Inversion Principle (DIP):**
   - Залежність від абстракцій (інтерфейсів та абстрактних класів), а не від конкретних реалізацій.
     - [Використання інтерфейсів та списку](https://github.com/OleksandrKoneschuk/Design-Patterns/blob/main/lab-1/ConsoleApp/ConsoleApp/Program.cs#L63)

5. **Interface Segregation Principle (ISP):**
   - Класи не повинні залежати від інтерфейсів, які вони не використовують.
     - На даний момент, у коді не використовуються інтерфейси, але принцип може бути використаний при додаванні нових функцій.

---

### d. YAGNI (You Ain't Gonna Need It)

- **Дотримання принципу:**
  - Код не містить зайвих або непотрібних функціональностей, що не використовуються на поточний момент.

---

### e. Composition Over Inheritance

- **Дотримання принципу:**
  - Код не широко використовує наслідування, а замість цього може використовувати композицію (створення об'єктів інших класів).

---

### f. Program to Interfaces not Implementations

- **Дотримання принципу:**
  - Код використовує інтерфейси та абстракції для спілкування з об'єктами.

---
