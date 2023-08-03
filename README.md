# Classic Multiplayer Battleship Game 
![Screenshot_1](https://github.com/AlexhsV/Battleship-Multiplayer/assets/98179885/226b1120-807d-464d-a30c-c4f40b94f9e2)
![Screenshot_2](https://github.com/AlexhsV/Battleship-Multiplayer/assets/98179885/9027358b-7c2c-4616-8d30-52b27a7d5674)
![Screenshot_3](https://github.com/AlexhsV/Battleship-Multiplayer/assets/98179885/1615e68c-4ecf-48cd-92c3-2223e6d90af9)
![Screenshot_7](https://github.com/AlexhsV/Battleship-Multiplayer/assets/98179885/92a92c8b-1525-4cd5-a8db-7005e4d00b92)


**Introduction**

This documentation provides an overview of the Classic Battleship Game developed using C# and a cluster MongoDB. The game is a digital adaptation of the popular board game Battleship, where two players take turns guessing the locations of each other's ships on a grid. The game has been implemented using C# programming language and utilizes a cluster MongoDB to store game data and player records.

**Requirements**

Before running the Classic Battleship Game, ensure you have the following prerequisites: .NET Core SDK: Install the latest .NET Core SDK on your system. MongoDB Cluster: Set up a MongoDB cluster to store game data and player records. Obtain the connection string and database credentials.

**Game Rules**

The Classic Battleship Game follows the traditional rules of the Battleship board game: Each player has a grid (typically 10x10) where they place their ships. Ships come in different sizes (e.g., carrier, battleship, cruiser, destroyer, and submarine). Players take turns guessing the coordinates of the opponent's ships. If a guess hits a ship, it's marked as a hit. If it misses, it's marked as a miss. The game ends when all the ships of one player have been sunk.

**Setup and Installation**

Clone the repository: git clone https://github.com/yourusername/battleship-game.git Navigate to the project directory: cd battleship-game Restore the dependencies: dotnet restore Configure MongoDB connection: Open the appsettings.json file and replace the <YOUR_CONNECTION_STRING> and <YOUR_DATABASE_NAME> placeholders with your MongoDB connection string and database name.

**Running the Game**

Build the project: dotnet build Run the game: dotnet run

**Game Flow**

Upon starting the game, players will be prompted to set up their ships on the grid. They will be asked to enter the starting coordinate and direction for each ship. Players take turns to guess the opponent's ship locations. They input the coordinates of their target on the opponent's grid. The game will display the result of each guess (hit or miss) and will update the grid with the hit/miss markers. The game continues until one player's ships are all sunk. At the end of the game, the winner will be declared, and the option to play again or exit will be provided.

**MongoDB Cluster**

The game utilizes a cluster MongoDB to store the following data: Player Records: The game maintains records of each player's performance, including the number of games played, wins, and losses. Game Data: Each game's progress and details, such as player moves, hits, and misses, are stored in the database for analysis and review.

![Screenshot_10](https://github.com/AlexhsV/Battleship-Multiplayer/assets/98179885/6938e5b8-57b1-4ce4-86c9-82fda20b849d)

**Conclusion**

The Classic Battleship Game is a fun and interactive C# implementation of the classic board game Battleship. It provides an opportunity for players to test their strategy and guessing skills against either human opponents or AI. With the integration of MongoDB, player records and game data can be stored and analyzed for future improvements. Feel free to expand and modify the game further to suit your preferences and requirements. Enjoy playing and have fun!
