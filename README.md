# 📝 To-Do List GUI (C# WinForms)

**Day 17** of my 30-Day C# Project-Based Learning.  
A simple desktop **To-Do app** with add/delete, due dates, priorities, and persistence.

## 🚀 Features
- Add tasks with **Title**, optional **Due Date**, and **Priority (Low/Medium/High)**
- Mark tasks **Done** directly in the grid
- **Delete** selected tasks
- **Auto-save** to `tasks.xml` on exit + **manual Save** button
- Loads tasks on startup

## 🛠 Tech
- C# 7.3 • WinForms • XML serialization (no NuGet needed)

## 📥 Run
1. `git clone https://github.com/<your-username>/TodoListGUI.git`
2. Open in **Visual Studio**
3. Build & Run (`F5`)

## 📸 Screenshots
| Main | 
|------|
| ![Screenshot](./TodoList.png) |



## 📚 What I practiced
- `BindingList<T>` + `DataGridView` data binding
- `DateTimePicker` with `ShowCheckBox` for optional dates
- XML serialize/deserialize a `List<T>` to a file
- Form lifecycle: load, close, and **persist state**


