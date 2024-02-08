SETUP

1. Since I made changes to the database you will have to update the path in the App.config file's connection string database path to the one in the project on your directory.
2. Run project, log in with an already created user: username: 'jsmith1', password: 'password' or register a new user.
3. Enjoy! UI should be straight forward and simple.

Tips for any database errors you might encounter:
1. You might have to create your own user on the database for access.
2. Run the commands below, for most errors I encountered this worked quite well:
sqllocaldb stop mssqllocaldb
sqllocaldb delete mssqllocaldb
sqllocaldb create MSSQLLocalDB
