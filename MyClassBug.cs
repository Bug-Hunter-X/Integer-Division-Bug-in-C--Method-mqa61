public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; // Correct handling of a == 0
        }
        if (b == 0) {
            return a; // Correct handling of b == 0
        }
        // The following line is incorrect if a and b are both negative
        return a / b; 
    }
}