public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b;
        }
        if (b == 0) {
            return a;
        }

        // Handle negative numbers correctly using Math.Abs and accounting for sign
        bool negativeResult = (a < 0 && b > 0) || (a > 0 && b < 0);
        int result = Math.Abs(a) / Math.Abs(b);
        return negativeResult ? -result : result;
    }
}