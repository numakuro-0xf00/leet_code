public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        if(x < 10) return true;
        

        int count = x.ToString().Count();
        char[] a = x.ToString().ToCharArray(0, count);
        
        for(int i = 0; i< count/2;i++){
            //Console.WriteLine(String.Format("i: {0}, i+1:{1}", a[i], a[count-(i+1)]));
            if(a[i] != a[count-(i+1)]) {
                return false;
            }

            if(i > count/2){
                break;
            }
        }
        
        return true;
    }
}
