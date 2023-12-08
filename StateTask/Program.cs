using StateTask;

FileManager fileManager = new FileManager();


fileManager.OpenFile();
fileManager.ReadFile();


fileManager.CloseFile();
fileManager.ReadFile();