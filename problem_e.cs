Action<int> action = new Action<int>(Method1); // Method1 is some static method
var val = action.invoke(5);
