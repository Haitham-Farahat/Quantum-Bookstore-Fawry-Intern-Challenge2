# 📚 Quantum Bookstore

**Quantum Bookstore** is a simple, extensible C# console application built for the **Fawry N² Dev Slope #10 Challenge**.  
It simulates an online bookstore system using core **Object-Oriented Programming (OOP)** principles and a clean, maintainable architecture.

---

## 🚀 Features

- 🧾 **Supports multiple book types:**
  - 📦 `PaperBook`: Has stock and can be shipped.
  - 📧 `EBook`: Sent via email and has a file type.
  - 🖼️ `ShowcaseBook`: Not for sale, used for display only.

- ➕ **Add books to the inventory** with:
  - ISBN (string)
  - Title
  - Author name
  - Published year
  - Price
  - Additional fields based on book type

- ❌ **Remove outdated books** based on a defined max age.

- 🛒 **Buy a book** by providing:
  - ISBN
  - Quantity
  - Customer email (for EBooks)
  - Shipping address (for PaperBooks)
  
  > ✅ Automatically reduces stock  
  > ❌ Throws an error if book is unavailable or quantity is insufficient  
  > 📤 Simulates sending to `ShippingService` or `MailService` (no actual implementation)  
  > 💰 Returns the total paid amount

- 🔁 **Extensible Design**: Easily add new book types without modifying existing logic (Open/Closed Principle).

- 📌 **Console outputs** are always prefixed with:  
  `"Quantum book store: ..."`

---

## 🧠 Concepts Applied

- ✅ **Object-Oriented Programming (OOP)**
  - Abstraction
  - Inheritance
  - Polymorphism

- ✅ **SOLID Principles**
  - Open/Closed Principle (OCP)

---

## 🖼️ Sample Console Output

> Below is a live preview of the application running in the console.  
> The system showcases book addition, removal, and purchase operations using clean console messages.

<div align="center">
  <img src="https://github.com/user-attachments/assets/25fcf904-a37a-46e3-9343-69c9ad7cc4f6" alt="Quantum Bookstore Console Output" style="width:80%; border-radius:10px; box-shadow:0px 4px 12px rgba(0, 0, 0, 0.1);">
</div>


