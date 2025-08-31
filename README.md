
# 🥂 Royal Family Tree Application

## 🧠 Overview
This is a C# Windows Forms application that visualizes the **Royal Family Tree (House of Windsor)**.  
It provides functionality to represent family members, their relationships, and perform searches using **Breadth-First Search (BFS)** and **Depth-First Search (DFS)** algorithms.

## 🎥 Screenshot
<img width="1671" height="746" alt="ICE_3_Working" src="https://github.com/user-attachments/assets/12eca8c1-2bda-44bf-8784-ea4da083043e" />


## 🔥 Features
- Add royal family members with attributes:
  - Name
  - Date of Birth
  - Alive/Deceased status
- Build a **family tree structure** with parent-child relationships.
- **Add children dynamically** to any family member node.
- Perform **BFS search** to find a member and track steps taken.
- Perform **DFS search** to find a member and track steps taken.
- Visualize the family tree in a GUI (Windows Forms).

## ⚖️ Class Structure
- **RoyalMember**
  - Represents a royal family member with attributes (Name, Date of Birth, Alive status).
- **FamilyTree**
  - Represents a node in the family tree with a member and their children.
  - Supports adding children and searching members using BFS and DFS.

## 🌙 Example Usage
```csharp
RoyalMember queen = new RoyalMember("Queen Elizabeth II", "21 April 1926", false);
FamilyTree familyTree = new FamilyTree(queen);

RoyalMember charles = new RoyalMember("King Charles III", "14 November 1948", true);
FamilyTree charlesNode = new FamilyTree(charles);

familyTree.AddChild(charlesNode);

var result = familyTree.Bfs("King Charles III");
if (result.node != null)
    Console.WriteLine($"Found {result.node.Member.Name} in {result.steps} steps.");
```

## 📐 Requirements
- .NET Framework (4.7.2 or later) / .NET Core
- Visual Studio 2019 or later

## 🏃 How to Run
1. Clone the repository or download the source files.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Use the GUI to explore the Royal Family Tree.

## 🚀 Future Improvements
- Implement a **graphical visualization** of the family tree in Windows Forms.
- Add functionality to **edit and remove members**.
- Allow saving and loading the family tree from a file.

---

### 📖 Author
Joshua Sutherland
- ST10255930
